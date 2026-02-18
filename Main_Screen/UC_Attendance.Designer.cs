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
            lblSectionName = new Label();
            panel1 = new Panel();
            lblDateNow = new Label();
            btnNextDate = new Syncfusion.WinForms.Controls.SfButton();
            btnPreviousDate = new Syncfusion.WinForms.Controls.SfButton();
            lblSubjectName = new Label();
            btnExport = new Syncfusion.WinForms.Controls.SfButton();
            btnAddStudent = new Syncfusion.WinForms.Controls.SfButton();
            lblClassRoster = new Label();
            layoutStudents = new FlowLayoutPanel();
            lblBackToClass = new Label();
            btnMarkAllPresent = new Syncfusion.WinForms.Controls.SfButton();
            btnReset = new Syncfusion.WinForms.Controls.SfButton();
            lblNumberofStudents = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSectionName
            // 
            lblSectionName.AutoSize = true;
            lblSectionName.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblSectionName.Location = new Point(109, 104);
            lblSectionName.Name = "lblSectionName";
            lblSectionName.Size = new Size(225, 51);
            lblSectionName.TabIndex = 1;
            lblSectionName.Text = "Grade 10-A";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblDateNow);
            panel1.Controls.Add(btnNextDate);
            panel1.Controls.Add(btnPreviousDate);
            panel1.Location = new Point(109, 193);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 62);
            panel1.TabIndex = 2;
            // 
            // lblDateNow
            // 
            lblDateNow.AutoSize = true;
            lblDateNow.Font = new Font("Segoe UI", 16F);
            lblDateNow.Location = new Point(301, 16);
            lblDateNow.Name = "lblDateNow";
            lblDateNow.Size = new Size(284, 30);
            lblDateNow.TabIndex = 12;
            lblDateNow.Text = "Saturday, February 14, 2026";
            // 
            // btnNextDate
            // 
            btnNextDate.Font = new Font("Segoe UI Semibold", 12F);
            btnNextDate.Location = new Point(837, 13);
            btnNextDate.Name = "btnNextDate";
            btnNextDate.Size = new Size(36, 36);
            btnNextDate.TabIndex = 13;
            btnNextDate.Text = ">";
            // 
            // btnPreviousDate
            // 
            btnPreviousDate.Font = new Font("Segoe UI Semibold", 12F);
            btnPreviousDate.Location = new Point(13, 13);
            btnPreviousDate.Name = "btnPreviousDate";
            btnPreviousDate.Size = new Size(36, 36);
            btnPreviousDate.TabIndex = 12;
            btnPreviousDate.Text = "<";
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Font = new Font("Segoe UI", 16F);
            lblSubjectName.Location = new Point(116, 158);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(136, 30);
            lblSubjectName.TabIndex = 4;
            lblSubjectName.Text = "Mathematics";
            // 
            // btnExport
            // 
            btnExport.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnExport.Location = new Point(727, 143);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(121, 28);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export Summary";
            // 
            // btnAddStudent
            // 
            btnAddStudent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddStudent.Location = new Point(883, 143);
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
            lblClassRoster.Location = new Point(109, 402);
            lblClassRoster.Name = "lblClassRoster";
            lblClassRoster.Size = new Size(137, 30);
            lblClassRoster.TabIndex = 9;
            lblClassRoster.Text = "Class Roster";
            // 
            // layoutStudents
            // 
            layoutStudents.AutoSize = true;
            layoutStudents.FlowDirection = FlowDirection.TopDown;
            layoutStudents.Location = new Point(109, 445);
            layoutStudents.Name = "layoutStudents";
            layoutStudents.Size = new Size(887, 195);
            layoutStudents.TabIndex = 10;
            // 
            // lblBackToClass
            // 
            lblBackToClass.AutoSize = true;
            lblBackToClass.Cursor = Cursors.Hand;
            lblBackToClass.Font = new Font("Segoe UI", 12F);
            lblBackToClass.Location = new Point(109, 58);
            lblBackToClass.Name = "lblBackToClass";
            lblBackToClass.Size = new Size(115, 21);
            lblBackToClass.TabIndex = 11;
            lblBackToClass.Text = "< Back to Class";
            // 
            // btnMarkAllPresent
            // 
            btnMarkAllPresent.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnMarkAllPresent.Location = new Point(109, 284);
            btnMarkAllPresent.Name = "btnMarkAllPresent";
            btnMarkAllPresent.Size = new Size(121, 28);
            btnMarkAllPresent.TabIndex = 12;
            btnMarkAllPresent.Text = "Mark All Present";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnReset.Location = new Point(256, 284);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(121, 28);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset Day";
            // 
            // lblNumberofStudents
            // 
            lblNumberofStudents.AutoSize = true;
            lblNumberofStudents.Font = new Font("Segoe UI", 12F);
            lblNumberofStudents.Location = new Point(913, 411);
            lblNumberofStudents.Name = "lblNumberofStudents";
            lblNumberofStudents.Size = new Size(83, 21);
            lblNumberofStudents.TabIndex = 14;
            lblNumberofStudents.Text = "3 Students";
            lblNumberofStudents.TextAlign = ContentAlignment.MiddleRight;
            lblNumberofStudents.Click += label2_Click;
            // 
            // UC_Attendance
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(lblNumberofStudents);
            Controls.Add(btnReset);
            Controls.Add(btnMarkAllPresent);
            Controls.Add(lblBackToClass);
            Controls.Add(layoutStudents);
            Controls.Add(lblClassRoster);
            Controls.Add(btnAddStudent);
            Controls.Add(btnExport);
            Controls.Add(lblSubjectName);
            Controls.Add(panel1);
            Controls.Add(lblSectionName);
            Name = "UC_Attendance";
            Size = new Size(1150, 640);
            Load += UC_Attendance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSectionName;
        private Panel panel1;
        private Label lblSubjectName;
        private Syncfusion.WinForms.Controls.SfButton btnExport;
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
    }
}
