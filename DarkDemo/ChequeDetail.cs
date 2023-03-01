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

        private void ChequeDetail_Load(object sender, EventArgs e)
        {
            drpcus2.Visible = false;
            lblCusName.Visible = false;
        }
    }
}
