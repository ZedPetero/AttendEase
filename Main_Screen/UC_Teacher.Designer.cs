namespace AE.Application
{
    partial class UC_Teacher
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
            btnEditProfile = new Krypton.Toolkit.KryptonButton();
            panelTeacherProfile = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)panelTeacherProfile).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btnEditProfile
            // 
            btnEditProfile.Location = new Point(750, 32);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(100, 50);
            btnEditProfile.StateCommon.Back.Color1 = Color.FromArgb(40, 164, 153);
            btnEditProfile.StateCommon.Back.Color2 = Color.FromArgb(40, 164, 153);
            btnEditProfile.StateCommon.Border.Rounding = 10F;
            btnEditProfile.StateCommon.Content.LongText.Color1 = Color.White;
            btnEditProfile.StateCommon.Content.LongText.Color2 = Color.White;
            btnEditProfile.StateCommon.Content.LongText.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProfile.StateCommon.Content.ShortText.Color1 = Color.White;
            btnEditProfile.StateCommon.Content.ShortText.Color2 = Color.White;
            btnEditProfile.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditProfile.StateNormal.Back.Color1 = Color.FromArgb(63, 174, 163);
            btnEditProfile.StateNormal.Back.Color2 = Color.FromArgb(63, 174, 163);
            btnEditProfile.StateNormal.Content.LongText.Color1 = Color.White;
            btnEditProfile.StateNormal.Content.LongText.Color2 = Color.White;
            btnEditProfile.StateNormal.Content.ShortText.Color1 = Color.White;
            btnEditProfile.StateNormal.Content.ShortText.Color2 = Color.White;
            btnEditProfile.StatePressed.Back.Color1 = Color.FromArgb(33, 144, 133);
            btnEditProfile.StatePressed.Back.Color2 = Color.FromArgb(33, 144, 133);
            btnEditProfile.StatePressed.Border.Color1 = Color.FromArgb(43, 154, 143);
            btnEditProfile.StatePressed.Border.Color2 = Color.FromArgb(43, 154, 143);
            btnEditProfile.StatePressed.Content.LongText.Color1 = Color.FromArgb(63, 174, 163);
            btnEditProfile.StatePressed.Content.LongText.Color2 = Color.FromArgb(63, 174, 163);
            btnEditProfile.StatePressed.Content.ShortText.Color1 = Color.FromArgb(63, 174, 163);
            btnEditProfile.StatePressed.Content.ShortText.Color2 = Color.FromArgb(63, 174, 163);
            btnEditProfile.StateTracking.Back.Color1 = Color.FromArgb(83, 194, 183);
            btnEditProfile.StateTracking.Back.Color2 = Color.FromArgb(83, 194, 183);
            btnEditProfile.StateTracking.Border.Color1 = Color.FromArgb(50, 174, 163);
            btnEditProfile.StateTracking.Border.Color2 = Color.FromArgb(50, 174, 163);
            btnEditProfile.StateTracking.Content.LongText.Color1 = Color.White;
            btnEditProfile.StateTracking.Content.LongText.Color2 = Color.White;
            btnEditProfile.StateTracking.Content.ShortText.Color1 = Color.White;
            btnEditProfile.StateTracking.Content.ShortText.Color2 = Color.White;
            btnEditProfile.TabIndex = 1;
            btnEditProfile.Values.DropDownArrowColor = Color.Empty;
            btnEditProfile.Values.ExtraText = "Edit";
            btnEditProfile.Values.Text = "";
            btnEditProfile.Click += btnEditProfile_Click;
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
            // UC_Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(239, 240, 241);
            Controls.Add(kryptonLabel1);
            Controls.Add(panelTeacherProfile);
            Controls.Add(btnEditProfile);
            Name = "UC_Teacher";
            Size = new Size(1150, 640);
            ((System.ComponentModel.ISupportInitialize)panelTeacherProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageList1;
        private Krypton.Toolkit.KryptonButton btnEditProfile;
        private Krypton.Toolkit.KryptonPanel panelTeacherProfile;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}
