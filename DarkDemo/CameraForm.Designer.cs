namespace DarkDemo
{
    partial class CameraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button9;
            System.Windows.Forms.Button button8;
            System.Windows.Forms.Button btnCapture;
            System.Windows.Forms.Button BtnContinue;
            System.Windows.Forms.Button btnStop;
            System.Windows.Forms.Button btnSave;
            System.Windows.Forms.Button btnStart;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalImages = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            button9 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            btnCapture = new System.Windows.Forms.Button();
            BtnContinue = new System.Windows.Forms.Button();
            btnStop = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button9
            // 
            button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(45)))));
            button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            button9.Location = new System.Drawing.Point(21, 130);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(275, 44);
            button9.TabIndex = 39;
            button9.Text = "Change Resolution";
            button9.UseVisualStyleBackColor = false;
            button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(45)))));
            button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            button8.Location = new System.Drawing.Point(312, 130);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(275, 44);
            button8.TabIndex = 38;
            button8.Text = "Advance Settings";
            button8.UseVisualStyleBackColor = false;
            button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnCapture
            // 
            btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(45)))));
            btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCapture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            btnCapture.Location = new System.Drawing.Point(157, 69);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new System.Drawing.Size(130, 44);
            btnCapture.TabIndex = 37;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = false;
            btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // BtnContinue
            // 
            BtnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(45)))));
            BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnContinue.ForeColor = System.Drawing.Color.Black;
            BtnContinue.Location = new System.Drawing.Point(565, 69);
            BtnContinue.Name = "BtnContinue";
            BtnContinue.Size = new System.Drawing.Size(130, 44);
            BtnContinue.TabIndex = 36;
            BtnContinue.Text = "Continue";
            BtnContinue.UseVisualStyleBackColor = false;
            BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // btnStop
            // 
            btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(45)))));
            btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnStop.ForeColor = System.Drawing.Color.Black;
            btnStop.Location = new System.Drawing.Point(429, 69);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(130, 44);
            btnStop.TabIndex = 35;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(45)))));
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            btnSave.Location = new System.Drawing.Point(293, 69);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(130, 44);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStart
            // 
            btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(45)))));
            btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            btnStart.Location = new System.Drawing.Point(21, 69);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(130, 44);
            btnStart.TabIndex = 33;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Visible = false;
            btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(507, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 273);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 293);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(9)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.lblTotalImages);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(button9);
            this.panel1.Controls.Add(button8);
            this.panel1.Controls.Add(btnCapture);
            this.panel1.Controls.Add(BtnContinue);
            this.panel1.Controls.Add(btnStop);
            this.panel1.Controls.Add(btnSave);
            this.panel1.Controls.Add(btnStart);
            this.panel1.Location = new System.Drawing.Point(24, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 183);
            this.panel1.TabIndex = 5;
            // 
            // lblTotalImages
            // 
            this.lblTotalImages.AutoSize = true;
            this.lblTotalImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalImages.ForeColor = System.Drawing.Color.Black;
            this.lblTotalImages.Location = new System.Drawing.Point(164, 24);
            this.lblTotalImages.Name = "lblTotalImages";
            this.lblTotalImages.Size = new System.Drawing.Size(24, 25);
            this.lblTotalImages.TabIndex = 41;
            this.lblTotalImages.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(16, 23);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(144, 25);
            this.lblTotal.TabIndex = 40;
            this.lblTotal.Text = "Total Images:";
            // 
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(793, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CameraForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CameraForm_FormClosed);
            this.Load += new System.EventHandler(this.CameraForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CameraForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalImages;
        private System.Windows.Forms.Label lblTotal;
    }
}