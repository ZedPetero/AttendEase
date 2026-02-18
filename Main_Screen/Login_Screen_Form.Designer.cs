namespace AE.Application
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
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            linkLabel2 = new LinkLabel();
            autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
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
            txtUsername.Location = new Point(268, 185);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(265, 35);
            txtUsername.TabIndex = 2;
            // 
            // autoLabel1
            // 
            autoLabel1.Font = new Font("Segoe UI", 16F);
            autoLabel1.ForeColor = Color.White;
            autoLabel1.Location = new Point(268, 152);
            autoLabel1.Name = "autoLabel1";
            autoLabel1.Size = new Size(116, 30);
            autoLabel1.TabIndex = 3;
            autoLabel1.Text = "Username:";
            // 
            // autoLabel2
            // 
            autoLabel2.Font = new Font("Segoe UI", 16F);
            autoLabel2.ForeColor = Color.White;
            autoLabel2.Location = new Point(268, 246);
            autoLabel2.Name = "autoLabel2";
            autoLabel2.Size = new Size(108, 30);
            autoLabel2.TabIndex = 5;
            autoLabel2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BeforeTouchSize = new Size(265, 35);
            txtPassword.Font = new Font("Segoe UI", 15.75F);
            txtPassword.Location = new Point(268, 279);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(265, 35);
            txtPassword.TabIndex = 4;
            // 
            // sfButton1
            // 
            sfButton1.BackColor = Color.White;
            sfButton1.Font = new Font("Segoe UI Semibold", 16F);
            sfButton1.Location = new Point(350, 351);
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
            btnExit.Location = new Point(728, 22);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 50);
            btnExit.TabIndex = 7;
            btnExit.Click += btnExit_Click;
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Segoe UI", 16F);
            autoLabel3.ForeColor = Color.White;
            autoLabel3.Location = new Point(230, 410);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(237, 30);
            autoLabel3.TabIndex = 8;
            autoLabel3.Text = "Don't have an account?";
            autoLabel3.Click += autoLabel3_Click;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Gainsboro;
            linkLabel2.AutoSize = true;
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(463, 410);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(112, 30);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Click Here";
            linkLabel2.LinkClicked += this.linkLabel2_LinkClicked;
            // 
            // autoLabel4
            // 
            autoLabel4.Font = new Font("Segoe UI", 12F);
            autoLabel4.ForeColor = Color.Red;
            autoLabel4.Location = new Point(268, 317);
            autoLabel4.Name = "autoLabel4";
            autoLabel4.Size = new Size(126, 21);
            autoLabel4.TabIndex = 11;
            autoLabel4.Text = "Invalid Password";
            // 
            // autoLabel5
            // 
            autoLabel5.Font = new Font("Segoe UI", 12F);
            autoLabel5.ForeColor = Color.Red;
            autoLabel5.Location = new Point(268, 223);
            autoLabel5.Name = "autoLabel5";
            autoLabel5.Size = new Size(131, 21);
            autoLabel5.TabIndex = 12;
            autoLabel5.Text = "Invalid Username";
            // 
            // Login_Screen_Form
            // 
            AcceptButton = sfButton1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 164, 153);
            ClientSize = new Size(800, 500);
            Controls.Add(autoLabel5);
            Controls.Add(autoLabel4);
            Controls.Add(linkLabel2);
            Controls.Add(autoLabel3);
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
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private LinkLabel linkLabel2;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
    }
}