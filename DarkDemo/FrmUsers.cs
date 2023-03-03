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
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }
        public bool IsEmpty()
        {
            if (txtEmail.Text.Trim() == string.Empty || txtUserName.Text.Trim() == string.Empty ||
                txtPassword.Text.Trim() == string.Empty)
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
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUserName.Text = string.Empty;


        }
        DBLiquiorShopEntities db = new DBLiquiorShopEntities();
        public void LoadData()
        {
            try
            {

                dataGridView1.DataSource = (from a in db.tblUsers

                                            select new
                                            {
                                                UserID = a.UserID,
                                                Email = a.Email,
                                                Username = a.UserNAme,
                                                Password = a.Password_,

                                            }).OrderByDescending(p => p.UserID).ToList();
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsEmpty())
            {
                if (ID == 0)
                {
                    tblUser obj = new tblUser();

                    obj.Email = txtEmail.Text;

                    obj.UserNAme = txtUserName.Text;
                    obj.Password_ = txtPassword.Text;
                    db.tblUsers.Add(obj);
                    db.SaveChanges();
                    MessageBox.Show("User :" + txtUserName.Text + ", Added Success");
                    clear();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Please Click on Update or Delete");
                }

            }
            else
            {
                MessageBox.Show("Empty Data is not allowed");

            }
        }
        public static int ID = 0;
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    var rec = db.tblUsers.Where(p => p.UserID == ID).FirstOrDefault();
                    txtEmail.Text = rec.Email;
                    txtPassword.Text = rec.Password_;
                    txtUserName.Text = rec.UserNAme;



                }
            }
            catch (Exception ex)
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                var rec = db.tblUsers.Where(p => p.UserID == ID).FirstOrDefault();
                rec.Email = txtEmail.Text;
                rec.Password_ = txtPassword.Text;
                rec.UserNAme = txtUserName.Text;
                db.SaveChanges();
                MessageBox.Show("User :" + txtUserName.Text + ", Updated Success");
                clear();
                LoadData();
                ID = 0;
            }
            else
            {
                MessageBox.Show("Not selected any record");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (ID != 0)
            {
                var rec = db.tblUsers.Where(p => p.UserID == ID).FirstOrDefault();
                db.tblUsers.Remove(rec);
                db.SaveChanges();
                MessageBox.Show("User Deleted Success");
                clear();
                LoadData();
                ID = 0;

            }
            else
            {
                MessageBox.Show("Not selected any record");

            }
        }

        private void FrmUsers_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(41, 44, 51), ButtonBorderStyle.Solid);

        }
    }
}
