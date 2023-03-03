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
            System.Windows.Forms.Button btnStart;
            System.Windows.Forms.Button btnSave;
            System.Windows.Forms.Button btnStop;
            System.Windows.Forms.Button BtnContinue;
            System.Windows.Forms.Button btnCapture;
            System.Windows.Forms.Button button8;
            System.Windows.Forms.Button button9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnStart = new System.Windows.Forms.Button();
            btnSave = new System.Windows.Forms.Button();
            btnStop = new System.Windows.Forms.Button();
            BtnContinue = new System.Windows.Forms.Button();
            btnCapture = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = System.Drawing.Color.White;
            btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            btnStart.Location = new System.Drawing.Point(33, 355);
            btnStart.Name = "btnStart";
            btnStart.Size = new System.Drawing.Size(130, 44);
            btnStart.TabIndex = 24;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.White;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            btnSave.Location = new System.Drawing.Point(305, 355);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(130, 44);
            btnSave.TabIndex = 25;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStop
            // 
            btnStop.BackColor = System.Drawing.Color.Red;
            btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnStop.ForeColor = System.Drawing.Color.White;
            btnStop.Location = new System.Drawing.Point(441, 355);
            btnStop.Name = "btnStop";
            btnStop.Size = new System.Drawing.Size(130, 44);
            btnStop.TabIndex = 26;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // BtnContinue
            // 
            BtnContinue.BackColor = System.Drawing.Color.GreenYellow;
            BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnContinue.ForeColor = System.Drawing.Color.Black;
            BtnContinue.Location = new System.Drawing.Point(577, 355);
            BtnContinue.Name = "BtnContinue";
            BtnContinue.Size = new System.Drawing.Size(130, 44);
            BtnContinue.TabIndex = 27;
            BtnContinue.Text = "Continue";
            BtnContinue.UseVisualStyleBackColor = false;
            BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
            // 
            // btnCapture
            // 
            btnCapture.BackColor = System.Drawing.Color.White;
            btnCapture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCapture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            btnCapture.Location = new System.Drawing.Point(169, 355);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new System.Drawing.Size(130, 44);
            btnCapture.TabIndex = 28;
            btnCapture.Text = "Capture";
            btnCapture.UseVisualStyleBackColor = false;
            btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // button8
            // 
            button8.BackColor = System.Drawing.Color.White;
            button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            button8.Location = new System.Drawing.Point(324, 416);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(275, 44);
            button8.TabIndex = 29;
            button8.Text = "Advance Settings";
            button8.UseVisualStyleBackColor = false;
            button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            button9.BackColor = System.Drawing.Color.White;
            button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            button9.Location = new System.Drawing.Point(33, 416);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(275, 44);
            button9.TabIndex = 30;
            button9.Text = "Change Resolution";
            button9.UseVisualStyleBackColor = false;
            button9.Click += new System.EventHandler(this.button9_Click);
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
            // CameraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(793, 488);
            this.Controls.Add(button9);
            this.Controls.Add(button8);
            this.Controls.Add(btnCapture);
            this.Controls.Add(BtnContinue);
            this.Controls.Add(btnStop);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnStart);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CameraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CameraForm";
            this.Load += new System.EventHandler(this.CameraForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CameraForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}