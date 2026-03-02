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
            lblDateNow = new Label();
            btnNextDate = new Syncfusion.WinForms.Controls.SfButton();
            btnPreviousDate = new Syncfusion.WinForms.Controls.SfButton();
            lblSubjectName = new Label();
            btnExportSummary = new Syncfusion.WinForms.Controls.SfButton();
            btnAddStudent = new Syncfusion.WinForms.Controls.SfButton();
            lblClassRoster = new Label();
            layoutStudents = new FlowLayoutPanel();
            lblBackToClass = new Label();
            btnMarkAllPresent = new Syncfusion.WinForms.Controls.SfButton();
            btnReset = new Syncfusion.WinForms.Controls.SfButton();
            lblNumberofStudents = new Label();
            pnlTotalStudents = new UC_SummaryCard();
            pnlPresent = new UC_SummaryCard();
            pnlAbsent = new UC_SummaryCard();
            pnlLate = new UC_SummaryCard();
            pnlExcused = new UC_SummaryCard();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            panelCalendar.SuspendLayout();
            SuspendLayout();
            // 
            // lblSectionName
            // 
            lblSectionName.AutoSize = true;
            lblSectionName.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblSectionName.Location = new Point(109, 68);
            lblSectionName.Name = "lblSectionName";
            lblSectionName.Size = new Size(225, 51);
            lblSectionName.TabIndex = 1;
            lblSectionName.Text = "Grade 10-A";
            // 
            // panelCalendar
            // 
            panelCalendar.Controls.Add(lblDateNow);
            panelCalendar.Controls.Add(btnNextDate);
            panelCalendar.Controls.Add(btnPreviousDate);
            panelCalendar.Location = new Point(109, 157);
            panelCalendar.Name = "panelCalendar";
            panelCalendar.Size = new Size(887, 62);
            panelCalendar.TabIndex = 2;
            // 
            // lblDateNow
            // 
            lblDateNow.AutoSize = true;
            lblDateNow.Cursor = Cursors.Hand;
            lblDateNow.Font = new Font("Segoe UI", 16F);
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
            lblSubjectName.Font = new Font("Segoe UI", 16F);
            lblSubjectName.Location = new Point(116, 122);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(136, 30);
            lblSubjectName.TabIndex = 4;
            lblSubjectName.Text = "Mathematics";
            // 
            // btnExportSummary
            // 
            btnExportSummary.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnExportSummary.Location = new Point(727, 107);
            btnExportSummary.Name = "btnExportSummary";
            btnExportSummary.Size = new Size(121, 28);
            btnExportSummary.TabIndex = 5;
            btnExportSummary.Text = "Export Summary";
            btnExportSummary.Click += btnExportSummary_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddStudent.Location = new Point(883, 107);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(113, 28);
            btnAddStudent.TabIndex = 6;
            btnAddStudent.Text = "+ Add Student";
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // lblClassRoster
            // 
            lblClassRoster.AutoSize = true;
            lblClassRoster.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblClassRoster.Location = new Point(109, 474);
            lblClassRoster.Name = "lblClassRoster";
            lblClassRoster.Size = new Size(137, 30);
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
            // lblBackToClass
            // 
            lblBackToClass.AutoSize = true;
            lblBackToClass.Cursor = Cursors.Hand;
            lblBackToClass.Font = new Font("Segoe UI", 12F);
            lblBackToClass.Location = new Point(109, 22);
            lblBackToClass.Name = "lblBackToClass";
            lblBackToClass.Size = new Size(115, 21);
            lblBackToClass.TabIndex = 11;
            lblBackToClass.Text = "< Back to Class";
            lblBackToClass.Click += lblBackToClass_Click;
            // 
            // btnMarkAllPresent
            // 
            btnMarkAllPresent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnMarkAllPresent.Location = new Point(109, 248);
            btnMarkAllPresent.Name = "btnMarkAllPresent";
            btnMarkAllPresent.Size = new Size(121, 28);
            btnMarkAllPresent.TabIndex = 12;
            btnMarkAllPresent.Text = "Mark All Present";
            btnMarkAllPresent.Click += btnMarkAllPresent_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnReset.Location = new Point(256, 248);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(121, 28);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset Day";
            btnReset.Click += btnReset_Click;
            // 
            // lblNumberofStudents
            // 
            lblNumberofStudents.AutoSize = true;
            lblNumberofStudents.Font = new Font("Segoe UI", 12F);
            lblNumberofStudents.Location = new Point(913, 483);
            lblNumberofStudents.Name = "lblNumberofStudents";
            lblNumberofStudents.Size = new Size(83, 21);
            lblNumberofStudents.TabIndex = 14;
            lblNumberofStudents.Text = "3 Students";
            lblNumberofStudents.TextAlign = ContentAlignment.MiddleRight;
            lblNumberofStudents.Click += label2_Click;
            // 
            // pnlTotalStudents
            // 
            pnlTotalStudents.Location = new Point(109, 301);
            pnlTotalStudents.Name = "pnlTotalStudents";
            pnlTotalStudents.Size = new Size(158, 136);
            pnlTotalStudents.TabIndex = 15;
            // 
            // pnlPresent
            // 
            pnlPresent.Location = new Point(291, 301);
            pnlPresent.Name = "pnlPresent";
            pnlPresent.Size = new Size(158, 136);
            pnlPresent.TabIndex = 16;
            // 
            // pnlAbsent
            // 
            pnlAbsent.Location = new Point(655, 301);
            pnlAbsent.Name = "pnlAbsent";
            pnlAbsent.Size = new Size(158, 136);
            pnlAbsent.TabIndex = 18;
            // 
            // pnlLate
            // 
            pnlLate.Location = new Point(473, 301);
            pnlLate.Name = "pnlLate";
            pnlLate.Size = new Size(158, 136);
            pnlLate.TabIndex = 17;
            // 
            // pnlExcused
            // 
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
            // UC_Attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(pnlExcused);
            Controls.Add(pnlAbsent);
            Controls.Add(pnlLate);
            Controls.Add(pnlPresent);
            Controls.Add(pnlTotalStudents);
            Controls.Add(lblNumberofStudents);
            Controls.Add(btnReset);
            Controls.Add(btnMarkAllPresent);
            Controls.Add(lblBackToClass);
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
        private Label lblBackToClass;
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
    }
}
