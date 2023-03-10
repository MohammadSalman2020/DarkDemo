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
    public partial class ChequeDetail : Form
    {
        public ChequeDetail()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            drpcus2.Visible = true;
            lblCusName.Visible = true;
        }
        public void LoadData()
        {
            dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                        join b in db.tblCustomerInfoes
                                        on a.CustomerId equals b.CustomerID
                                        select new
                                        {
                                            CheckID=a.CheckID,
                                            CustomerID = a.CustomerId,
                                            FirstName = b.CusFirstname,
                                            CompanyName = a.CompanyName,
                                            Amount = a.CheckAmount,
                                            FeePercentage = a.FeePercentage,
                                            FeeAmount = a.FeeAmount,
                                            NetAmount = a.NetAmount,
                                            CashedBy = a.CashedBy,
                                            Date = a.CashedDate,


                                        }).OrderByDescending(p => p.CheckID).ToList().ToList();
            //dataGridView1.DataSource = db.tblCustomerInfoes.OrderByDescending(p => p.CustomerID).ToList();
        }
        private void ChequeDetail_Load(object sender, EventArgs e)
        {
            drpcus2.Visible = false;
            lblCusName.Visible = false;
            FillDrp();
            LoadData();

        }
        DBLiquiorShopEntities db = new DBLiquiorShopEntities();
        public void FillDrp()
        {
            var rec = (from a in db.tblCustomerInfoes
                       select new { a.CustomerID, a.CusFirstname }).ToList();
            DrpCustomer.DataSource = rec;
            DrpCustomer.ValueMember = "CustomerID";
            DrpCustomer.DisplayMember = "CusFirstname";

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtFee_KeyPress(object sender, KeyPressEventArgs e)
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

        private void DrpCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(DrpCustomer.SelectedValue.ToString());
                //int ID = 5;
                int xx = 14;
                int yy = 9;
                int zz = 116;

                panel2.Controls.Clear();
                var rec = db.tblCameraImages.Where(p => p.CustomerID == ID).ToList();

                if (rec.Count > 0)
                {
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
                        button.BackColor = Color.White;
                        button.Click += new System.EventHandler(this.btnButton_Click);
                        // labelName4.TextAlign = ContentAlignment.TopCenter;
                        //labelName.Parent = picture;


                        panel2.Controls.Add(button);

                    }
                }
                else
                {
                    panel2.Controls.Clear();
                    pictureBox2.Image = DarkDemo.Properties.Resources.photo_camera;
                    pictureBox1.Image = DarkDemo.Properties.Resources.scanner;
                }

            }
            catch (Exception ex)
            {

            }
         

        }
        public Image ByteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        void btnButton_Click(object sender, EventArgs e)
        {
            Button triggeredButton = (Button)sender;
            int ImageID = int.Parse(triggeredButton.Tag.ToString());
            var rec = db.tblCameraImages.Where(p => p.ImageID == ImageID).FirstOrDefault();
            pictureBox1.Image = ByteArrayToImage(rec.MainImage);



        }
        public bool IsEmpty()
        {
            if (txtAmount.Text.Trim() == string.Empty || txtCompanyName.Text.Trim() == string.Empty || txtFee.Text.Trim() == string.Empty
                || txtNetAmount.Text.Trim() == string.Empty || txtFeeAuto.Text.Trim() == string.Empty)
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
            txtFee.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtNetAmount.Text = string.Empty;
            txtFeeAuto.Text = string.Empty;

            pictureBox2.Image = DarkDemo.Properties.Resources.photo_camera;
            pictureBox1.Image = DarkDemo.Properties.Resources.scanner;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsEmpty())
            {
                tblCustomerCheck obj = new tblCustomerCheck();
                obj.CashedDate = DateTime.Now;
                obj.CashedBy = "";
                obj.CompanyName = txtCompanyName.Text;
                obj.CheckAmount = double.Parse(txtAmount.Text);
                obj.NetAmount = double.Parse(txtNetAmount.Text);
                obj.FeePercentage = double.Parse(txtFee.Text);
                obj.FeeAmount = double.Parse(txtFeeAuto.Text);
                obj.CustomerId = int.Parse(DrpCustomer.SelectedValue.ToString());

                db.tblCustomerChecks.Add(obj);
                db.SaveChanges();
                clear();
                LoadData();
                MessageBox.Show("Check Added Success");
            }
            else
            {
                MessageBox.Show("Empty fields are not allowed");
            }
        }

        private void txtFee_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double FeePer = double.Parse(txtFee.Text);
                double Amount = int.Parse(txtAmount.Text);

                double Per1 = (FeePer / Amount);
                double Per2 = Per1 * 100;


                double subtotal = Per2 * Amount;

                double total = Amount + subtotal;

                txtFeeAuto.Text = subtotal.ToString();
                txtNetAmount.Text = total.ToString();
            }
            catch (Exception ex)
            {

            }





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
    }
}
