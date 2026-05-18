namespace Brevi.Application
{
    partial class UCLoginPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            linkLabel2 = new LinkLabel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            btnLogin = new Syncfusion.WinForms.Controls.SfButton();
            autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtPassword = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            txtUsername = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            panel1 = new Panel();
            visibilityBtn = new Krypton.Toolkit.KryptonButton();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            welcomingLabel = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)txtPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Gainsboro;
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.Transparent;
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.ForeColor = Color.White;
            linkLabel2.LinkColor = Color.FromArgb(40, 164, 153);
            linkLabel2.Location = new Point(250, 344);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(87, 21);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Click Here";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // autoLabel3
            // 
            autoLabel3.BackColor = Color.Transparent;
            autoLabel3.Font = new Font("Segoe UI", 12F);
            autoLabel3.ForeColor = Color.FromArgb(108, 124, 137);
            autoLabel3.Location = new Point(85, 344);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(171, 21);
            autoLabel3.TabIndex = 18;
            autoLabel3.Text = "Don't have an account?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(40, 164, 153);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(39, 294);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(345, 35);
            btnLogin.Style.BackColor = Color.FromArgb(40, 164, 153);
            btnLogin.Style.ForeColor = Color.White;
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // autoLabel2
            // 
            autoLabel2.BackColor = Color.Transparent;
            autoLabel2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            autoLabel2.ForeColor = Color.FromArgb(29, 37, 48);
            autoLabel2.Location = new Point(39, 194);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(79, 21);
            autoLabel2.TabIndex = 16;
            autoLabel2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BeforeTouchSize = new Size(141, 32);
            txtPassword.BorderColor = Color.DimGray;
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.CornerRadius = 5;
            txtPassword.FocusBorderColor = Color.FromArgb(40, 164, 153);
            txtPassword.Font = new Font("Segoe UI", 14F);
            txtPassword.Location = new Point(39, 222);
            txtPassword.MaximumSize = new Size(9999, 9999);
            txtPassword.MinimumSize = new Size(34, 30);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(307, 32);
            txtPassword.TabIndex = 1;
            txtPassword.Tag = "";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // autoLabel1
            // 
            autoLabel1.BackColor = Color.Transparent;
            autoLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            autoLabel1.ForeColor = Color.FromArgb(29, 37, 48);
            autoLabel1.Location = new Point(39, 110);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(83, 21);
            autoLabel1.TabIndex = 14;
            autoLabel1.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BeforeTouchSize = new Size(141, 32);
            txtUsername.Border3DStyle = Border3DStyle.SunkenOuter;
            txtUsername.BorderColor = Color.DimGray;
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.CornerRadius = 5;
            txtUsername.FocusBorderColor = Color.FromArgb(40, 164, 153);
            txtUsername.Font = new Font("Segoe UI", 14F);
            txtUsername.Location = new Point(39, 138);
            txtUsername.MaximumSize = new Size(9999, 9999);
            txtUsername.MinimumSize = new Size(34, 30);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(345, 32);
            txtUsername.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(visibilityBtn);
            panel1.Controls.Add(autoLabel5);
            panel1.Controls.Add(welcomingLabel);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(autoLabel1);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(autoLabel3);
            panel1.Controls.Add(autoLabel2);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(381, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(422, 383);
            panel1.TabIndex = 22;
            // 
            // visibilityBtn
            // 
            visibilityBtn.Location = new Point(352, 222);
            visibilityBtn.Name = "visibilityBtn";
            visibilityBtn.OverrideDefault.Back.Color1 = Color.FromArgb(39, 165, 153);
            visibilityBtn.OverrideDefault.Back.Color2 = Color.FromArgb(39, 165, 153);
            visibilityBtn.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.True;
            visibilityBtn.OverrideDefault.Border.Color1 = Color.FromArgb(229, 242, 240);
            visibilityBtn.OverrideDefault.Border.Color2 = Color.FromArgb(229, 242, 240);
            visibilityBtn.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.True;
            visibilityBtn.OverrideDefault.Border.Width = 1;
            visibilityBtn.OverrideFocus.Back.Color1 = Color.FromArgb(39, 165, 153);
            visibilityBtn.OverrideFocus.Back.Color2 = Color.FromArgb(39, 165, 153);
            visibilityBtn.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.True;
            visibilityBtn.OverrideFocus.Border.Color1 = Color.FromArgb(229, 242, 240);
            visibilityBtn.OverrideFocus.Border.Color2 = Color.FromArgb(229, 242, 240);
            visibilityBtn.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            visibilityBtn.OverrideFocus.Border.Rounding = 5F;
            visibilityBtn.OverrideFocus.Border.Width = 1;
            visibilityBtn.OverrideFocus.Content.LongText.Color1 = Color.FromArgb(39, 165, 153);
            visibilityBtn.OverrideFocus.Content.LongText.Color2 = Color.FromArgb(39, 165, 153);
            visibilityBtn.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(39, 165, 153);
            visibilityBtn.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(39, 165, 153);
            visibilityBtn.Size = new Size(32, 32);
            visibilityBtn.StateCommon.Back.Color1 = Color.FromArgb(39, 165, 153);
            visibilityBtn.StateCommon.Back.Color2 = Color.FromArgb(39, 165, 153);
            visibilityBtn.StateCommon.Border.Color1 = Color.FromArgb(229, 242, 240);
            visibilityBtn.StateCommon.Border.Color2 = Color.FromArgb(229, 242, 240);
            visibilityBtn.StateCommon.Border.Rounding = 5F;
            visibilityBtn.StateCommon.Content.LongText.Color1 = Color.White;
            visibilityBtn.StateCommon.Content.LongText.Color2 = Color.White;
            visibilityBtn.StateCommon.Content.LongText.Font = new Font("Inter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            visibilityBtn.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            visibilityBtn.StatePressed.Back.Color1 = SystemColors.ActiveCaption;
            visibilityBtn.StatePressed.Back.Color2 = SystemColors.ActiveCaption;
            visibilityBtn.StatePressed.Border.Color1 = Color.DarkGray;
            visibilityBtn.StatePressed.Border.Color2 = Color.DarkGray;
            visibilityBtn.TabIndex = 22;
            visibilityBtn.TabStop = false;
            visibilityBtn.Values.DropDownArrowColor = Color.Empty;
            visibilityBtn.Values.Image = Properties.Resources.visibility_off;
            visibilityBtn.Values.Text = "";
            visibilityBtn.Click += visibilityBtn_Click;
            // 
            // autoLabel5
            // 
            autoLabel5.BackColor = Color.Transparent;
            autoLabel5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            autoLabel5.ForeColor = Color.FromArgb(108, 124, 137);
            autoLabel5.Location = new Point(94, 58);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(235, 21);
            autoLabel5.TabIndex = 21;
            autoLabel5.Text = "Sign In to your Korum Account";
            // 
            // welcomingLabel
            // 
            welcomingLabel.AutoSize = false;
            welcomingLabel.BackColor = Color.Transparent;
            welcomingLabel.Font = new Font("Inter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomingLabel.ForeColor = Color.FromArgb(29, 37, 48);
            welcomingLabel.Location = new Point(17, 23);
            welcomingLabel.Name = "welcomingLabel";
            welcomingLabel.Size = new Size(389, 35);
            welcomingLabel.TabIndex = 20;
            welcomingLabel.Text = "Welcome Back";
            welcomingLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // UCLoginPage
            // 
            AccessibleRole = AccessibleRole.IpAddress;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCLoginPage";
            Size = new Size(1184, 599);
            Load += UCLoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)txtPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsername).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private LinkLabel linkLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.WinForms.Controls.SfButton btnLogin;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtPassword;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtUsername;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private Syncfusion.Windows.Forms.Tools.AutoLabel welcomingLabel;
        private Krypton.Toolkit.KryptonButton visibilityBtn;
    }
}
