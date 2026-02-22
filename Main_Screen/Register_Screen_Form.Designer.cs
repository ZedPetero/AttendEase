namespace AE.Application
{
    partial class Register_Screen_Form
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
            loginLink = new LinkLabel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            timerSlide = new System.Windows.Forms.Timer(components);
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtLastName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtFirstName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            btnExit = new Syncfusion.WinForms.Controls.SfButton();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtPhoneNum = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel6 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel7 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            btnRegister = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLastName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFirstName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 239);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // loginLink
            // 
            loginLink.ActiveLinkColor = Color.Gainsboro;
            loginLink.AutoSize = true;
            loginLink.Cursor = Cursors.Hand;
            loginLink.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLink.LinkColor = Color.FromArgb(40, 164, 153);
            loginLink.Location = new Point(472, 594);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(112, 30);
            loginLink.TabIndex = 12;
            loginLink.TabStop = true;
            loginLink.Text = "Click Here";
            loginLink.VisitedLinkColor = Color.FromArgb(25, 149, 138);
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Segoe UI", 16F);
            autoLabel3.ForeColor = Color.FromArgb(40, 164, 153);
            autoLabel3.Location = new Point(217, 594);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(259, 30);
            autoLabel3.TabIndex = 11;
            autoLabel3.Text = "Already have an account?";
            // 
            // timerSlide
            // 
            timerSlide.Interval = 25;
            timerSlide.Tick += timerSlide_Tick;
            // 
            // autoLabel2
            // 
            autoLabel2.BackColor = Color.Transparent;
            autoLabel2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel2.ForeColor = Color.FromArgb(40, 164, 153);
            autoLabel2.Location = new Point(548, 87);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(108, 25);
            autoLabel2.TabIndex = 16;
            autoLabel2.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.BeforeTouchSize = new Size(150, 36);
            txtLastName.BorderColor = Color.DimGray;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.CornerRadius = 15;
            txtLastName.Font = new Font("Segoe UI", 16F);
            txtLastName.Location = new Point(548, 120);
            txtLastName.MaximumSize = new Size(265, 36);
            txtLastName.MinimumSize = new Size(34, 30);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 36);
            txtLastName.TabIndex = 15;
            txtLastName.Tag = "";
            // 
            // autoLabel1
            // 
            autoLabel1.BackColor = Color.Transparent;
            autoLabel1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel1.ForeColor = Color.FromArgb(40, 164, 153);
            autoLabel1.Location = new Point(379, 87);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(111, 25);
            autoLabel1.TabIndex = 14;
            autoLabel1.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BeforeTouchSize = new Size(150, 36);
            txtFirstName.Border3DStyle = Border3DStyle.SunkenOuter;
            txtFirstName.BorderColor = Color.DimGray;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.CornerRadius = 15;
            txtFirstName.Font = new Font("Segoe UI", 16F);
            txtFirstName.Location = new Point(379, 120);
            txtFirstName.MaximumSize = new Size(265, 36);
            txtFirstName.MinimumSize = new Size(34, 30);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 36);
            txtFirstName.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.reject__2_;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Font = new Font("Segoe UI Semibold", 9F);
            btnExit.Location = new Point(728, 22);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 17;
            // 
            // autoLabel4
            // 
            autoLabel4.BackColor = Color.Transparent;
            autoLabel4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel4.ForeColor = Color.FromArgb(40, 164, 153);
            autoLabel4.Location = new Point(379, 171);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(64, 25);
            autoLabel4.TabIndex = 19;
            autoLabel4.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BeforeTouchSize = new Size(150, 36);
            txtEmail.Border3DStyle = Border3DStyle.SunkenOuter;
            txtEmail.BorderColor = Color.DimGray;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.CornerRadius = 15;
            txtEmail.Font = new Font("Segoe UI", 16F);
            txtEmail.Location = new Point(379, 204);
            txtEmail.MaximumSize = new Size(9999, 9999);
            txtEmail.MinimumSize = new Size(34, 30);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(319, 36);
            txtEmail.TabIndex = 18;
            // 
            // autoLabel5
            // 
            autoLabel5.BackColor = Color.Transparent;
            autoLabel5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel5.ForeColor = Color.FromArgb(40, 164, 153);
            autoLabel5.Location = new Point(379, 260);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(148, 25);
            autoLabel5.TabIndex = 21;
            autoLabel5.Text = "Phone Number:";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.BeforeTouchSize = new Size(150, 36);
            txtPhoneNum.Border3DStyle = Border3DStyle.SunkenOuter;
            txtPhoneNum.BorderColor = Color.DimGray;
            txtPhoneNum.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNum.CornerRadius = 15;
            txtPhoneNum.Font = new Font("Segoe UI", 16F);
            txtPhoneNum.Location = new Point(379, 293);
            txtPhoneNum.MaximumSize = new Size(9999, 9999);
            txtPhoneNum.MinimumSize = new Size(34, 30);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(319, 36);
            txtPhoneNum.TabIndex = 20;
            // 
            // autoLabel6
            // 
            autoLabel6.BackColor = Color.Transparent;
            autoLabel6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel6.ForeColor = Color.FromArgb(40, 164, 153);
            autoLabel6.Location = new Point(379, 348);
            autoLabel6.Name = "autoLabel6";
            autoLabel6.Size = new Size(103, 25);
            autoLabel6.TabIndex = 23;
            autoLabel6.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.BeforeTouchSize = new Size(150, 36);
            txtUsername.Border3DStyle = Border3DStyle.SunkenOuter;
            txtUsername.BorderColor = Color.DimGray;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.CornerRadius = 15;
            txtUsername.Font = new Font("Segoe UI", 16F);
            txtUsername.Location = new Point(379, 381);
            txtUsername.MaximumSize = new Size(9999, 9999);
            txtUsername.MinimumSize = new Size(34, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(319, 36);
            txtUsername.TabIndex = 22;
            // 
            // autoLabel7
            // 
            autoLabel7.BackColor = Color.Transparent;
            autoLabel7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            autoLabel7.ForeColor = Color.FromArgb(40, 164, 153);
            autoLabel7.Location = new Point(379, 436);
            autoLabel7.Name = "autoLabel7";
            autoLabel7.Size = new Size(96, 25);
            autoLabel7.TabIndex = 25;
            autoLabel7.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BeforeTouchSize = new Size(150, 36);
            txtPassword.Border3DStyle = Border3DStyle.SunkenOuter;
            txtPassword.BorderColor = Color.DimGray;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.CornerRadius = 15;
            txtPassword.Font = new Font("Segoe UI", 16F);
            txtPassword.Location = new Point(379, 469);
            txtPassword.MaximumSize = new Size(9999, 9999);
            txtPassword.MinimumSize = new Size(34, 30);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(319, 36);
            txtPassword.TabIndex = 24;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(40, 164, 153);
            btnRegister.Font = new Font("Segoe UI Semibold", 16F);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(379, 523);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(319, 40);
            btnRegister.Style.BackColor = Color.FromArgb(40, 164, 153);
            btnRegister.Style.ForeColor = Color.White;
            btnRegister.TabIndex = 26;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // Register_Screen_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 650);
            Controls.Add(btnRegister);
            Controls.Add(autoLabel7);
            Controls.Add(txtPassword);
            Controls.Add(autoLabel6);
            Controls.Add(txtUsername);
            Controls.Add(autoLabel5);
            Controls.Add(txtPhoneNum);
            Controls.Add(autoLabel4);
            Controls.Add(txtEmail);
            Controls.Add(btnExit);
            Controls.Add(autoLabel2);
            Controls.Add(txtLastName);
            Controls.Add(autoLabel1);
            Controls.Add(txtFirstName);
            Controls.Add(loginLink);
            Controls.Add(autoLabel3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register_Screen_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register_Screen_Form";
            Load += Register_Screen_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLastName).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFirstName).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel loginLink;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private System.Windows.Forms.Timer timerSlide;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLastName;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFirstName;
        private Syncfusion.WinForms.Controls.SfButton btnExit;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEmail;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPhoneNum;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel6;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel7;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.WinForms.Controls.SfButton btnRegister;
    }
}