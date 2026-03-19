namespace AE.Application
{
    partial class UCAttendance
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
            lblDateNow = new Krypton.Toolkit.KryptonButton();
            btnNextDate = new Krypton.Toolkit.KryptonButton();
            btnPreviousDate = new Krypton.Toolkit.KryptonButton();
            lblSubjectName = new Label();
            lblClassRoster = new Label();
            layoutStudents = new FlowLayoutPanel();
            lblNumberofStudents = new Label();
            pnlTotalStudents = new UCSummaryCard();
            pnlPresent = new UCSummaryCard();
            pnlAbsent = new UCSummaryCard();
            pnlLate = new UCSummaryCard();
            pnlExcused = new UCSummaryCard();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            btnBackToClass = new Krypton.Toolkit.KryptonButton();
            btnExportSummary = new Krypton.Toolkit.KryptonButton();
            btnAddStudent = new Krypton.Toolkit.KryptonButton();
            btnMarkAllPresent = new Krypton.Toolkit.KryptonButton();
            btnReset = new Krypton.Toolkit.KryptonButton();
            panelCalendarBorder = new Panel();
            panelTotalBorder = new Panel();
            panelPresentBorder = new Panel();
            panelLateBorder = new Panel();
            panelAbsentBorder = new Panel();
            panelExcusedBorder = new Panel();
            btnSortSurname = new Krypton.Toolkit.KryptonButton();
            toolTip1 = new ToolTip(components);
            btnSortFirstname = new Krypton.Toolkit.KryptonButton();
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
            panelCalendar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCalendar.BackColor = Color.White;
            panelCalendar.Controls.Add(lblDateNow);
            panelCalendar.Controls.Add(btnNextDate);
            panelCalendar.Controls.Add(btnPreviousDate);
            panelCalendar.ForeColor = SystemColors.ActiveCaptionText;
            panelCalendar.Location = new Point(109, 157);
            panelCalendar.Name = "panelCalendar";
            panelCalendar.Size = new Size(887, 62);
            panelCalendar.TabIndex = 2;
            // 
            // lblDateNow
            // 
            lblDateNow.Location = new Point(272, 10);
            lblDateNow.Name = "lblDateNow";
            lblDateNow.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            lblDateNow.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.False;
            lblDateNow.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            lblDateNow.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            lblDateNow.Size = new Size(343, 43);
            lblDateNow.StateCommon.Back.Color1 = Color.White;
            lblDateNow.StateCommon.Back.Color2 = Color.White;
            lblDateNow.StateCommon.Border.Color1 = Color.White;
            lblDateNow.StateCommon.Border.Color2 = Color.White;
            lblDateNow.StateCommon.Content.LongText.Color1 = Color.FromArgb(26, 37, 48);
            lblDateNow.StateCommon.Content.LongText.Font = new Font("Inter", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateNow.StateCommon.Content.ShortText.Color1 = Color.FromArgb(39, 165, 153);
            lblDateNow.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateNow.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            lblDateNow.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            lblDateNow.StateTracking.Border.Color1 = Color.FromArgb(228, 242, 240);
            lblDateNow.StateTracking.Border.Color2 = Color.FromArgb(228, 242, 240);
            lblDateNow.StateTracking.Border.Rounding = 4F;
            lblDateNow.StateTracking.Border.Width = 1;
            lblDateNow.TabIndex = 4;
            lblDateNow.Values.DropDownArrowColor = Color.Empty;
            lblDateNow.Values.ExtraText = "Saturday, February 14, 2026";
            lblDateNow.Values.Text = "";
            lblDateNow.Click += lblDateNow_Click;
            // 
            // btnNextDate
            // 
            btnNextDate.Location = new Point(836, 13);
            btnNextDate.Name = "btnNextDate";
            btnNextDate.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnNextDate.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnNextDate.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnNextDate.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnNextDate.Size = new Size(36, 36);
            btnNextDate.StateCommon.Back.Color1 = Color.White;
            btnNextDate.StateCommon.Back.Color2 = Color.White;
            btnNextDate.StateCommon.Border.Color1 = Color.White;
            btnNextDate.StateCommon.Border.Color2 = Color.White;
            btnNextDate.StateCommon.Content.ShortText.Color1 = Color.FromArgb(26, 37, 48);
            btnNextDate.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNextDate.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnNextDate.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnNextDate.StateTracking.Border.Color1 = Color.FromArgb(228, 242, 240);
            btnNextDate.StateTracking.Border.Color2 = Color.FromArgb(228, 242, 240);
            btnNextDate.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 173);
            btnNextDate.TabIndex = 5;
            btnNextDate.Values.DropDownArrowColor = Color.Empty;
            btnNextDate.Values.Text = "";
            btnNextDate.Click += btnNextDate_Click;
            // 
            // btnPreviousDate
            // 
            btnPreviousDate.Location = new Point(13, 13);
            btnPreviousDate.Name = "btnPreviousDate";
            btnPreviousDate.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnPreviousDate.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnPreviousDate.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnPreviousDate.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnPreviousDate.Size = new Size(36, 36);
            btnPreviousDate.StateCommon.Back.Color1 = Color.White;
            btnPreviousDate.StateCommon.Back.Color2 = Color.White;
            btnPreviousDate.StateCommon.Border.Color1 = Color.White;
            btnPreviousDate.StateCommon.Border.Color2 = Color.White;
            btnPreviousDate.StateCommon.Content.ShortText.Color1 = Color.FromArgb(26, 37, 48);
            btnPreviousDate.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPreviousDate.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnPreviousDate.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnPreviousDate.StateTracking.Border.Color1 = Color.FromArgb(228, 242, 240);
            btnPreviousDate.StateTracking.Border.Color2 = Color.FromArgb(228, 242, 240);
            btnPreviousDate.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 173);
            btnPreviousDate.TabIndex = 6;
            btnPreviousDate.Values.DropDownArrowColor = Color.Empty;
            btnPreviousDate.Values.Text = "";
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
            layoutStudents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            layoutStudents.AutoSize = true;
            layoutStudents.FlowDirection = FlowDirection.TopDown;
            layoutStudents.ForeColor = SystemColors.ActiveCaption;
            layoutStudents.Location = new Point(109, 517);
            layoutStudents.Margin = new Padding(3, 3, 3, 20);
            layoutStudents.Name = "layoutStudents";
            layoutStudents.Size = new Size(887, 195);
            layoutStudents.TabIndex = 10;
            // 
            // lblNumberofStudents
            // 
            lblNumberofStudents.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            pnlTotalStudents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlTotalStudents.BackColor = Color.FromArgb(228, 242, 240);
            pnlTotalStudents.ForeColor = Color.FromArgb(29, 37, 48);
            pnlTotalStudents.Location = new Point(109, 313);
            pnlTotalStudents.Name = "pnlTotalStudents";
            pnlTotalStudents.Size = new Size(158, 120);
            pnlTotalStudents.TabIndex = 15;
            // 
            // pnlPresent
            // 
            pnlPresent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPresent.BackColor = Color.FromArgb(227, 245, 234);
            pnlPresent.ForeColor = Color.FromArgb(29, 37, 48);
            pnlPresent.Location = new Point(291, 313);
            pnlPresent.Name = "pnlPresent";
            pnlPresent.Size = new Size(158, 120);
            pnlPresent.TabIndex = 16;
            // 
            // pnlAbsent
            // 
            pnlAbsent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlAbsent.BackColor = Color.FromArgb(246, 231, 231);
            pnlAbsent.ForeColor = Color.FromArgb(29, 37, 48);
            pnlAbsent.Location = new Point(837, 313);
            pnlAbsent.Name = "pnlAbsent";
            pnlAbsent.Size = new Size(158, 120);
            pnlAbsent.TabIndex = 18;
            // 
            // pnlLate
            // 
            pnlLate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlLate.BackColor = Color.FromArgb(248, 241, 226);
            pnlLate.ForeColor = Color.FromArgb(29, 37, 48);
            pnlLate.Location = new Point(473, 313);
            pnlLate.Name = "pnlLate";
            pnlLate.Size = new Size(158, 120);
            pnlLate.TabIndex = 17;
            // 
            // pnlExcused
            // 
            pnlExcused.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlExcused.BackColor = Color.FromArgb(225, 241, 248);
            pnlExcused.ForeColor = Color.FromArgb(29, 37, 48);
            pnlExcused.Location = new Point(655, 313);
            pnlExcused.Name = "pnlExcused";
            pnlExcused.Size = new Size(158, 120);
            pnlExcused.TabIndex = 19;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8.25F);
            kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // btnBackToClass
            // 
            btnBackToClass.Location = new Point(102, 22);
            btnBackToClass.Name = "btnBackToClass";
            btnBackToClass.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnBackToClass.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnBackToClass.Size = new Size(169, 31);
            btnBackToClass.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnBackToClass.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnBackToClass.StateCommon.Border.Color1 = Color.FromArgb(249, 250, 251);
            btnBackToClass.StateCommon.Border.Color2 = Color.FromArgb(249, 250, 251);
            btnBackToClass.StateCommon.Content.LongText.Color1 = Color.FromArgb(108, 124, 137);
            btnBackToClass.StateCommon.Content.LongText.Font = new Font("Inter SemiBold", 11.25F, FontStyle.Bold);
            btnBackToClass.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnBackToClass.StateCommon.Content.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            btnBackToClass.StateCommon.Content.ShortText.Color1 = Color.FromArgb(108, 124, 137);
            btnBackToClass.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBackToClass.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnBackToClass.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            btnBackToClass.StateTracking.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnBackToClass.StateTracking.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnBackToClass.StateTracking.Content.LongText.Color1 = Color.FromArgb(26, 37, 48);
            btnBackToClass.StateTracking.Content.ShortText.Color1 = Color.FromArgb(26, 37, 48);
            btnBackToClass.TabIndex = 9;
            btnBackToClass.Values.DropDownArrowColor = Color.Empty;
            btnBackToClass.Values.ExtraText = "Back to Classes";
            btnBackToClass.Values.Text = "";
            btnBackToClass.Click += lblBackToClass_Click;
            // 
            // btnExportSummary
            // 
            btnExportSummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportSummary.Cursor = Cursors.Hand;
            btnExportSummary.Location = new Point(721, 107);
            btnExportSummary.Name = "btnExportSummary";
            btnExportSummary.OverrideDefault.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnExportSummary.OverrideDefault.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnExportSummary.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnExportSummary.OverrideDefault.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnExportSummary.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnExportSummary.OverrideDefault.Border.Rounding = 6F;
            btnExportSummary.OverrideDefault.Border.Width = 1;
            btnExportSummary.OverrideFocus.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnExportSummary.OverrideFocus.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnExportSummary.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnExportSummary.OverrideFocus.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnExportSummary.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnExportSummary.OverrideFocus.Border.Rounding = 6F;
            btnExportSummary.OverrideFocus.Border.Width = 1;
            btnExportSummary.Size = new Size(146, 28);
            btnExportSummary.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnExportSummary.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnExportSummary.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnExportSummary.StateCommon.Border.Rounding = 6F;
            btnExportSummary.StateCommon.Border.Width = 1;
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
            btnExportSummary.TabIndex = 3;
            btnExportSummary.Values.DropDownArrowColor = Color.Empty;
            btnExportSummary.Values.ExtraText = "Export Summary";
            btnExportSummary.Values.Text = "";
            btnExportSummary.Click += btnExportSummary_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddStudent.Cursor = Cursors.Hand;
            btnAddStudent.Location = new Point(873, 107);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.OverrideDefault.Back.Color1 = Color.FromArgb(39, 165, 153);
            btnAddStudent.OverrideDefault.Back.Color2 = Color.FromArgb(39, 165, 153);
            btnAddStudent.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnAddStudent.OverrideDefault.Border.Color1 = Color.FromArgb(39, 165, 153);
            btnAddStudent.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnAddStudent.OverrideDefault.Border.Rounding = 6F;
            btnAddStudent.OverrideDefault.Border.Width = 1;
            btnAddStudent.OverrideFocus.Back.Color1 = Color.FromArgb(39, 165, 153);
            btnAddStudent.OverrideFocus.Back.Color2 = Color.FromArgb(39, 165, 153);
            btnAddStudent.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnAddStudent.OverrideFocus.Border.Color1 = Color.FromArgb(39, 165, 153);
            btnAddStudent.OverrideFocus.Border.Color2 = Color.FromArgb(39, 165, 153);
            btnAddStudent.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnAddStudent.OverrideFocus.Border.Rounding = 6F;
            btnAddStudent.OverrideFocus.Border.Width = 1;
            btnAddStudent.Size = new Size(123, 28);
            btnAddStudent.StateCommon.Back.Color1 = Color.FromArgb(39, 165, 153);
            btnAddStudent.StateCommon.Back.Color2 = Color.FromArgb(39, 165, 153);
            btnAddStudent.StateCommon.Border.Color1 = Color.FromArgb(39, 165, 153);
            btnAddStudent.StateCommon.Border.Color2 = Color.FromArgb(39, 165, 153);
            btnAddStudent.StateCommon.Border.Rounding = 6F;
            btnAddStudent.StateCommon.Border.Width = 1;
            btnAddStudent.StateCommon.Content.LongText.Color1 = Color.White;
            btnAddStudent.StateCommon.Content.LongText.Font = new Font("Inter", 9.75F);
            btnAddStudent.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnAddStudent.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAddStudent.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 14.25F);
            btnAddStudent.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnAddStudent.StateTracking.Back.Color1 = Color.FromArgb(77, 180, 170);
            btnAddStudent.StateTracking.Back.Color2 = Color.FromArgb(77, 180, 170);
            btnAddStudent.StateTracking.Border.Color1 = Color.FromArgb(77, 180, 170);
            btnAddStudent.StateTracking.Border.Color2 = Color.FromArgb(77, 180, 170);
            btnAddStudent.TabIndex = 0;
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
            btnMarkAllPresent.OverrideDefault.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnMarkAllPresent.OverrideDefault.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnMarkAllPresent.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnMarkAllPresent.OverrideDefault.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnMarkAllPresent.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnMarkAllPresent.OverrideDefault.Border.Rounding = 6F;
            btnMarkAllPresent.OverrideDefault.Border.Width = 1;
            btnMarkAllPresent.OverrideFocus.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnMarkAllPresent.OverrideFocus.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnMarkAllPresent.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnMarkAllPresent.OverrideFocus.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnMarkAllPresent.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnMarkAllPresent.OverrideFocus.Border.Rounding = 6F;
            btnMarkAllPresent.OverrideFocus.Border.Width = 1;
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
            btnMarkAllPresent.TabIndex = 1;
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
            btnReset.OverrideDefault.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnReset.OverrideDefault.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnReset.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnReset.OverrideDefault.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnReset.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnReset.OverrideDefault.Border.Rounding = 6F;
            btnReset.OverrideDefault.Border.Width = 1;
            btnReset.OverrideFocus.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnReset.OverrideFocus.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnReset.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnReset.OverrideFocus.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnReset.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnReset.OverrideFocus.Border.Rounding = 6F;
            btnReset.OverrideFocus.Border.Width = 1;
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
            btnReset.TabIndex = 2;
            btnReset.Values.DropDownArrowColor = Color.Empty;
            btnReset.Values.ExtraText = "Reset Day";
            btnReset.Values.Text = "";
            btnReset.Click += btnReset_Click;
            // 
            // panelCalendarBorder
            // 
            panelCalendarBorder.BackColor = Color.FromArgb(224, 230, 235);
            panelCalendarBorder.Location = new Point(107, 155);
            panelCalendarBorder.Name = "panelCalendarBorder";
            panelCalendarBorder.Size = new Size(891, 66);
            panelCalendarBorder.TabIndex = 25;
            // 
            // panelTotalBorder
            // 
            panelTotalBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelTotalBorder.BackColor = Color.FromArgb(190, 226, 223);
            panelTotalBorder.Location = new Point(107, 311);
            panelTotalBorder.Name = "panelTotalBorder";
            panelTotalBorder.Size = new Size(162, 124);
            panelTotalBorder.TabIndex = 26;
            // 
            // panelPresentBorder
            // 
            panelPresentBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelPresentBorder.BackColor = Color.FromArgb(188, 234, 206);
            panelPresentBorder.Location = new Point(289, 311);
            panelPresentBorder.Name = "panelPresentBorder";
            panelPresentBorder.Size = new Size(162, 124);
            panelPresentBorder.TabIndex = 27;
            // 
            // panelLateBorder
            // 
            panelLateBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelLateBorder.BackColor = Color.FromArgb(247, 224, 183);
            panelLateBorder.Location = new Point(471, 311);
            panelLateBorder.Name = "panelLateBorder";
            panelLateBorder.Size = new Size(162, 124);
            panelLateBorder.TabIndex = 27;
            // 
            // panelAbsentBorder
            // 
            panelAbsentBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelAbsentBorder.BackColor = Color.FromArgb(242, 196, 197);
            panelAbsentBorder.Location = new Point(835, 311);
            panelAbsentBorder.Name = "panelAbsentBorder";
            panelAbsentBorder.Size = new Size(162, 124);
            panelAbsentBorder.TabIndex = 28;
            // 
            // panelExcusedBorder
            // 
            panelExcusedBorder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelExcusedBorder.BackColor = Color.FromArgb(183, 224, 244);
            panelExcusedBorder.Location = new Point(653, 311);
            panelExcusedBorder.Name = "panelExcusedBorder";
            panelExcusedBorder.Size = new Size(162, 124);
            panelExcusedBorder.TabIndex = 29;
            // 
            // btnSortSurname
            // 
            btnSortSurname.AutoSize = true;
            btnSortSurname.Cursor = Cursors.Hand;
            btnSortSurname.Location = new Point(278, 478);
            btnSortSurname.Name = "btnSortSurname";
            btnSortSurname.OverrideDefault.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnSortSurname.OverrideDefault.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnSortSurname.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnSortSurname.OverrideDefault.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnSortSurname.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnSortSurname.OverrideDefault.Border.Rounding = 6F;
            btnSortSurname.OverrideDefault.Border.Width = 1;
            btnSortSurname.OverrideFocus.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnSortSurname.OverrideFocus.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnSortSurname.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnSortSurname.OverrideFocus.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnSortSurname.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnSortSurname.OverrideFocus.Border.Rounding = 6F;
            btnSortSurname.OverrideFocus.Border.Width = 1;
            btnSortSurname.Size = new Size(31, 31);
            btnSortSurname.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnSortSurname.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnSortSurname.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnSortSurname.StateCommon.Border.Rounding = 6F;
            btnSortSurname.StateCommon.Border.Width = 1;
            btnSortSurname.StateCommon.Content.LongText.Font = new Font("Inter", 9.75F);
            btnSortSurname.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnSortSurname.StateCommon.Content.ShortText.Color1 = Color.FromArgb(26, 37, 48);
            btnSortSurname.StateCommon.Content.ShortText.Font = new Font("Inter", 9F);
            btnSortSurname.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnSortSurname.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnSortSurname.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnSortSurname.StateTracking.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnSortSurname.StateTracking.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnSortSurname.StateTracking.Content.LongText.Color1 = Color.FromArgb(39, 165, 173);
            btnSortSurname.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 173);
            btnSortSurname.TabIndex = 7;
            toolTip1.SetToolTip(btnSortSurname, "Sort by Surname");
            btnSortSurname.Values.DropDownArrowColor = Color.Empty;
            btnSortSurname.Values.Text = "AZ";
            btnSortSurname.Click += btnSortSurname_Click;
            // 
            // btnSortFirstname
            // 
            btnSortFirstname.AutoSize = true;
            btnSortFirstname.Cursor = Cursors.Hand;
            btnSortFirstname.Location = new Point(315, 478);
            btnSortFirstname.Name = "btnSortFirstname";
            btnSortFirstname.OverrideDefault.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnSortFirstname.OverrideDefault.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnSortFirstname.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnSortFirstname.OverrideDefault.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnSortFirstname.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnSortFirstname.OverrideDefault.Border.Rounding = 6F;
            btnSortFirstname.OverrideDefault.Border.Width = 1;
            btnSortFirstname.OverrideFocus.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnSortFirstname.OverrideFocus.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnSortFirstname.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnSortFirstname.OverrideFocus.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnSortFirstname.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnSortFirstname.OverrideFocus.Border.Rounding = 6F;
            btnSortFirstname.OverrideFocus.Border.Width = 1;
            btnSortFirstname.Size = new Size(31, 31);
            btnSortFirstname.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnSortFirstname.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnSortFirstname.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnSortFirstname.StateCommon.Border.Rounding = 6F;
            btnSortFirstname.StateCommon.Border.Width = 1;
            btnSortFirstname.StateCommon.Content.LongText.Font = new Font("Inter", 9.75F);
            btnSortFirstname.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnSortFirstname.StateCommon.Content.Padding = new Padding(3, -1, -1, -1);
            btnSortFirstname.StateCommon.Content.ShortText.Color1 = Color.FromArgb(26, 37, 48);
            btnSortFirstname.StateCommon.Content.ShortText.Font = new Font("Inter", 9F);
            btnSortFirstname.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnSortFirstname.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnSortFirstname.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnSortFirstname.StateTracking.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnSortFirstname.StateTracking.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnSortFirstname.StateTracking.Content.LongText.Color1 = Color.FromArgb(39, 165, 173);
            btnSortFirstname.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 173);
            btnSortFirstname.TabIndex = 8;
            toolTip1.SetToolTip(btnSortFirstname, "Sort by First Name");
            btnSortFirstname.Values.DropDownArrowColor = Color.Empty;
            btnSortFirstname.Values.Text = "az";
            btnSortFirstname.Click += btnSortFirstname_Click;
            // 
            // UCAttendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(249, 250, 251);
            Controls.Add(btnSortFirstname);
            Controls.Add(btnSortSurname);
            Controls.Add(btnBackToClass);
            Controls.Add(pnlExcused);
            Controls.Add(panelExcusedBorder);
            Controls.Add(pnlAbsent);
            Controls.Add(panelAbsentBorder);
            Controls.Add(pnlLate);
            Controls.Add(panelLateBorder);
            Controls.Add(pnlPresent);
            Controls.Add(panelPresentBorder);
            Controls.Add(pnlTotalStudents);
            Controls.Add(panelTotalBorder);
            Controls.Add(lblNumberofStudents);
            Controls.Add(btnReset);
            Controls.Add(btnMarkAllPresent);
            Controls.Add(layoutStudents);
            Controls.Add(lblClassRoster);
            Controls.Add(btnAddStudent);
            Controls.Add(btnExportSummary);
            Controls.Add(lblSubjectName);
            Controls.Add(panelCalendar);
            Controls.Add(panelCalendarBorder);
            Controls.Add(lblSectionName);
            Name = "UCAttendance";
            Size = new Size(1150, 761);
            Load += UC_Attendance_Load;
            panelCalendar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSectionName;
        private Panel panelCalendar;
        private Label lblSubjectName;
        private Label lblClassRoster;
        private FlowLayoutPanel layoutStudents;
        private Label lblNumberofStudents;
        private UCSummaryCard pnlTotalStudents;
        private UCSummaryCard pnlPresent;
        private UCSummaryCard pnlAbsent;
        private UCSummaryCard pnlLate;
        private UCSummaryCard pnlExcused;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonButton lblDateNow;
        private Krypton.Toolkit.KryptonButton btnPreviousDate;
        private Krypton.Toolkit.KryptonButton btnBackToClass;
        private Krypton.Toolkit.KryptonButton btnMarkAllPresent;
        private Krypton.Toolkit.KryptonButton btnExportSummary;
        private Krypton.Toolkit.KryptonButton btnAddStudent;
        private Krypton.Toolkit.KryptonButton btnReset;
        private Krypton.Toolkit.KryptonButton btnNextDate;
        private Panel panelCalendarBorder;
        private Panel panelTotalBorder;
        private Panel panelPresentBorder;
        private Panel panelLateBorder;
        private Panel panelAbsentBorder;
        private Panel panelExcusedBorder;
        private Krypton.Toolkit.KryptonButton btnSortSurname;
        private ToolTip toolTip1;
        private Krypton.Toolkit.KryptonButton btnSortFirstname;
    }
}
