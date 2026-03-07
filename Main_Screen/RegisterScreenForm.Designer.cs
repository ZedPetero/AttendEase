namespace AE.Application
{
    partial class RegisterScreenForm
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
            timerSlide = new System.Windows.Forms.Timer(components);
            txtLastName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            txtMiddleName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            btnExit = new Syncfusion.WinForms.Controls.SfButton();
            txtEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            txtPhoneNum = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            btnRegister = new Syncfusion.WinForms.Controls.SfButton();
            txtFirstName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtLastName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtMiddleName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtFirstName).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(23, 206);
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
            loginLink.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLink.LinkColor = Color.FromArgb(40, 164, 153);
            loginLink.Location = new Point(481, 595);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(121, 30);
            loginLink.TabIndex = 10;
            loginLink.TabStop = true;
            loginLink.Text = "Click Here";
            loginLink.VisitedLinkColor = Color.FromArgb(25, 149, 138);
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // timerSlide
            // 
            timerSlide.Interval = 25;
            timerSlide.Tick += timerSlide_Tick;
            // 
            // txtLastName
            // 
            txtLastName.BeforeTouchSize = new Size(155, 36);
            txtLastName.BorderColor = Color.DimGray;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.CornerRadius = 15;
            txtLastName.Font = new Font("Segoe UI", 16F);
            txtLastName.Location = new Point(390, 186);
            txtLastName.MaximumSize = new Size(9999, 36);
            txtLastName.MinimumSize = new Size(34, 30);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(319, 36);
            txtLastName.TabIndex = 3;
            txtLastName.Tag = "";
            // 
            // txtMiddleName
            // 
            txtMiddleName.BeforeTouchSize = new Size(155, 36);
            txtMiddleName.Border3DStyle = Border3DStyle.SunkenOuter;
            txtMiddleName.BorderColor = Color.DimGray;
            txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            txtMiddleName.CornerRadius = 15;
            txtMiddleName.Font = new Font("Segoe UI", 16F);
            txtMiddleName.Location = new Point(554, 114);
            txtMiddleName.MaximumSize = new Size(265, 36);
            txtMiddleName.MinimumSize = new Size(34, 30);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(155, 36);
            txtMiddleName.TabIndex = 2;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.reject__2_;
            btnExit.BackgroundImageLayout = ImageLayout.Zoom;
            btnExit.Font = new Font("Segoe UI Semibold", 9F);
            btnExit.Location = new Point(728, 22);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 9;
            btnExit.Click += btnExit_Click;
            // 
            // txtEmail
            // 
            txtEmail.BeforeTouchSize = new Size(155, 36);
            txtEmail.Border3DStyle = Border3DStyle.SunkenOuter;
            txtEmail.BorderColor = Color.DimGray;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.CornerRadius = 15;
            txtEmail.Font = new Font("Segoe UI", 16F);
            txtEmail.Location = new Point(390, 258);
            txtEmail.MaximumSize = new Size(9999, 9999);
            txtEmail.MinimumSize = new Size(34, 30);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(319, 36);
            txtEmail.TabIndex = 4;
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.BeforeTouchSize = new Size(155, 36);
            txtPhoneNum.Border3DStyle = Border3DStyle.SunkenOuter;
            txtPhoneNum.BorderColor = Color.DimGray;
            txtPhoneNum.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNum.CornerRadius = 15;
            txtPhoneNum.Font = new Font("Segoe UI", 16F);
            txtPhoneNum.Location = new Point(390, 330);
            txtPhoneNum.MaximumSize = new Size(9999, 9999);
            txtPhoneNum.MinimumSize = new Size(34, 30);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(319, 36);
            txtPhoneNum.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.BeforeTouchSize = new Size(155, 36);
            txtUsername.Border3DStyle = Border3DStyle.SunkenOuter;
            txtUsername.BorderColor = Color.DimGray;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.CornerRadius = 15;
            txtUsername.Font = new Font("Segoe UI", 16F);
            txtUsername.Location = new Point(390, 402);
            txtUsername.MaximumSize = new Size(9999, 9999);
            txtUsername.MinimumSize = new Size(34, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(319, 36);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.BeforeTouchSize = new Size(155, 36);
            txtPassword.Border3DStyle = Border3DStyle.SunkenOuter;
            txtPassword.BorderColor = Color.DimGray;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.CornerRadius = 15;
            txtPassword.Font = new Font("Segoe UI", 16F);
            txtPassword.Location = new Point(390, 474);
            txtPassword.MaximumSize = new Size(9999, 9999);
            txtPassword.MinimumSize = new Size(34, 30);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(319, 36);
            txtPassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(40, 164, 153);
            btnRegister.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(390, 528);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(319, 40);
            btnRegister.Style.BackColor = Color.FromArgb(40, 164, 153);
            btnRegister.Style.ForeColor = Color.White;
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.BeforeTouchSize = new Size(155, 36);
            txtFirstName.Border3DStyle = Border3DStyle.SunkenOuter;
            txtFirstName.BorderColor = Color.DimGray;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.CornerRadius = 15;
            txtFirstName.Font = new Font("Segoe UI", 16F);
            txtFirstName.Location = new Point(390, 114);
            txtFirstName.MaximumSize = new Size(265, 36);
            txtFirstName.MinimumSize = new Size(34, 30);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(155, 36);
            txtFirstName.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(390, 83);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(101, 25);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(40, 164, 153);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(40, 164, 153);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Inter", 12F);
            kryptonLabel1.TabIndex = 28;
            kryptonLabel1.TabStop = false;
            kryptonLabel1.Values.Text = "First Name:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(554, 83);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(115, 25);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(40, 164, 153);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(40, 164, 153);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Inter", 12F);
            kryptonLabel2.TabIndex = 29;
            kryptonLabel2.TabStop = false;
            kryptonLabel2.Values.Text = "Middle Name";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(390, 156);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(100, 25);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(40, 164, 153);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(40, 164, 153);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Inter", 12F);
            kryptonLabel3.TabIndex = 30;
            kryptonLabel3.TabStop = false;
            kryptonLabel3.Values.Text = "Last Name:";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(390, 227);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(90, 25);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.FromArgb(40, 164, 153);
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.FromArgb(40, 164, 153);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Inter", 12F);
            kryptonLabel4.TabIndex = 31;
            kryptonLabel4.TabStop = false;
            kryptonLabel4.Values.Text = "Email:";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(390, 300);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(133, 25);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.FromArgb(40, 164, 153);
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.FromArgb(40, 164, 153);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Inter", 12F);
            kryptonLabel5.TabIndex = 32;
            kryptonLabel5.TabStop = false;
            kryptonLabel5.Values.Text = "Phone Number:";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(390, 371);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(96, 25);
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.FromArgb(40, 164, 153);
            kryptonLabel6.StateCommon.ShortText.Color2 = Color.FromArgb(40, 164, 153);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Inter", 12F);
            kryptonLabel6.TabIndex = 33;
            kryptonLabel6.TabStop = false;
            kryptonLabel6.Values.Text = "Username:";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(390, 444);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(93, 25);
            kryptonLabel7.StateCommon.ShortText.Color1 = Color.FromArgb(40, 164, 153);
            kryptonLabel7.StateCommon.ShortText.Color2 = Color.FromArgb(40, 164, 153);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Inter", 12F);
            kryptonLabel7.TabIndex = 34;
            kryptonLabel7.TabStop = false;
            kryptonLabel7.Values.Text = "Password:";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            kryptonLabel8.Location = new Point(207, 594);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(278, 31);
            kryptonLabel8.StateCommon.ShortText.Color1 = Color.FromArgb(40, 164, 153);
            kryptonLabel8.StateCommon.ShortText.Color2 = Color.FromArgb(40, 164, 153);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel8.TabIndex = 35;
            kryptonLabel8.TabStop = false;
            kryptonLabel8.Values.Text = "Already have an account?";
            // 
            // Register_Screen_Form
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 650);
            Controls.Add(kryptonLabel8);
            Controls.Add(kryptonLabel7);
            Controls.Add(kryptonLabel6);
            Controls.Add(kryptonLabel5);
            Controls.Add(kryptonLabel4);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(txtFirstName);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPhoneNum);
            Controls.Add(txtEmail);
            Controls.Add(btnExit);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(loginLink);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register_Screen_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register_Screen_Form";
            Load += Register_Screen_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtLastName).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtMiddleName).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtEmail).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPhoneNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtFirstName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel loginLink;
        private System.Windows.Forms.Timer timerSlide;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtLastName;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtMiddleName;
        private Syncfusion.WinForms.Controls.SfButton btnExit;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEmail;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPhoneNum;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.WinForms.Controls.SfButton btnRegister;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtFirstName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
    }
}