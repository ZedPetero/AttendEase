namespace Main_Screen
{
    partial class Login_Screen_Form
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
            pictureBox1 = new PictureBox();
            txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            timerSlide = new System.Windows.Forms.Timer(components);
            btnExit = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo__not_final_;
            pictureBox1.Location = new Point(168, -55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BeforeTouchSize = new Size(265, 35);
            txtUsername.Font = new Font("Segoe UI", 15.75F);
            txtUsername.Location = new Point(268, 198);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(265, 35);
            txtUsername.TabIndex = 2;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI", 16F);
            autoLabel1.Location = new Point(268, 147);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(116, 30);
            autoLabel1.TabIndex = 3;
            autoLabel1.Text = "Username:";
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Segoe UI", 16F);
            autoLabel2.Location = new Point(268, 267);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(108, 30);
            autoLabel2.TabIndex = 5;
            autoLabel2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BeforeTouchSize = new Size(265, 35);
            txtPassword.Font = new Font("Segoe UI", 15.75F);
            txtPassword.Location = new Point(268, 318);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(265, 35);
            txtPassword.TabIndex = 4;
            // 
            // sfButton1
            // 
            sfButton1.BackColor = Color.White;
            sfButton1.Font = new Font("Segoe UI Semibold", 16F);
            sfButton1.Location = new Point(350, 397);
            sfButton1.Name = "sfButton1";
            sfButton1.Size = new Size(100, 40);
            sfButton1.Style.BackColor = Color.White;
            sfButton1.TabIndex = 6;
            sfButton1.Text = "Login";
            sfButton1.UseVisualStyleBackColor = false;
            sfButton1.Click += sfButton1_Click;
            // 
            // timerSlide
            // 
            timerSlide.Interval = 25;
            timerSlide.Tick += timerSlide_Tick;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.reject;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Font = new Font("Segoe UI Semibold", 9F);
            btnExit.Location = new Point(738, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 7;
            btnExit.Click += btnExit_Click;
            // 
            // Login_Screen_Form
            // 
            AcceptButton = sfButton1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 164, 153);
            ClientSize = new Size(800, 500);
            Controls.Add(btnExit);
            Controls.Add(sfButton1);
            Controls.Add(autoLabel2);
            Controls.Add(txtPassword);
            Controls.Add(autoLabel1);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Screen_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Screen_Form";
            Load += Login_Screen_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private System.Windows.Forms.Timer timerSlide;
        private Syncfusion.WinForms.Controls.SfButton btnExit;
    }
}