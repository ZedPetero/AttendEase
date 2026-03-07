namespace AE.Application
{
    partial class UCTeacher
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            panelTeacherProfile = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)panelTeacherProfile).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // panelTeacherProfile
            // 
            panelTeacherProfile.Location = new Point(300, 88);
            panelTeacherProfile.Name = "panelTeacherProfile";
            panelTeacherProfile.Size = new Size(550, 520);
            panelTeacherProfile.StateCommon.Color1 = Color.White;
            panelTeacherProfile.StateCommon.Color2 = Color.White;
            panelTeacherProfile.TabIndex = 4;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(300, 32);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(240, 50);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Inter", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 5;
            kryptonLabel1.Values.Text = "Teacher Profile";
            // 
            // panel1
            // 
            panel1.Location = new Point(634, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 50);
            panel1.TabIndex = 6;
            // 
            // UC_Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(239, 240, 241);
            Controls.Add(panel1);
            Controls.Add(kryptonLabel1);
            Controls.Add(panelTeacherProfile);
            Name = "UC_Teacher";
            Size = new Size(1150, 640);
            ((System.ComponentModel.ISupportInitialize)panelTeacherProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private Krypton.Toolkit.KryptonPanel panelTeacherProfile;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Panel panel1;
    }
}
