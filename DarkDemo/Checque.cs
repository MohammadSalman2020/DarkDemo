using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class Checque : Form
    {
        public Checque()
        {
            InitializeComponent();
        }
        DBLiquiorShopEntities db = new DBLiquiorShopEntities();
        private void button1_Click(object sender, EventArgs e)
        {
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
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,


                                                }).Where(p => p.CheckID == CheckID).OrderByDescending(p => p.CheckID).ToList();
                }
                catch (Exception ex)
                {

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
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,


                                                }).Where(p => p.CustomerID == CustomerID).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {

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
                                                    CheckID = a.CheckID,
                                                    CustomerID = a.CustomerId,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,


                                                }).Where(p => p.CompanyName == CompanyName).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {

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
                                                    CheckID = a.CheckID,
                                                    CustomerID = a.CustomerId,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,


                                                }).Where(p => p.FeeAmount == FeeAmount).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {

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
                                                    CheckID = a.CheckID,
                                                    CustomerID = a.CustomerId,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,


                                                }).Where(p => p.NetAmount == Amount).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {

                }
            }
            else if (SortBy == "Date")
            {
                try
                {
                    DateTime Date = DateTime.Parse(dateTimePicker1.Text);
                    DateTime Date2 = DateTime.Parse(dateTimePicker2.Text);
                    dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                                join b in db.tblCustomerInfoes
                                                on a.CustomerId equals b.CustomerID
                                                select new
                                                {
                                                    CheckID = a.CheckID,
                                                    CustomerID = a.CustomerId,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,
                                                }).Where(p => p.Date >= Date && p.Date <= Date2).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {

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
                                                    CheckID = a.CheckID,
                                                    CustomerID = a.CustomerId,
                                                    FirstName = b.CusFirstname,
                                                    CompanyName = a.CompanyName,
                                                    Amount = a.CheckAmount,
                                                    FeePercentage = a.FeePercentage,
                                                    FeeAmount = a.FeeAmount,
                                                    NetAmount = a.NetAmount,
                                                    CashedBy = a.CashedBy,
                                                    Date = a.CashedDate,


                                                }).Where(p => p.CashedBy == CashedBy).OrderByDescending(p => p.CustomerID).ToList();
                }
                catch (Exception ex)
                {

                }
            }
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
                dateTimePicker2.Visible = false;

                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss"; 
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm:ss";


                dataGridView1.DataSource = (from a in db.tblCustomerChecks
                                            join b in db.tblCustomerInfoes
                                            on a.CustomerId equals b.CustomerID
                                            select new
                                            {
                                                CheckID = a.CheckID,
                                                CustomerID = a.CustomerId,
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
                dateTimePicker2.Visible = false;

            }
            else if (comboBox1.SelectedItem == "Customer")
            {
                lblTextLabel.Text = "Enter Customer ID";
                SortBy = "CustomerID";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;

            }
            else if (comboBox1.SelectedItem == "Company")
            {
                lblTextLabel.Text = "Enter Company";
                SortBy = "Company";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;

            }
            else if (comboBox1.SelectedItem == "Fee %")
            {
                lblTextLabel.Text = "Enter Fee";
                SortBy = "Fee";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;

            }
            else if (comboBox1.SelectedItem == "Amount")
            {
                lblTextLabel.Text = "Enter Amount";
                SortBy = "Amount";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;

            }
            else if (comboBox1.SelectedItem == "Date")
            {
                lblTextLabel.Text = "Enter Date Between";
                SortBy = "Date";
                txtSearchText.Visible = false;
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;


            }
            else if (comboBox1.SelectedItem == "Cashed By")
            {
                lblTextLabel.Text = "Enter Cashier";
                SortBy = "Cashier";
                txtSearchText.Visible = true;
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
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
    }
}
