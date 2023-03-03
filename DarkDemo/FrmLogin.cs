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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public static string Username="";
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DBLiquiorShopEntities db = new DBLiquiorShopEntities();
        private void button1_Click(object sender, EventArgs e)
        {

            var rec = db.tblUsers.Where(p => p.UserNAme == txtUser.Text && p.Password_ == txtPassword.Text).FirstOrDefault();
            if(rec!=null)
            {
                Username = txtUser.Text;
                Form1 obj = new Form1();

                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");

            }

        }
    }
}
