using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            
            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";

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
                                            BadCustomer = a.IsBad

                                        }).OrderByDescending(p => p.CustomerID).ToList().ToList();
            //dataGridView1.DataSource = db.tblCustomerInfoes.OrderByDescending(p => p.CustomerID).ToList();
        }
        private void button4_Click(object sender, EventArgs e)
        {
         
            ChequeDetail obj = new ChequeDetail();
            obj.ShowDialog();
        }
        DBLiquiorShopEntities db = new DBLiquiorShopEntities();

        public bool IsEmpty()
        {
            if (txtCity.Text.Trim() == string.Empty || txtDate.Text.Trim() == string.Empty || txtFirstName.Text.Trim() == string.Empty || txtLastName.Text.Trim() == string.Empty ||
                txtLicense.Text.Trim() == string.Empty || txtPhone.Text.Trim() == string.Empty
                || txtSSN.Text.Trim() == string.Empty || txtState.Text.Trim() == string.Empty || txtMiddle.Text.Trim() == string.Empty
                || txtAddress.Text.Trim() == string.Empty
                || txtZipCode.Text.Trim() == string.Empty
                || txtWorkPhone.Text.Trim() == string.Empty)
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

            pictureBox2.Image = DarkDemo.Properties.Resources.photo_camera;
            pictureBox1.Image = DarkDemo.Properties.Resources.scanner;

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!IsEmpty())
            {
                string Tag = lblTag.Tag.ToString();
                if (CameraImages.Count > 0 && ScannerImages.Count > 0)
                {
                  

                    if (Tag == "Add")
                    {

                        tblCustomerInfo obj = new tblCustomerInfo();
                        obj.CusSSn = txtSSN.Text;
                        obj.CusDOB = Convert.ToDateTime(txtDate.Text);
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

                        foreach (var item in CameraImages)
                        {
                            tblCameraImage obj2 = new tblCameraImage();
                            obj2.MainImage = ImageToByteArray(item);
                            obj2.CustomerID = CusID;

                            db.tblCameraImages.Add(obj2);
                            db.SaveChanges();
                        }

                        foreach (var item in ScannerImages)
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
                }
                else if (Tag == "Update")
                {
                    if (ID != 0)
                    {
                        var rec = db.tblCustomerInfoes.Where(p => p.CustomerID == ID).FirstOrDefault();

                        rec.CusAddress = txtAddress.Text;
                        rec.CusCity = txtCity.Text;
                        rec.CusDOB = Convert.ToDateTime(txtDate.Text);
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
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Multiselect = true;

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in open.FileNames)
                {
                    CameraImages.Add(
                       new Bitmap(item));

                    pictureBox2.Image = new Bitmap(open.FileName);
                }
                lblPictureSelected.Text = open.FileNames.Length.ToString() + ": Pictures Selected";
                // display image in picture box  

                // image file path  
                // textBox1.Text = open.FileName;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                if (Convert.ToBoolean(Myrow.Cells[13].Value) == true)// Or your condition 
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
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Multiselect = true;

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                foreach (var item in open.FileNames)
                {
                    ScannerImages.Add(
                       new Bitmap(item));

                    pictureBox1.Image = new Bitmap(open.FileName);
                }
                lblScannerSelected.Text = open.FileNames.Length.ToString() + ": Scanned Images Selected";
                // display image in picture box  

                // image file path  
                // textBox1.Text = open.FileName;
            }
        }

        private void Customer_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(41, 44, 51), ButtonBorderStyle.Solid);

        }
    }
}
