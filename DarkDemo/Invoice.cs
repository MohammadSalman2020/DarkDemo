using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DarkDemo
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        //Rest of the code
        Bitmap MemoryImage;
        public void GetPrintArea(Panel pnl)
        {
            MemoryImage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(MemoryImage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }






        Panel pannel = null;
        #region events
        public void Print(Panel pnl)
        {
            pannel = pnl;
            GetPrintArea(pnl);
            ppd.Document = printDocument1;
            ppd.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;

            e.Graphics.DrawImage(MemoryImage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                //PaperSize p = null;

                //foreach (PaperSize ps in printDocument1.PrinterSettings.PaperSizes)
                //{
                //    if (ps.PaperName.Equals(strPaperSize))
                //        p = ps;
                //}

                //printDocument1.DefaultPageSettings.PaperSize = p;
                //printDocument1.DefaultPageSettings.Landscape = true;
                //printDocument1.DocumentName = "Money Leaf-Cheque";
                //printDocument1.Print();



                //else
                //{
                Print(this.panel1);
            }
            //    PrintDialog myPrintDialog = new PrintDialog();
            //    System.Drawing.Bitmap memoryImage = new System.Drawing.Bitmap(panel1.Width, panel1.Height);
            //    panel1.DrawToBitmap(memoryImage, panel1.ClientRectangle);

            //    if (myPrintDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        printDocument1.PrinterSettings = myPrintDialog.PrinterSettings;
            //        if (SetPaperSize() != false)
            //        {
            //            System.Drawing.Printing.PrinterSettings values;
            //            values = myPrintDialog.PrinterSettings;
            //            myPrintDialog.Document = printDocument1;
            //            printDocument1.PrintController = new StandardPrintController();
            //            printDocument1.DocumentName = "Invoice";
            //            printDocument1.Print();
            //        }
            //    }
            //    printDocument1.Dispose();
            //    //}
            //}
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
        private void Invoice_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (MemoryImage != null)
                {
                    e.Graphics.DrawImage(MemoryImage, 0, 0);
                    base.OnPaint(e);
                }

                ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(249, 173, 45), ButtonBorderStyle.Solid);
            }
            catch (Exception ex)
            {
                string exx = ex.Message;
            }
        }
        DBLiquiorShopEntities db = new DBLiquiorShopEntities();
        private void Invoice_Load(object sender, EventArgs e)
        {
            txtDate.Format = DateTimePickerFormat.Custom;
            txtDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            try
            {
                var rec = db.tblCustomerInfoes.Where(p => p.CustomerID == Customer.CusID_ForInvoice).FirstOrDefault();
                var rec2 = db.tblScannerImages.Where(p => p.CustomerID == rec.CustomerID).ToList();
                var rec3 = db.tblCustomerChecks.Where(p => p.CustomerId == rec.CustomerID).FirstOrDefault();
                if (rec3 != null)
                {
                    lblDate.Text = rec3.CashedDate.ToString();
                    lblAmount.Text = rec3.NetAmount.ToString();
                    lblChequeAmount.Text = rec3.CheckAmount.ToString();
                    lblFee.Text = rec3.FeePercentage + "%".ToString();
                    lblFName.Text = rec.CusFirstname;
                    lblLastname.Text = rec.Cuslastname;
                    Fee.Text = rec3.FeePercentage.ToString();
                    pictureBox1.Image = ByteArrayToImage(rec2[0].MainScanImage);
                    pictureBox2.Image = ByteArrayToImage(rec2[1].MainScanImage);
                    txtDate.Text = rec3.CashedDate.ToString();
                }


            }
            catch (Exception ex)
            {

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime date = Convert.ToDateTime(txtDate.Text);
            DateTime date2 = date.AddHours(23.5);

            try
            {
                var rec = db.tblCustomerInfoes.Where(p => p.CustomerID == Customer.CusID_ForInvoice).FirstOrDefault();
                var rec2 = db.tblScannerImages.Where(p => p.CustomerID == rec.CustomerID).ToList();
                var rec3 = db.tblCustomerChecks.Where(p => p.CustomerId == rec.CustomerID && p.CashedDate == date).FirstOrDefault();
                if (rec3 != null)
                {

                    lblAmount.Text = rec3.NetAmount.ToString();
                    lblChequeAmount.Text = rec3.CheckAmount.ToString();
                    lblFee.Text = rec3.FeePercentage + "%".ToString();
                    lblFName.Text = rec.CusFirstname;
                    lblLastname.Text = rec.Cuslastname;
                    Fee.Text = rec3.FeePercentage.ToString();

                    lblDate.Text = rec3.CashedDate.ToString();
                    pictureBox1.Image = ByteArrayToImage(rec2[0].MainScanImage);
                    pictureBox2.Image = ByteArrayToImage(rec2[1].MainScanImage);
                }


            }
            catch (Exception ex)
            {

            }

        }

        private void Invoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Customer.CusID_ForInvoice = 0;

        }

        private void ppd_FormClosed(object sender, FormClosedEventArgs e)
        {
            MemoryImage = null;
        }
    }
}
#endregion