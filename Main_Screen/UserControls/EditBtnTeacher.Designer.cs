namespace Brevi.Application.UserControls
{
    partial class EditBtnTeacher
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
            btnEditProfile = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // btnEditProfile
            // 
            btnEditProfile.Location = new Point(112, 3);
            btnEditProfile.Name = "btnEditProfile";
            btnEditProfile.Size = new Size(100, 44);
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
            btnEditProfile.TabIndex = 2;
            btnEditProfile.Values.DropDownArrowColor = Color.Empty;
            btnEditProfile.Values.ExtraText = "Edit";
            btnEditProfile.Values.Text = "";
            btnEditProfile.Click += btnEditProfile_Click;
            // 
            // EditBtnTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnEditProfile);
            Name = "EditBtnTeacher";
            Size = new Size(215, 50);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnEditProfile;
    }
}
