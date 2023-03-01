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

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "customer";
        }
        public void ClearAll(Panel x)
        {
            int count = x.Controls.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    x.Controls.RemoveAt(i);
                }
            }

        }
        public void ShowScreen()
        {

            this.IsMdiContainer = true;

          
            if (label1.Text == "customer")
            {


                ClearAll(main);
                Customer obj = new Customer();
                obj.TopLevel = false;
               
                main.Controls.Add(obj);
                obj.BringToFront();
                obj.Show();
                main.Update();



            }
            else if(label1.Text== "checque")
            {
                ClearAll(main);
                Checque obj = new Checque();
                obj.TopLevel = false;
                main.Controls.Add(obj);
                obj.BringToFront();
                obj.Show();
                main.Update();
            }



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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "customer";
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
            label1.Text = "checque";
        }
    }
}
