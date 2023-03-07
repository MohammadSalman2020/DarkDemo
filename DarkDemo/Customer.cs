using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
            Camera = new Thread(CheckCameraImages);
            Scanner = new Thread(CheckScannerImages);


            Camera.Start();
            Scanner.Start();

        }
        Thread Camera;
        Thread Scanner;
        public void CheckCameraImages()
        {
            while (true)
            {
                if (IsCameraImageAvailable)
                {

                    pictureBox2.Image = CameraForm.ImagesFromCameraForm[0];

                    lblPictureSelected.Invoke(new Action(ChangeLabelCamera));
                    // pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    IsCameraImageAvailable = false;


                }
            }

        }
        public void ChangeLabelCamera()
        {
            lblPictureSelected.Text = CameraForm.ImagesFromCameraForm.Count.ToString() + ": Pictures Selected";

        }
        public void CheckScannerImages()
        {
            while (true)
            {
                if (IsScannerImageAvailable)
                {

                    pictureBox1.Image = ScannerForm.ScannerFormImages[0];
                    lblScannerSelected.Invoke(new Action(ChangeLabelScanner));
                    //   lblScannerSelected.Text = ScannerForm.ScannerFormImages.Count.ToString() + ": Pictures Selected";
                    // pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                    IsScannerImageAvailable = false;


                }
            }

        }
        public void ChangeLabelScanner()
        {
            lblScannerSelected.Text = ScannerForm.ScannerFormImages.Count.ToString() + ": Pictures Selected";

        }
        //  public static bool CameraStatusChange = false;   IsScannerImageAvailable

        private void Customer_Load(object sender, EventArgs e)
        {


            LoadData();

        }
        public void LoadData()
        {

            dataGridView1.DataSource = (from a in db.tblCustomerInfoes

                                        select new
                                        {

                                            CustomerID = a.CustomerID,
                                            FirstName = a.CusFirstname,
                                            MiddleName = a.CusMiddlename,
                                            LastName = a.Cuslastname,
                                            Address = a.CusAddress,
                                            City = a.CusCity,
                                            State = a.CusState,
                                            ZipCode = a.CusZipCode,
                                            LicenseNo = a.CusDriverLicense,
                                            DOB = a.CusDOB,
                                            CellPhoneNo = a.CusCellPhone,
                                            WorkPhone = a.CusWorkPhone,
                                            SSN = a.CusSSn,
                                            BadCustomer = a.IsBad == true ? "Yes" : "No"

                                        }).OrderByDescending(p => p.CustomerID).ToList().ToList();

            dataGridView1.Columns[0].HeaderText = "Customer ID";
            dataGridView1.Columns[1].HeaderText = "First Name";
            dataGridView1.Columns[2].HeaderText = "Middle Name";
            dataGridView1.Columns[3].HeaderText = "Last Name";
            dataGridView1.Columns[4].HeaderText = "Address";
            dataGridView1.Columns[5].HeaderText = "City";
            dataGridView1.Columns[6].HeaderText = "State";
            dataGridView1.Columns[7].HeaderText = "Zip Code";
            dataGridView1.Columns[8].HeaderText = "Driver License #";
            dataGridView1.Columns[9].HeaderText = "DOB";
            dataGridView1.Columns[10].HeaderText = "Phone #";
            dataGridView1.Columns[11].HeaderText = "Work Phone #";
            dataGridView1.Columns[12].HeaderText = "SSN";
            dataGridView1.Columns[13].HeaderText = "Bad Customer";
            //dataGridView1.DataSource = db.tblCustomerInfoes.OrderByDescending(p => p.CustomerID).ToList();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            clear();
            ID = 0;
            CheckDetails obj = new CheckDetails();
            obj.ShowDialog();
        }
        DBLiquiorShopEntities db = new DBLiquiorShopEntities();

        public bool IsEmpty()
        {
            if (txtFirstName.Text.Trim() == string.Empty || txtLastName.Text.Trim() == string.Empty ||
                txtLicense.Text.Trim() == string.Empty
                || txtSSN.Text.Trim() == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void clear()
        {
            txtState.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtDate.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtLicense.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtSSN.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtMiddle.Text = string.Empty;
            txtZipCode.Text = string.Empty;
            txtWorkPhone.Text = string.Empty;
            lblScannerSelected.Text = "0 Scanned Images Selected ";
            lblPictureSelected.Text = "0 Camera Images Selected ";
            pictureBox2.Image = DarkDemo.Properties.Resources.photo_camera;
            pictureBox1.Image = DarkDemo.Properties.Resources.scanner;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            CameraForm.ImagesFromCameraForm = null;
            ScannerForm.ScannerFormImages = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!IsEmpty())
            {
                string Tag = lblTag.Tag.ToString();



                if (Tag == "Add")
                {
                    if (CameraForm.ImagesFromCameraForm.Count > 0
            && ScannerForm.ScannerFormImages.Count > 0)
                    {
                        tblCustomerInfo obj = new tblCustomerInfo();
                        obj.CusSSn = txtSSN.Text;
                        obj.CusDOB = txtDate.Text;
                        obj.CusCity = txtCity.Text;
                        obj.Cuslastname = txtLastName.Text;
                        obj.CusDriverLicense = txtLicense.Text;
                        obj.CusAddress = txtAddress.Text;
                        obj.CusCellPhone = txtPhone.Text;
                        obj.CusFirstname = txtFirstName.Text;
                        obj.CusState = txtState.Text;
                        obj.CusZipCode = int.Parse(txtZipCode.Text);
                        obj.CusMiddlename = txtMiddle.Text;
                        obj.CusWorkPhone = txtWorkPhone.Text;
                        db.tblCustomerInfoes.Add(obj);
                        db.SaveChanges();

                        int CusID = db.tblCustomerInfoes.Max(p => p.CustomerID);

                        foreach (var item in CameraForm.ImagesFromCameraForm)
                        {
                            tblCameraImage obj2 = new tblCameraImage();
                            obj2.MainImage = ImageToByteArray(item);
                            obj2.CustomerID = CusID;

                            db.tblCameraImages.Add(obj2);
                            db.SaveChanges();
                        }

                        foreach (var item in ScannerForm.ScannerFormImages)
                        {
                            tblScannerImage obj3 = new tblScannerImage();
                            obj3.MainScanImage = ImageToByteArray(item);
                            obj3.CustomerID = CusID;

                            db.tblScannerImages.Add(obj3);
                            db.SaveChanges();
                        }



                        MessageBox.Show("Customer :" + txtFirstName.Text + "-" + txtLastName.Text + ", Added Success");
                        clear();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Please Add Images");
                    }

                }

                else if (Tag == "Update")
                {
                    if (ID != 0)
                    {
                        var rec = db.tblCustomerInfoes.Where(p => p.CustomerID == ID).FirstOrDefault();

                        rec.CusAddress = txtAddress.Text;
                        rec.CusCity = txtCity.Text;
                        rec.CusDOB = txtDate.Text;
                        rec.CusFirstname = txtFirstName.Text;
                        rec.Cuslastname = txtLastName.Text;
                        rec.CusDriverLicense = txtLicense.Text;
                        rec.CusMiddlename = txtMiddle.Text;
                        rec.CusCellPhone = txtPhone.Text;
                        rec.CusSSn = txtSSN.Text;
                        rec.CusState = txtState.Text;
                        rec.CusWorkPhone = txtWorkPhone.Text;
                        rec.CusZipCode = int.Parse(txtZipCode.Text);

                        db.SaveChanges();
                        MessageBox.Show("Customer :" + txtFirstName.Text + "-" + txtLastName.Text + ", Updated Success");
                        clear();
                        LoadData();
                        lblTag.Tag = "Add";
                    }


                }

            }
            else
            {
                MessageBox.Show("Empty fields are not allowed");
            }
        }

        public static int ID = 0;
        private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtWorkPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtSSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtLicense_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public Image ByteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        public byte[] ImageToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public static List<Bitmap> CameraImages = new List<Bitmap>();
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                ID = int.Parse(value);
                if (ID != 0)
                {
                    var rec = db.tblCustomerInfoes.Where(p => p.CustomerID == ID).FirstOrDefault();
                    txtAddress.Text = rec.CusAddress;
                    txtCity.Text = rec.CusCity;
                    txtDate.Text = rec.CusDOB.ToString();
                    txtFirstName.Text = rec.CusFirstname;
                    txtLastName.Text = rec.Cuslastname;
                    txtLicense.Text = rec.CusDriverLicense;
                    txtMiddle.Text = rec.CusMiddlename;
                    txtPhone.Text = rec.CusCellPhone;
                    txtSSN.Text = rec.CusSSn;
                    txtState.Text = rec.CusState;
                    txtWorkPhone.Text = rec.CusWorkPhone;
                    txtZipCode.Text = rec.CusZipCode.ToString();
                    lblTag.Tag = "Update";
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {

                string message = "Are You Sure Set this customer as Bad Customer?";
                string title = "Alert";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {

                    var rec = db.tblCustomerInfoes.Where(p => p.CustomerID == ID).FirstOrDefault();

                    rec.IsBad = true;
                    db.SaveChanges();
                    LoadData();
                    clear();
                    ID = 0;
                }
                else
                {

                }



            }
            else
            {
                MessageBox.Show("Please select a customer from Data first");
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Myrow.Cells[13].Value.ToString() == "Yes")// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                }
                //else
                //{
                //    Myrow.DefaultCellStyle.BackColor = Color.Green;
                //}
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                string CusName = "";

                var DeleteSCANImages = db.tblScannerImages.Where(p => p.CustomerID == ID).ToList();
                foreach (var item in DeleteSCANImages)
                {
                    db.tblScannerImages.Remove(item);
                    db.SaveChanges();
                }
                var DeleteImages = db.tblCameraImages.Where(p => p.CustomerID == ID).ToList();
                foreach (var item in DeleteImages)
                {
                    db.tblCameraImages.Remove(item);
                    db.SaveChanges();
                }

                var DeleteCheck = db.tblCustomerChecks.Where(p => p.CustomerId == ID).ToList();
                foreach (var item in DeleteCheck)
                {
                    db.tblCustomerChecks.Remove(item);
                    db.SaveChanges();
                }


                var rec = db.tblCustomerInfoes.Where(a => a.CustomerID == ID).FirstOrDefault();
                CusName = rec.CusFirstname + "-" + rec.Cuslastname;
                db.tblCustomerInfoes.Remove(rec);
                db.SaveChanges();
                clear();
                LoadData();
                MessageBox.Show("Customer :" + CusName + ",Deleted Success");
                ID = 0;
            }
            else
            {
                MessageBox.Show("Please select a customer from Data first");

            }
        }
        public static List<Bitmap> ScannerImages = new List<Bitmap>();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //// open file dialog   
            //OpenFileDialog open = new OpenFileDialog();
            //// image filters  
            //open.Multiselect = true;

            //open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp ;*.tiff";
            //if (open.ShowDialog() == DialogResult.OK)
            //{
            //    foreach (var item in open.FileNames)
            //    {
            //        ScannerImages.Add(
            //           new Bitmap(item));

            //        pictureBox1.Image = new Bitmap(open.FileName);
            //    }
            //    lblScannerSelected.Text = open.FileNames.Length.ToString() + ": Scanned Images Selected";
            //    // display image in picture box  

            //    // image file path  
            //    // textBox1.Text = open.FileName;
            //}
        }

        private void Customer_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(249, 173, 45), ButtonBorderStyle.Solid);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ScannerForm.ScannerFormImages = null;
            pictureBox1.Image = DarkDemo.Properties.Resources.scanner;

            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            ScannerForm obj = new ScannerForm();
            obj.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CameraForm.ImagesFromCameraForm = null;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;

            pictureBox2.Image = DarkDemo.Properties.Resources.photo_camera;
            CameraForm obj = new CameraForm();
            obj.ShowDialog();
        }

        public static int CusID_ForInvoice = 0;
        private void button3_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                clear();

                CusID_ForInvoice = ID;
                Invoice frm = new Invoice();
                ID = 0;
                frm.ShowDialog();
            }
            else

            {
                MessageBox.Show("Please select a customer from Data first");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            clear();
            ID = 0;
            Check obj = new Check();
            obj.ShowDialog();
        }
        public static bool IsCameraImageAvailable = false;
        public static bool IsScannerImageAvailable = false;

    }
}
