namespace Brevi.Application
{
    partial class UCSectionCard
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
            lblSectionName = new Krypton.Toolkit.KryptonLabel();
            btnTakeAttendance = new Krypton.Toolkit.KryptonButton();
            btnDeleteSection = new Krypton.Toolkit.KryptonButton();
            lblSubjectName = new Krypton.Toolkit.KryptonLabel();
            lblNumOfStudents = new Krypton.Toolkit.KryptonLabel();
            lblTime = new Krypton.Toolkit.KryptonLabel();
            SuspendLayout();
            // 
            // lblSectionName
            // 
            lblSectionName.AutoSize = false;
            lblSectionName.Location = new Point(20, 25);
            lblSectionName.Name = "lblSectionName";
            lblSectionName.Size = new Size(271, 32);
            lblSectionName.StateCommon.Padding = new Padding(0, -1, -1, -1);
            lblSectionName.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            lblSectionName.StateCommon.ShortText.Font = new Font("Inter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionName.TabIndex = 0;
            lblSectionName.Values.Text = "Grade 10-A";
            lblSectionName.MouseEnter += Card_MouseEnter;
            lblSectionName.MouseLeave += Card_MouseLeave;
            // 
            // btnTakeAttendance
            // 
            btnTakeAttendance.Location = new Point(181, 140);
            btnTakeAttendance.Name = "btnTakeAttendance";
            btnTakeAttendance.OverrideDefault.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnTakeAttendance.OverrideDefault.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnTakeAttendance.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnTakeAttendance.OverrideDefault.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnTakeAttendance.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnTakeAttendance.OverrideDefault.Border.Rounding = 4F;
            btnTakeAttendance.OverrideFocus.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnTakeAttendance.OverrideFocus.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnTakeAttendance.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnTakeAttendance.OverrideFocus.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnTakeAttendance.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnTakeAttendance.OverrideFocus.Border.Rounding = 4F;
            btnTakeAttendance.Size = new Size(148, 34);
            btnTakeAttendance.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnTakeAttendance.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnTakeAttendance.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnTakeAttendance.StateCommon.Border.Rounding = 4F;
            btnTakeAttendance.StateCommon.Content.LongText.Color1 = Color.FromArgb(26, 37, 48);
            btnTakeAttendance.StateCommon.Content.LongText.Font = new Font("Material Symbols Outlined SemiB", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTakeAttendance.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnTakeAttendance.StateCommon.Content.Padding = new Padding(-1, -1, 3, -1);
            btnTakeAttendance.StateCommon.Content.ShortText.Color1 = Color.FromArgb(26, 37, 48);
            btnTakeAttendance.StateCommon.Content.ShortText.Font = new Font("Inter SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTakeAttendance.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnTakeAttendance.StateTracking.Back.Color1 = Color.FromArgb(229, 242, 240);
            btnTakeAttendance.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnTakeAttendance.StateTracking.Content.LongText.Color1 = Color.FromArgb(39, 165, 173);
            btnTakeAttendance.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 173);
            btnTakeAttendance.TabIndex = 1;
            btnTakeAttendance.Values.DropDownArrowColor = Color.Empty;
            btnTakeAttendance.Values.ExtraText = "";
            btnTakeAttendance.Values.Text = "Take Attendance";
            btnTakeAttendance.Click += btnTakeAttendance_Click_1;
            btnTakeAttendance.MouseEnter += Card_MouseEnter;
            btnTakeAttendance.MouseLeave += Card_MouseLeave;
            // 
            // btnDeleteSection
            // 
            btnDeleteSection.Location = new Point(297, 25);
            btnDeleteSection.Name = "btnDeleteSection";
            btnDeleteSection.Size = new Size(32, 32);
            btnDeleteSection.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnDeleteSection.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnDeleteSection.StateCommon.Border.Color1 = Color.FromArgb(249, 250, 251);
            btnDeleteSection.StateCommon.Border.Rounding = 4F;
            btnDeleteSection.StateCommon.Content.ShortText.Color1 = Color.FromArgb(26, 37, 48);
            btnDeleteSection.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteSection.StateTracking.Back.Color1 = Color.FromArgb(236, 249, 247);
            btnDeleteSection.StateTracking.Back.Color2 = Color.FromArgb(236, 249, 247);
            btnDeleteSection.StateTracking.Border.Color1 = Color.FromArgb(236, 249, 247);
            btnDeleteSection.StateTracking.Border.Color2 = Color.FromArgb(236, 249, 247);
            btnDeleteSection.StateTracking.Border.Rounding = 4F;
            btnDeleteSection.StateTracking.Content.ShortText.Color1 = Color.FromArgb(223, 58, 58);
            btnDeleteSection.TabIndex = 2;
            btnDeleteSection.Values.DropDownArrowColor = Color.Empty;
            btnDeleteSection.Values.Text = "";
            btnDeleteSection.Click += btnDeleteSection_Click;
            btnDeleteSection.MouseEnter += Card_MouseEnter;
            btnDeleteSection.MouseLeave += Card_MouseLeave;
            // 
            // lblSubjectName
            // 
            lblSubjectName.Location = new Point(20, 54);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(138, 37);
            lblSubjectName.StateCommon.ShortText.Color1 = Color.FromArgb(108, 124, 137);
            lblSubjectName.StateCommon.ShortText.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubjectName.TabIndex = 3;
            lblSubjectName.Values.Text = "Mathematics";
            lblSubjectName.MouseEnter += Card_MouseEnter;
            lblSubjectName.MouseLeave += Card_MouseLeave;
            // 
            // lblNumOfStudents
            // 
            lblNumOfStudents.Location = new Point(20, 140);
            lblNumOfStudents.Name = "lblNumOfStudents";
            lblNumOfStudents.Size = new Size(130, 34);
            lblNumOfStudents.StateCommon.LongText.Color1 = Color.FromArgb(108, 124, 137);
            lblNumOfStudents.StateCommon.LongText.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumOfStudents.StateCommon.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            lblNumOfStudents.StateCommon.ShortText.Color1 = Color.FromArgb(108, 124, 137);
            lblNumOfStudents.StateCommon.ShortText.Font = new Font("Material Symbols Outlined", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumOfStudents.TabIndex = 4;
            lblNumOfStudents.Values.ExtraText = "0 Students";
            lblNumOfStudents.Values.Text = "";
            lblNumOfStudents.MouseEnter += Card_MouseEnter;
            lblNumOfStudents.MouseLeave += Card_MouseLeave;
            // 
            // lblTime
            // 
            lblTime.Location = new Point(20, 97);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(188, 28);
            lblTime.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            lblTime.StateCommon.ShortText.Font = new Font("Inter", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTime.TabIndex = 5;
            lblTime.Values.Text = "8:00AM - 10:00AM";
            lblTime.MouseEnter += Card_MouseEnter;
            lblTime.MouseLeave += Card_MouseLeave;
            // 
            // UCSectionCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblTime);
            Controls.Add(lblNumOfStudents);
            Controls.Add(lblSubjectName);
            Controls.Add(btnDeleteSection);
            Controls.Add(btnTakeAttendance);
            Controls.Add(lblSectionName);
            Margin = new Padding(3, 10, 3, 10);
            Name = "UCSectionCard";
            Size = new Size(344, 190);
            MouseEnter += Card_MouseEnter;
            MouseLeave += Card_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblSectionName;
        private Krypton.Toolkit.KryptonButton btnTakeAttendance;
        private Krypton.Toolkit.KryptonButton btnDeleteSection;
        private Krypton.Toolkit.KryptonLabel lblSubjectName;
        private Krypton.Toolkit.KryptonLabel lblNumOfStudents;
        private Krypton.Toolkit.KryptonLabel lblTime;
    }
}
