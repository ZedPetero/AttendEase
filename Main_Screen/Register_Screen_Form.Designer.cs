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
            pictureBox1 = new PictureBox();
            loginLink = new LinkLabel();
            autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo__not_final_;
            pictureBox1.Location = new Point(220, -58);
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
            loginLink.LinkColor = Color.White;
            loginLink.Location = new Point(472, 435);
            loginLink.Name = "loginLink";
            loginLink.Size = new Size(112, 30);
            loginLink.TabIndex = 12;
            loginLink.TabStop = true;
            loginLink.Text = "Click Here";
            loginLink.LinkClicked += loginLink_LinkClicked;
            // 
            // autoLabel3
            // 
            autoLabel3.Font = new Font("Segoe UI", 16F);
            autoLabel3.ForeColor = Color.White;
            autoLabel3.Location = new Point(217, 435);
            autoLabel3.Name = "autoLabel3";
            autoLabel3.Size = new Size(259, 30);
            autoLabel3.TabIndex = 11;
            autoLabel3.Text = "Already have an account?";
            // 
            // Register_Screen_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 164, 153);
            ClientSize = new Size(800, 500);
            Controls.Add(loginLink);
            Controls.Add(autoLabel3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register_Screen_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register_Screen_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private LinkLabel loginLink;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
    }
}