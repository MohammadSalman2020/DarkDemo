using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class CameraForm : Form
    {
        //VideoCapture capture;
        //Mat frame;

        public CameraForm()
        {
            InitializeComponent();
        }
        WebCam_PictureBox webcam;
        private void CameraForm_Load(object sender, EventArgs e)
        {
            webcam = new WebCam_PictureBox();
            webcam.InitializeWebCam(ref pictureBox1);
            ImagesFromCameraForm = new List<Bitmap>();
            webcam.Start();
        }
        public static void SaveImageCapture(System.Drawing.Image image)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.FileName = "Image";  // Default file name.
            s.DefaultExt = ".Jpg"; // Default file extension.
            s.Filter = "Image (.jpg)|*.jpg";   // Filter files by extension.

            // Show save file dialog box.
            if (s.ShowDialog() == DialogResult.OK)
            {
                // Save Image.
                string filename = s.FileName;
                FileStream fstream = new FileStream(filename, FileMode.Create);
                image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                fstream.Close();
            }
        }


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }
        public static List<Bitmap> ImagesFromCameraForm = new List<Bitmap>();


        private void btnCapture_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;

            ImagesFromCameraForm.Add(new Bitmap(pictureBox2.Image));
            lblTotalImages.Text = ImagesFromCameraForm.Count.ToString();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            webcam.Stop();
        }

        private void BtnContinue_Click(object sender, EventArgs e)
        {
            webcam.Continue();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webcam.AdvanceSetting();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webcam.ResolutionSetting();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveImageCapture(pictureBox2.Image);
        }

        private void CameraForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.FromArgb(249, 173, 45), ButtonBorderStyle.Solid);

        }

        private void CameraForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            webcam.Stop();
            if (ImagesFromCameraForm.Count > 0)
            {
                Customer.IsCameraImageAvailable = true;
               
            }

        }
    }
}
