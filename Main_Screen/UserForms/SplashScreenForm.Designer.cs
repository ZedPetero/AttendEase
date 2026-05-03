namespace Brevi.Application
{
    partial class SplashScreenForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            logoPictureBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            GIFPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GIFPictureBox).BeginInit();
            SuspendLayout();
            // 
            // logoPictureBox
            // 
            logoPictureBox.Image = Properties.Resources.Logo_Name_only_removedBg__WHITE;
            logoPictureBox.Location = new Point(40, -7);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(393, 189);
            logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPictureBox.TabIndex = 0;
            logoPictureBox.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 30;
            timer1.Tick += timer1_Tick;
            // 
            // GIFPictureBox
            // 
            GIFPictureBox.Image = (Image)resources.GetObject("GIFPictureBox.Image");
            GIFPictureBox.Location = new Point(136, 128);
            GIFPictureBox.Name = "GIFPictureBox";
            GIFPictureBox.Size = new Size(200, 200);
            GIFPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            GIFPictureBox.TabIndex = 1;
            GIFPictureBox.TabStop = false;
            // 
            // SplashScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 164, 153);
            ClientSize = new Size(473, 339);
            Controls.Add(logoPictureBox);
            Controls.Add(GIFPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Splash_Screen_Form_Load;
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)GIFPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logoPictureBox;
        private System.Windows.Forms.Timer timer1;
        private PictureBox GIFPictureBox;
    }
}