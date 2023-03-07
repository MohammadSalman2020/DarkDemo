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
    public partial class Check : Form
    {
        public Check()
        {
            InitializeComponent();
        }
        DBLiquiorShopEntities db = new DBLiquiorShopEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            bool isError = false;
            if (SortBy == "CheckID")
            {

                try
                {
                    int CheckID = int.Parse(txtSearchText.Text);
                    dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                                join b in db.tblCustomerInfoes
                                                on a.CustomerId equals b.CustomerID
                                                select new
                                                {
                                                    CheckID = a.CheckID,
                                                    CustomerID = a.CustomerId,
                                                    a.CheckNo,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,

                                                    LicenseNo = b.CusDriverLicense

                                                }).Where(p => p.CheckID == CheckID).OrderByDescending(p => p.CheckID).ToList();
                }
                catch (Exception ex)
                {
                    isError = true;
                }
            }
            if (SortBy == "All")
            {

                try
                {
                    dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                                join b in db.tblCustomerInfoes
                                                on a.CustomerId equals b.CustomerID
                                                select new
                                                {
                                                    CheckID = a.CheckID,
                                                    CustomerID = a.CustomerId,
                                                    a.CheckNo,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,

                                                    LicenseNo = b.CusDriverLicense

                                                }).OrderByDescending(p => p.CheckID).ToList();
                }
                catch (Exception ex)
                {
                    isError = true;
                }
            }
            if (SortBy == "CheckNo")
            {

                try
                {
                    string CheckNo = txtSearchText.Text;
                    dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                                join b in db.tblCustomerInfoes
                                                on a.CustomerId equals b.CustomerID
                                                select new
                                                {
                                                    CheckID = a.CheckID,
                                                    CustomerID = a.CustomerId,
                                                    a.CheckNo,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,

                                                    LicenseNo = b.CusDriverLicense

                                                }).Where(p => p.CheckNo == CheckNo).OrderByDescending(p => p.CheckID).ToList();
                }
                catch (Exception ex)
                {
                    isError = true;
                }
            }
            else if (SortBy == "CustomerID")
            {
                try
                {
                    int CustomerID = int.Parse(txtSearchText.Text);
                    dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                                join b in db.tblCustomerInfoes
                                                on a.CustomerId equals b.CustomerID
                                                select new
                                                {

                                                    CheckID = a.CheckID,
                                                    CustomerID = a.CustomerId,
                                                    a.CheckNo,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,

                                                    LicenseNo = b.CusDriverLicense

                                                }).Where(p => p.CustomerID == CustomerID).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {
                    isError = true;
                }

            }
            else if (SortBy == "Company")
            {
                try
                {
                    string CompanyName = txtSearchText.Text;
                    dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                                join b in db.tblCustomerInfoes
                                                on a.CustomerId equals b.CustomerID
                                                select new
                                                {
                                                    CompanyName = a.CompanyName,
                                                    CustomerID = a.CustomerId,
                                                    a.CheckNo,
                                                    CheckID = a.CheckID,
                                                    FirstName = b.CusFirstname,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,
                                                    LicenseNo = b.CusDriverLicense

                                                }).Where(p => p.CompanyName == CompanyName).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {
                    isError = true;
                }
            }
            else if (SortBy == "Fee")
            {
                try
                {
                    double FeeAmount = double.Parse(txtSearchText.Text);
                    dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                                join b in db.tblCustomerInfoes
                                                on a.CustomerId equals b.CustomerID
                                                select new
                                                {
                                                    FeeAmount = a.FeeAmount,
                                                    CustomerID = a.CustomerId,
                                                    a.CheckNo,
                                                    CheckID = a.CheckID,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,
                                                    LicenseNo = b.CusDriverLicense

                                                }).Where(p => p.FeeAmount == FeeAmount).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {
                    isError = true;
                }
            }
            else if (SortBy == "Amount")
            {
                try
                {
                    double Amount = double.Parse(txtSearchText.Text);
                    dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                                join b in db.tblCustomerInfoes
                                                on a.CustomerId equals b.CustomerID
                                                select new
                                                {
                                                    NetAmount = a.NetAmount,
                                                    CustomerID = a.CustomerId,
                                                    a.CheckNo,
                                                    CheckID = a.CheckID,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,
                                                    LicenseNo = b.CusDriverLicense

                                                }).Where(p => p.NetAmount == Amount).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {
                    isError = true;
                }
            }
            else if (SortBy == "Date")
            {
                try
                {
                    DateTime Date = DateTime.Parse(dateTimePicker1.Text);

                    dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                                join b in db.tblCustomerInfoes
                                                on a.CustomerId equals b.CustomerID
                                                select new
                                                {
                                                    Date = a.CashedDate,
                                                    CustomerID = a.CustomerId,
                                                    a.CheckNo,
                                                    CheckID = a.CheckID,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    LicenseNo = b.CusDriverLicense
                                                }).Where(p => p.Date == Date).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {
                    isError = true;
                }
            }
            else if (SortBy == "Cashier")
            {
                try
                {
                    string CashedBy = txtSearchText.Text;
                    dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                                join b in db.tblCustomerInfoes
                                                on a.CustomerId equals b.CustomerID
                                                select new
                                                {
                                                    CashedBy = a.CashedBy,
                                                    CustomerID = a.CustomerId,
                                                    a.CheckNo,
                                                    CheckID = a.CheckID,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    Date = a.CashedDate,
                                                    LicenseNo = b.CusDriverLicense

                                                }).Where(p => p.CashedBy == CashedBy).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {
                    isError = true;
                }
            }
            else if (SortBy == "CustomerName")
            {
                try
                {
                    string FirstName = txtSearchText.Text;
                    dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                                join b in db.tblCustomerInfoes
                                                on a.CustomerId equals b.CustomerID
                                                select new
                                                {
                                                    FirstName = b.CusFirstname,
                                                    CustomerID = a.CustomerId,
                                                    a.CheckNo,
                                                    CheckID = a.CheckID,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,
                                                    LicenseNo = b.CusDriverLicense

                                                }).Where(p => p.FirstName == FirstName).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {
                    isError = true;
                }
            }
            else if (SortBy == "License")
            {
                try
                {
                    string LicenseNo = txtSearchText.Text;
                    dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                                join b in db.tblCustomerInfoes
                                                on a.CustomerId equals b.CustomerID
                                                select new
                                                {

                                                    LicenseNo = b.CusDriverLicense,
                                                    CustomerID = a.CustomerId,
                                                    a.CheckNo,
                                                    CheckID = a.CheckID,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,


                                                }).Where(p => p.LicenseNo == LicenseNo).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {
                    isError = true;
                }
            }
            string CustomerID2 = null;
            ////foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            ////{            //Here 2 cell is target value and 1 cell is Volume

            ////  CustomerID2= Myrow.Cells[1].Value.ToString();

            ////}
            CustomerID2 = dataGridView1.Rows[0].Cells[1].Value.ToString();
            if (CustomerID2 != null && !isError && SortBy != "All")
            {
                try
                {

                    pictureBox1.Image = DarkDemo.Properties.Resources.photo_camera;
                    pictureBox2.Image = DarkDemo.Properties.Resources.scanner;
                    pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
                    pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                    int ID = int.Parse(CustomerID2);
                    //int ID = 5;


                    panel5.Controls.Clear();
                    panel4.Controls.Clear();
                    var rec = db.tblCameraImages.Where(p => p.CustomerID == ID).ToList();

                    if (rec.Count > 0)
                    {
                        int xx = 14;
                        int yy = 9;
                        int zz = 116;
                        int i = 0;

                        for (int y = 0; y < rec.Count; y++)
                        {
                            i++;
                            var button = new Button();
                            button.Tag = rec[y].ImageID;
                            button.AutoSize = false;
                            button.Size = new Size(114, 44);

                            if (y != 0)
                            {
                                xx = xx + zz;
                            }

                            button.Location = new Point(xx, yy);
                            button.Font = new Font(button.Font, FontStyle.Bold);
                            button.Text = "Image :" + i;
                            button.ForeColor = Color.Black;
                            button.BackColor = Color.FromArgb(249, 173, 45);

                            button.Click += new System.EventHandler(this.btnButton_Click);
                            // labelName4.TextAlign = ContentAlignment.TopCenter;
                            //labelName.Parent = picture;


                            panel4.Controls.Add(button);

                        }
                    }
                    else
                    {
                        panel4.Controls.Clear();
                        pictureBox2.Image = DarkDemo.Properties.Resources.photo_camera;
                        pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
                    }

                    var rec3 = db.tblScannerImages.Where(p => p.CustomerID == ID).ToList();

                    if (rec3.Count > 0)
                    {
                        int xx = 14;
                        int yy = 9;
                        int zz = 116;
                        int i = 0;

                        for (int y = 0; y < rec3.Count; y++)
                        {
                            i++;
                            var button = new Button();
                            button.Tag = rec3[y].ScanID;
                            button.AutoSize = false;
                            button.Size = new Size(114, 44);

                            if (y != 0)
                            {
                                xx = xx + zz;
                            }

                            button.Location = new Point(xx, yy);
                            button.Font = new Font(button.Font, FontStyle.Bold);
                            button.Text = "Image :" + i;
                            button.ForeColor = Color.Black;
                            button.BackColor = Color.FromArgb(249, 173, 45);

                            button.Click += new System.EventHandler(this.btnButton_Click2);
                            // labelName4.TextAlign = ContentAlignment.TopCenter;
                            //labelName.Parent = picture;


                            panel5.Controls.Add(button);

                        }
                    }
                    else
                    {
                        panel4.Controls.Clear();

                        pictureBox2.Image = DarkDemo.Properties.Resources.scanner;
                        pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
                    }


                }
                catch (Exception ex)
                {

                }
            }



        }
        public Image ByteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        void btnButton_Click2(object sender, EventArgs e)
        {
            Button triggeredButton = (Button)sender;
            int ImageID = int.Parse(triggeredButton.Tag.ToString());
            var rec = db.tblScannerImages.Where(p => p.ScanID == ImageID).FirstOrDefault();
            pictureBox2.Image = ByteArrayToImage(rec.MainScanImage);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;


        }

        void btnButton_Click(object sender, EventArgs e)
        {
            Button triggeredButton = (Button)sender;
            int ImageID = int.Parse(triggeredButton.Tag.ToString());
            var rec = db.tblCameraImages.Where(p => p.ImageID == ImageID).FirstOrDefault();
            pictureBox1.Image = ByteArrayToImage(rec.MainImage);

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        }
        public static string SortBy = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Checque_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker1.Visible = false;


                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";



                dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                            join b in db.tblCustomerInfoes
                                            on a.CustomerId equals b.CustomerID
                                            select new
                                            {
                                                CheckID = a.CheckID,
                                                CustomerID = a.CustomerId,
                                                a.CheckNo,
                                                FirstName = b.CusFirstname,
                                                CompanyName = a.CompanyName,
                                                Amount = a.CheckAmount,
                                                FeePercentage = a.FeePercentage,
                                                FeeAmount = a.FeeAmount,
                                                NetAmount = a.NetAmount,
                                                CashedBy = a.CashedBy,
                                                Date = a.CashedDate,


                                            }).OrderByDescending(p => p.CheckID).ToList();
            }
            catch (Exception ex)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "CheckID")
            {
                lblTextLabel.Text = "Enter CheckID";
                SortBy = "CheckID";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;


            }
            else if (comboBox1.SelectedItem == "CustomerID")
            {
                lblTextLabel.Text = "Enter Customer ID";
                SortBy = "CustomerID";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;


            }
            else if (comboBox1.SelectedItem == "Company")
            {
                lblTextLabel.Text = "Enter Company";
                SortBy = "Company";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;


            }
            else if (comboBox1.SelectedItem == "Fee %")
            {
                lblTextLabel.Text = "Enter Fee";
                SortBy = "Fee";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;


            }
            else if (comboBox1.SelectedItem == "Amount")
            {
                lblTextLabel.Text = "Enter Amount";
                SortBy = "Amount";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;


            }
            else if (comboBox1.SelectedItem == "Date")
            {
                lblTextLabel.Text = "Enter Date Between";
                SortBy = "Date";
                txtSearchText.Visible = false;
                dateTimePicker1.Visible = true;



            }
            else if (comboBox1.SelectedItem == "Cashed By")
            {
                lblTextLabel.Text = "Enter Cashier";
                SortBy = "Cashier";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;

            }
            else if (comboBox1.SelectedItem == "Customer Name")
            {
                lblTextLabel.Text = "Enter Customer Firstname";
                SortBy = "CustomerName";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;

            }
            else if (comboBox1.SelectedItem == "License #")
            {
                lblTextLabel.Text = "Enter License #";
                SortBy = "License";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;

            }
            else if (comboBox1.SelectedItem == "All")
            {
                lblTextLabel.Text = "All Records";
                SortBy = "All";
                txtSearchText.Visible = false;
                dateTimePicker1.Visible = false;

            }
            else if (comboBox1.SelectedItem == "Check #")
            {
                lblTextLabel.Text = "Enter Check #";
                SortBy = "CheckNo";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;

            }

        }



        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Checque_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(41, 44, 51), ButtonBorderStyle.Solid);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            foreach (DataGridViewRow Myrow in dataGridView1.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume

                int CustomerID = int.Parse(Myrow.Cells[1].Value.ToString());
                var rec = db.tblCustomerInfoes.Where(p => p.CustomerID == CustomerID).FirstOrDefault();

                if (rec.IsBad == true)// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Red;
                }
                //else
                //{
                //    Myrow.DefaultCellStyle.BackColor = Color.Green;
                //}
            }
        }

        private void comboBox1_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }
    }
}
