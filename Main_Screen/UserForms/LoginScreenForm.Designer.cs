namespace AE.Application
{
    partial class LoginScreenForm
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
            btnLogin = new Syncfusion.WinForms.Controls.SfButton();
            timerSlide = new System.Windows.Forms.Timer(components);
            btnExit = new Syncfusion.WinForms.Controls.SfButton();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            linkLabel2 = new LinkLabel();
            lblPassword = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            lblUsername = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnDarkMode = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(168, -55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BeforeTouchSize = new Size(265, 36);
            txtUsername.Border3DStyle = Border3DStyle.SunkenOuter;
            txtUsername.BorderColor = Color.DimGray;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.CornerRadius = 15;
            txtUsername.Font = new Font("Segoe UI", 16F);
            txtUsername.Location = new Point(268, 198);
            txtUsername.MaximumSize = new Size(265, 36);
            txtUsername.MinimumSize = new Size(34, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(265, 36);
            txtUsername.TabIndex = 2;
            // 
            // autoLabel1
            // 
            autoLabel1.BackColor = Color.Transparent;
            autoLabel1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.FromArgb(40, 164, 153);
            autoLabel1.Location = new Point(268, 155);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(103, 25);
            autoLabel1.TabIndex = 3;
            autoLabel1.Text = "Username:";
            // 
            // autoLabel2
            // 
            autoLabel2.BackColor = Color.Transparent;
            autoLabel2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(40, 164, 153);
            autoLabel2.Location = new Point(268, 260);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(96, 25);
            autoLabel2.TabIndex = 5;
            autoLabel2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BeforeTouchSize = new Size(265, 36);
            txtPassword.BorderColor = Color.DimGray;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.CornerRadius = 15;
            txtPassword.Font = new Font("Segoe UI", 16F);
            txtPassword.Location = new Point(268, 300);
            txtPassword.MaximumSize = new Size(265, 36);
            txtPassword.MinimumSize = new Size(34, 30);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(265, 36);
            txtPassword.TabIndex = 4;
            txtPassword.Tag = "";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 164, 153);
            btnLogin.Font = new Font("Segoe UI Semibold", 16F);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(268, 375);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(265, 40);
            btnLogin.Style.BackColor = Color.FromArgb(40, 164, 153);
            btnLogin.Style.ForeColor = Color.White;
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // timerSlide
            // 
            timerSlide.Interval = 25;
            timerSlide.Tick += timerSlide_Tick;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonFace;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Font = new Font("Segoe UI Semibold", 9F);
            btnExit.ImageSize = new Size(50, 50);
            btnExit.Location = new Point(728, 22);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.Style.BackColor = SystemColors.ButtonFace;
            btnExit.Style.Image = Properties.Resources.reject__2_;
            btnExit.TabIndex = 7;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // autoLabel3
            // 
            autoLabel3.BackColor = Color.Transparent;
            autoLabel3.Font = new Font("Segoe UI", 16F);
            autoLabel3.ForeColor = Color.FromArgb(40, 164, 153);
            autoLabel3.Location = new Point(230, 433);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(237, 30);
            autoLabel3.TabIndex = 8;
            autoLabel3.Text = "Don't have an account?";
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Gainsboro;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.ForeColor = Color.White;
            linkLabel2.LinkColor = Color.FromArgb(40, 164, 153);
            linkLabel2.Location = new Point(463, 433);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(112, 30);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Click Here";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.ForeColor = Color.Red;
            lblPassword.Location = new Point(268, 338);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(126, 21);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Invalid Password";
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI", 12F);
            lblUsername.ForeColor = Color.Red;
            lblUsername.Location = new Point(268, 236);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(131, 21);
            lblUsername.TabIndex = 12;
            lblUsername.Text = "Invalid Username";
            // 
            // btnDarkMode
            // 
            btnDarkMode.BackColor = SystemColors.ButtonFace;
            btnDarkMode.BackgroundImageLayout = ImageLayout.Zoom;
            btnDarkMode.Font = new Font("Segoe UI Semibold", 9F);
            btnDarkMode.ImageSize = new Size(30, 30);
            btnDarkMode.Location = new Point(663, 22);
            btnDarkMode.Name = "btnDarkMode";
            btnDarkMode.Size = new Size(50, 50);
            btnDarkMode.Style.BackColor = SystemColors.ButtonFace;
            btnDarkMode.Style.Image = Properties.Resources.night_mode;
            btnDarkMode.TabIndex = 13;
            btnDarkMode.UseVisualStyleBackColor = false;
            btnDarkMode.Click += btnDarkMode_Click;
            // 
            // Login_Screen_Form
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(btnDarkMode);
            Controls.Add(lblUsername);
            Controls.Add(lblPassword);
            Controls.Add(linkLabel2);
            Controls.Add(autoLabel3);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
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
        private Syncfusion.WinForms.Controls.SfButton btnLogin;
        private System.Windows.Forms.Timer timerSlide;
        private Syncfusion.WinForms.Controls.SfButton btnExit;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private LinkLabel linkLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblPassword;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblUsername;
        private Syncfusion.WinForms.Controls.SfButton btnDarkMode;
    }
}