namespace DarkDemo
{
    partial class ScannerForm
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
            this.bgwScan = new System.ComponentModel.BackgroundWorker();
            this.picScan = new System.Windows.Forms.PictureBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.txtWT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudTime = new System.Windows.Forms.NumericUpDown();
            this.pbWaiting = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbColorMode = new System.Windows.Forms.ComboBox();
            this.cbxCustomPixel = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudHeightInch = new System.Windows.Forms.NumericUpDown();
            this.nudWidthInch = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudRes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.btnStartScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightInch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthInch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // bgwScan
            // 
            this.bgwScan.WorkerReportsProgress = true;
            this.bgwScan.WorkerSupportsCancellation = true;
            this.bgwScan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwScan_DoWork);
            // 
            // picScan
            // 
            this.picScan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picScan.Location = new System.Drawing.Point(479, 13);
            this.picScan.Margin = new System.Windows.Forms.Padding(4);
            this.picScan.Name = "picScan";
            this.picScan.Size = new System.Drawing.Size(483, 655);
            this.picScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScan.TabIndex = 32;
            this.picScan.TabStop = false;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(22, 625);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(231, 22);
            this.txtPath.TabIndex = 29;
            this.txtPath.Visible = false;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(252, 683);
            this.btnSelectPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(96, 36);
            this.btnSelectPath.TabIndex = 28;
            this.btnSelectPath.Text = "Select Path";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Visible = false;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // txtWT
            // 
            this.txtWT.BackColor = System.Drawing.Color.Black;
            this.txtWT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWT.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWT.ForeColor = System.Drawing.Color.Chartreuse;
            this.txtWT.Location = new System.Drawing.Point(15, 643);
            this.txtWT.Margin = new System.Windows.Forms.Padding(4);
            this.txtWT.Name = "txtWT";
            this.txtWT.Size = new System.Drawing.Size(347, 36);
            this.txtWT.TabIndex = 52;
            this.txtWT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWT.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(365, 563);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Waiting Sec.";
            this.label2.Visible = false;
            // 
            // nudTime
            // 
            this.nudTime.Location = new System.Drawing.Point(376, 599);
            this.nudTime.Margin = new System.Windows.Forms.Padding(4);
            this.nudTime.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTime.Name = "nudTime";
            this.nudTime.Size = new System.Drawing.Size(65, 22);
            this.nudTime.TabIndex = 50;
            this.nudTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTime.Visible = false;
            // 
            // pbWaiting
            // 
            this.pbWaiting.Location = new System.Drawing.Point(12, 596);
            this.pbWaiting.Margin = new System.Windows.Forms.Padding(4);
            this.pbWaiting.Name = "pbWaiting";
            this.pbWaiting.Size = new System.Drawing.Size(349, 31);
            this.pbWaiting.TabIndex = 49;
            this.pbWaiting.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(9)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cmbColorMode);
            this.panel1.Controls.Add(this.cbxCustomPixel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nudHeightInch);
            this.panel1.Controls.Add(this.nudWidthInch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nudRes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nudHeight);
            this.panel1.Controls.Add(this.nudWidth);
            this.panel1.Controls.Add(this.btnStartScan);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 666);
            this.panel1.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(119, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 32);
            this.label7.TabIndex = 62;
            this.label7.Text = "Color Mode";
            // 
            // cmbColorMode
            // 
            this.cmbColorMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColorMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColorMode.FormattingEnabled = true;
            this.cmbColorMode.Items.AddRange(new object[] {
            "Black and White",
            "Color",
            "Gray Scale"});
            this.cmbColorMode.Location = new System.Drawing.Point(46, 15);
            this.cmbColorMode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbColorMode.Name = "cmbColorMode";
            this.cmbColorMode.Size = new System.Drawing.Size(363, 39);
            this.cmbColorMode.TabIndex = 61;
            // 
            // cbxCustomPixel
            // 
            this.cbxCustomPixel.AutoSize = true;
            this.cbxCustomPixel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCustomPixel.ForeColor = System.Drawing.Color.Black;
            this.cbxCustomPixel.Location = new System.Drawing.Point(10, 406);
            this.cbxCustomPixel.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCustomPixel.Name = "cbxCustomPixel";
            this.cbxCustomPixel.Size = new System.Drawing.Size(293, 36);
            this.cbxCustomPixel.TabIndex = 60;
            this.cbxCustomPixel.Text = "Custom Pixel Units";
            this.cbxCustomPixel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(128, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 32);
            this.label6.TabIndex = 59;
            this.label6.Text = "Pixel Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(128, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 32);
            this.label5.TabIndex = 58;
            this.label5.Text = "Pixel Width";
            // 
            // nudHeightInch
            // 
            this.nudHeightInch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHeightInch.Location = new System.Drawing.Point(10, 136);
            this.nudHeightInch.Margin = new System.Windows.Forms.Padding(4);
            this.nudHeightInch.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudHeightInch.Name = "nudHeightInch";
            this.nudHeightInch.Size = new System.Drawing.Size(87, 38);
            this.nudHeightInch.TabIndex = 57;
            this.nudHeightInch.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // nudWidthInch
            // 
            this.nudWidthInch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWidthInch.Location = new System.Drawing.Point(10, 197);
            this.nudWidthInch.Margin = new System.Windows.Forms.Padding(4);
            this.nudWidthInch.Maximum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.nudWidthInch.Name = "nudWidthInch";
            this.nudWidthInch.Size = new System.Drawing.Size(87, 38);
            this.nudWidthInch.TabIndex = 56;
            this.nudWidthInch.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 476);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 32);
            this.label1.TabIndex = 55;
            this.label1.Text = "Resolution";
            // 
            // nudRes
            // 
            this.nudRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRes.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudRes.Location = new System.Drawing.Point(10, 474);
            this.nudRes.Margin = new System.Windows.Forms.Padding(4);
            this.nudRes.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.nudRes.Minimum = new decimal(new int[] {
            75,
            0,
            0,
            0});
            this.nudRes.Name = "nudRes";
            this.nudRes.Size = new System.Drawing.Size(87, 38);
            this.nudRes.TabIndex = 54;
            this.nudRes.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(128, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 32);
            this.label4.TabIndex = 53;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(128, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 52;
            this.label3.Text = "Width";
            // 
            // nudHeight
            // 
            this.nudHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHeight.Location = new System.Drawing.Point(10, 269);
            this.nudHeight.Margin = new System.Windows.Forms.Padding(4);
            this.nudHeight.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.ReadOnly = true;
            this.nudHeight.Size = new System.Drawing.Size(87, 38);
            this.nudHeight.TabIndex = 51;
            this.nudHeight.Value = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            // 
            // nudWidth
            // 
            this.nudWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudWidth.Location = new System.Drawing.Point(10, 337);
            this.nudWidth.Margin = new System.Windows.Forms.Padding(4);
            this.nudWidth.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.ReadOnly = true;
            this.nudWidth.Size = new System.Drawing.Size(87, 38);
            this.nudWidth.TabIndex = 50;
            this.nudWidth.Value = new decimal(new int[] {
            1250,
            0,
            0,
            0});
            // 
            // btnStartScan
            // 
            this.btnStartScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(45)))));
            this.btnStartScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartScan.Location = new System.Drawing.Point(137, 578);
            this.btnStartScan.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartScan.Name = "btnStartScan";
            this.btnStartScan.Size = new System.Drawing.Size(166, 44);
            this.btnStartScan.TabIndex = 49;
            this.btnStartScan.Text = "Scan 2nd Picture";
            this.btnStartScan.UseVisualStyleBackColor = false;
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(985, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtWT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTime);
            this.Controls.Add(this.pbWaiting);
            this.Controls.Add(this.picScan);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSelectPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ScannerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScannerForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScannerForm_FormClosed);
            this.Load += new System.EventHandler(this.ScannerForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScannerForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTime)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeightInch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidthInch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgwScan;
        private System.Windows.Forms.PictureBox picScan;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox txtWT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudTime;
        private System.Windows.Forms.ProgressBar pbWaiting;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbColorMode;
        private System.Windows.Forms.CheckBox cbxCustomPixel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudHeightInch;
        private System.Windows.Forms.NumericUpDown nudWidthInch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.Button btnStartScan;
    }
}