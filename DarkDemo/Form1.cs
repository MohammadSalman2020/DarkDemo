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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DBLiquiorShopEntities db = new DBLiquiorShopEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            button6.Text= "";
            lblname.Text =FrmLogin.Username;

            var rec = db.tblCustomerInfoes.ToList().Count;

            lblTotalCustomer.Text = rec.ToString();

            var rec2 = db.tblCustomerChecks.ToList().Count;

            lblTotalCheck.Text = rec2.ToString();

            var rec3 = db.tblCustomerInfoes.Where(p=>p.IsBad==true).ToList().Count;

            lblBadTotal.Text = rec3.ToString();



            int rec4 = db.tblCustomerInfoes.Max(p => p.CustomerID);
            var rec5 = db.tblCustomerInfoes.Where(p => p.CustomerID == rec4).FirstOrDefault();
            lblLogCustomer.Text = "A new customer '" + rec5.CusFirstname+"-"+rec5.Cuslastname + "' has been Added";

            int rec6 = db.tblCustomerChecks.Max(p => p.CheckID);
            var rec7 = db.tblCustomerChecks.Where(p => p.CheckID == rec6).FirstOrDefault();
            lblLogCheck.Text = "A new check for company '"+ rec7.CompanyName +"' has been added";


            int rec8 = db.tblUsers.Max(p => p.UserID);
            var rec9 = db.tblUsers.Where(p => p.UserID == rec8).FirstOrDefault();
            lblUserLog.Text = "A new User '" + rec9.UserNAme + "' has been added";
            //label1.Text = "customer";
        }
        //public void ClearAll(Panel x)
        //{
        //    int count = x.Controls.Count;
        //    if (count > 0)
        //    {
        //        for (int i = 0; i < count; i++)
        //        {
        //            x.Controls.RemoveAt(i);
        //        }
        //    }

        //}
        public void ShowScreen()
        {




        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Tag == "min")
            {
                this.WindowState = FormWindowState.Maximized;
                button6.Tag = "max";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                button6.Tag = "min";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (panel4.Tag == "min")
            {
                this.WindowState = FormWindowState.Maximized;
                panel4.Tag = "max";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                panel4.Tag = "min";
            }

        }
        private Form activeForm = null;
        private void openChildForm(Form childform)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            //Main.Controls.Add(childform);
            //Main.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = "customer";
            Customer obj = new Customer();
            obj.ShowDialog();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            ShowScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check frm = new Check();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUsers frm = new FrmUsers();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CameraForm obj = new CameraForm();
            obj.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ScannerForm obj = new ScannerForm();
            obj.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmLogin oj = new FrmLogin();
            oj.Show();
            this.Hide();
        }

        private void lblLogCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
