namespace AE.Application
{
    partial class UC_Attendance
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
            lblSectionName = new Label();
            panelCalendar = new Panel();
            kryptonButton7 = new Krypton.Toolkit.KryptonButton();
            kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            lblDateNow = new Label();
            btnNextDate = new Syncfusion.WinForms.Controls.SfButton();
            btnPreviousDate = new Syncfusion.WinForms.Controls.SfButton();
            lblSubjectName = new Label();
            lblClassRoster = new Label();
            layoutStudents = new FlowLayoutPanel();
            lblNumberofStudents = new Label();
            pnlTotalStudents = new UC_SummaryCard();
            pnlPresent = new UC_SummaryCard();
            pnlAbsent = new UC_SummaryCard();
            pnlLate = new UC_SummaryCard();
            pnlExcused = new UC_SummaryCard();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton8 = new Krypton.Toolkit.KryptonButton();
            panelCalendar.SuspendLayout();
            SuspendLayout();
            // 
            // lblSectionName
            // 
            lblSectionName.AutoSize = true;
            lblSectionName.Font = new Font("Inter", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSectionName.Location = new Point(99, 70);
            lblSectionName.Name = "lblSectionName";
            lblSectionName.Size = new Size(197, 45);
            lblSectionName.TabIndex = 1;
            lblSectionName.Text = "Grade 10-A";
            // 
            // panelCalendar
            // 
            panelCalendar.BackColor = Color.White;
            panelCalendar.Controls.Add(kryptonButton7);
            panelCalendar.Controls.Add(kryptonButton6);
            panelCalendar.Controls.Add(lblDateNow);
            panelCalendar.Controls.Add(btnNextDate);
            panelCalendar.Controls.Add(btnPreviousDate);
            panelCalendar.Location = new Point(109, 157);
            panelCalendar.Name = "panelCalendar";
            panelCalendar.Size = new Size(887, 62);
            panelCalendar.TabIndex = 2;
            // 
            // kryptonButton7
            // 
            kryptonButton7.Location = new Point(741, 16);
            kryptonButton7.Name = "kryptonButton7";
            kryptonButton7.Size = new Size(90, 25);
            kryptonButton7.TabIndex = 26;
            kryptonButton7.Values.DropDownArrowColor = Color.Empty;
            kryptonButton7.Values.Text = "kryptonButton7";
            // 
            // kryptonButton6
            // 
            kryptonButton6.Location = new Point(55, 21);
            kryptonButton6.Name = "kryptonButton6";
            kryptonButton6.Size = new Size(90, 25);
            kryptonButton6.TabIndex = 25;
            kryptonButton6.Values.DropDownArrowColor = Color.Empty;
            kryptonButton6.Values.Text = "kryptonButton6";
            // 
            // lblDateNow
            // 
            lblDateNow.AutoSize = true;
            lblDateNow.Cursor = Cursors.Hand;
            lblDateNow.Font = new Font("Segoe UI", 16F);
            lblDateNow.ForeColor = Color.FromArgb(29, 37, 48);
            lblDateNow.Location = new Point(301, 16);
            lblDateNow.Name = "lblDateNow";
            lblDateNow.Size = new Size(284, 30);
            lblDateNow.TabIndex = 12;
            lblDateNow.Text = "Saturday, February 14, 2026";
            lblDateNow.Click += lblDateNow_Click;
            // 
            // btnNextDate
            // 
            btnNextDate.Font = new Font("Segoe UI Semibold", 12F);
            btnNextDate.Location = new Point(837, 13);
            btnNextDate.Name = "btnNextDate";
            btnNextDate.Size = new Size(36, 36);
            btnNextDate.TabIndex = 13;
            btnNextDate.Text = ">";
            btnNextDate.Click += btnNextDate_Click;
            // 
            // btnPreviousDate
            // 
            btnPreviousDate.Font = new Font("Segoe UI Semibold", 12F);
            btnPreviousDate.Location = new Point(13, 13);
            btnPreviousDate.Name = "btnPreviousDate";
            btnPreviousDate.Size = new Size(36, 36);
            btnPreviousDate.TabIndex = 12;
            btnPreviousDate.Text = "<";
            btnPreviousDate.Click += btnPreviousDate_Click;
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Font = new Font("Inter SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubjectName.ForeColor = Color.FromArgb(108, 124, 137);
            lblSubjectName.Location = new Point(108, 118);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(132, 27);
            lblSubjectName.TabIndex = 4;
            lblSubjectName.Text = "Mathematics";
            // 
            // lblClassRoster
            // 
            lblClassRoster.AutoSize = true;
            lblClassRoster.Font = new Font("Inter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClassRoster.Location = new Point(109, 474);
            lblClassRoster.Name = "lblClassRoster";
            lblClassRoster.Size = new Size(163, 35);
            lblClassRoster.TabIndex = 9;
            lblClassRoster.Text = "Class Roster";
            // 
            // layoutStudents
            // 
            layoutStudents.AutoSize = true;
            layoutStudents.FlowDirection = FlowDirection.TopDown;
            layoutStudents.Location = new Point(109, 517);
            layoutStudents.Name = "layoutStudents";
            layoutStudents.Size = new Size(887, 195);
            layoutStudents.TabIndex = 10;
            // 
            // lblNumberofStudents
            // 
            lblNumberofStudents.AutoSize = true;
            lblNumberofStudents.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumberofStudents.ForeColor = Color.FromArgb(108, 124, 137);
            lblNumberofStudents.Location = new Point(905, 481);
            lblNumberofStudents.Name = "lblNumberofStudents";
            lblNumberofStudents.Size = new Size(94, 23);
            lblNumberofStudents.TabIndex = 14;
            lblNumberofStudents.Text = "3 Students";
            lblNumberofStudents.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlTotalStudents
            // 
            pnlTotalStudents.ForeColor = Color.FromArgb(29, 37, 48);
            pnlTotalStudents.Location = new Point(109, 301);
            pnlTotalStudents.Name = "pnlTotalStudents";
            pnlTotalStudents.Size = new Size(158, 136);
            pnlTotalStudents.TabIndex = 15;
            // 
            // pnlPresent
            // 
            pnlPresent.ForeColor = Color.FromArgb(29, 37, 48);
            pnlPresent.Location = new Point(291, 301);
            pnlPresent.Name = "pnlPresent";
            pnlPresent.Size = new Size(158, 136);
            pnlPresent.TabIndex = 16;
            // 
            // pnlAbsent
            // 
            pnlAbsent.ForeColor = Color.FromArgb(29, 37, 48);
            pnlAbsent.Location = new Point(655, 301);
            pnlAbsent.Name = "pnlAbsent";
            pnlAbsent.Size = new Size(158, 136);
            pnlAbsent.TabIndex = 18;
            // 
            // pnlLate
            // 
            pnlLate.ForeColor = Color.FromArgb(29, 37, 48);
            pnlLate.Location = new Point(473, 301);
            pnlLate.Name = "pnlLate";
            pnlLate.Size = new Size(158, 136);
            pnlLate.TabIndex = 17;
            // 
            // pnlExcused
            // 
            pnlExcused.ForeColor = Color.FromArgb(29, 37, 48);
            pnlExcused.Location = new Point(837, 301);
            pnlExcused.Name = "pnlExcused";
            pnlExcused.Size = new Size(158, 136);
            pnlExcused.TabIndex = 19;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F);
            kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            kryptonCustomPaletteBase1.PalettePaint += kryptonCustomPaletteBase1_PalettePaint;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(103, 23);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton1.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton1.Size = new Size(147, 31);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(249, 250, 251);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(249, 250, 251);
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.FromArgb(108, 124, 137);
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(249, 250, 251);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(249, 250, 251);
            kryptonButton1.StateTracking.Content.ShortText.Color1 = Color.FromArgb(26, 37, 48);
            kryptonButton1.TabIndex = 20;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "< Back to Classes";
            kryptonButton1.Click += lblBackToClass_Click;
            // 
            // btnExportSummary
            // 
            btnExportSummary.Cursor = Cursors.Hand;
            btnExportSummary.Location = new Point(721, 107);
            btnExportSummary.Name = "btnExportSummary";
            btnExportSummary.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnExportSummary.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnExportSummary.Size = new Size(146, 28);
            btnExportSummary.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnExportSummary.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnExportSummary.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnExportSummary.StateCommon.Border.Rounding = 4F;
            btnExportSummary.StateCommon.Content.LongText.Font = new Font("Inter", 9.75F);
            btnExportSummary.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnExportSummary.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 14.25F);
            btnExportSummary.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnExportSummary.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnExportSummary.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnExportSummary.StateTracking.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnExportSummary.StateTracking.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnExportSummary.StateTracking.Content.LongText.Color1 = Color.FromArgb(39, 165, 173);
            btnExportSummary.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 173);
            btnExportSummary.TabIndex = 21;
            btnExportSummary.Values.DropDownArrowColor = Color.Empty;
            btnExportSummary.Values.ExtraText = "Export Summary";
            btnExportSummary.Values.Text = "";
            btnExportSummary.Click += btnExportSummary_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Cursor = Cursors.Hand;
            btnAddStudent.Location = new Point(873, 107);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnAddStudent.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnAddStudent.Size = new Size(123, 28);
            btnAddStudent.StateCommon.Back.Color1 = Color.FromArgb(39, 165, 153);
            btnAddStudent.StateCommon.Back.Color2 = Color.FromArgb(39, 165, 153);
            btnAddStudent.StateCommon.Border.Color1 = Color.FromArgb(39, 165, 153);
            btnAddStudent.StateCommon.Border.Color2 = Color.FromArgb(39, 165, 153);
            btnAddStudent.StateCommon.Border.Rounding = 4F;
            btnAddStudent.StateCommon.Content.LongText.Color1 = Color.White;
            btnAddStudent.StateCommon.Content.LongText.Font = new Font("Inter", 9.75F);
            btnAddStudent.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnAddStudent.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddStudent.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 14.25F);
            btnAddStudent.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnAddStudent.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnAddStudent.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnAddStudent.StateTracking.Border.Color1 = Color.FromArgb(228, 242, 240);
            btnAddStudent.StateTracking.Border.Color2 = Color.FromArgb(228, 242, 240);
            btnAddStudent.TabIndex = 22;
            btnAddStudent.Values.DropDownArrowColor = Color.Empty;
            btnAddStudent.Values.ExtraText = "Add Student";
            btnAddStudent.Values.Text = "";
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnMarkAllPresent
            // 
            btnMarkAllPresent.Cursor = Cursors.Hand;
            btnMarkAllPresent.Location = new Point(109, 248);
            btnMarkAllPresent.Name = "btnMarkAllPresent";
            btnMarkAllPresent.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnMarkAllPresent.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnMarkAllPresent.Size = new Size(145, 31);
            btnMarkAllPresent.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnMarkAllPresent.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnMarkAllPresent.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnMarkAllPresent.StateCommon.Border.Rounding = 6F;
            btnMarkAllPresent.StateCommon.Border.Width = 1;
            btnMarkAllPresent.StateCommon.Content.LongText.Font = new Font("Inter", 9.75F);
            btnMarkAllPresent.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnMarkAllPresent.StateCommon.Content.ShortText.Color1 = Color.FromArgb(26, 37, 48);
            btnMarkAllPresent.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 14.25F);
            btnMarkAllPresent.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnMarkAllPresent.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnMarkAllPresent.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnMarkAllPresent.StateTracking.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnMarkAllPresent.StateTracking.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnMarkAllPresent.StateTracking.Content.LongText.Color1 = Color.FromArgb(39, 165, 173);
            btnMarkAllPresent.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 173);
            btnMarkAllPresent.TabIndex = 23;
            btnMarkAllPresent.Values.DropDownArrowColor = Color.Empty;
            btnMarkAllPresent.Values.ExtraText = "Mark All Present";
            btnMarkAllPresent.Values.Text = "";
            btnMarkAllPresent.Click += btnMarkAllPresent_Click;
            // 
            // btnReset
            // 
            btnReset.Cursor = Cursors.Hand;
            btnReset.Location = new Point(273, 248);
            btnReset.Name = "btnReset";
            btnReset.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnReset.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnReset.Size = new Size(121, 31);
            btnReset.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnReset.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnReset.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnReset.StateCommon.Border.Rounding = 6F;
            btnReset.StateCommon.Border.Width = 1;
            btnReset.StateCommon.Content.LongText.Font = new Font("Inter", 9.75F);
            btnReset.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnReset.StateCommon.Content.ShortText.Color1 = Color.FromArgb(26, 37, 48);
            btnReset.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 14.25F);
            btnReset.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnReset.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnReset.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnReset.StateTracking.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnReset.StateTracking.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnReset.StateTracking.Content.LongText.Color1 = Color.FromArgb(39, 165, 173);
            btnReset.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 173);
            btnReset.TabIndex = 24;
            btnReset.Values.DropDownArrowColor = Color.Empty;
            btnReset.Values.ExtraText = "Reset Day";
            btnReset.Values.Text = "";
            btnReset.Click += this.btnReset_Click;
            // 
            // kryptonButton8
            // 
            kryptonButton8.Location = new Point(530, 206);
            kryptonButton8.Name = "kryptonButton8";
            kryptonButton8.Size = new Size(90, 25);
            kryptonButton8.TabIndex = 25;
            kryptonButton8.Values.DropDownArrowColor = Color.Empty;
            kryptonButton8.Values.Text = "kryptonButton8";
            // 
            // UC_Attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(249, 250, 251);
            Controls.Add(kryptonButton8);
            Controls.Add(kryptonButton1);
            Controls.Add(pnlExcused);
            Controls.Add(pnlAbsent);
            Controls.Add(pnlLate);
            Controls.Add(pnlPresent);
            Controls.Add(pnlTotalStudents);
            Controls.Add(lblNumberofStudents);
            Controls.Add(btnReset);
            Controls.Add(btnMarkAllPresent);
            Controls.Add(layoutStudents);
            Controls.Add(lblClassRoster);
            Controls.Add(btnAddStudent);
            Controls.Add(btnExportSummary);
            Controls.Add(lblSubjectName);
            Controls.Add(panelCalendar);
            Controls.Add(lblSectionName);
            Name = "UC_Attendance";
            Size = new Size(1150, 713);
            Load += UC_Attendance_Load;
            panelCalendar.ResumeLayout(false);
            panelCalendar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSectionName;
        private Panel panelCalendar;
        private Label lblSubjectName;
        private Syncfusion.WinForms.Controls.SfButton btnExportSummary;
        private Syncfusion.WinForms.Controls.SfButton btnAddStudent;
        private Label lblClassRoster;
        private FlowLayoutPanel layoutStudents;
        private Syncfusion.WinForms.Controls.SfButton btnPreviousDate;
        private Label lblDateNow;
        private Syncfusion.WinForms.Controls.SfButton btnNextDate;
        private Syncfusion.WinForms.Controls.SfButton btnMarkAllPresent;
        private Syncfusion.WinForms.Controls.SfButton btnReset;
        private Label lblNumberofStudents;
        private UC_SummaryCard pnlTotalStudents;
        private UC_SummaryCard pnlPresent;
        private UC_SummaryCard pnlAbsent;
        private UC_SummaryCard pnlLate;
        private UC_SummaryCard pnlExcused;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonButton kryptonButton8;
        private Krypton.Toolkit.KryptonButton kryptonButton7;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonButton btnReset;
    }
}
