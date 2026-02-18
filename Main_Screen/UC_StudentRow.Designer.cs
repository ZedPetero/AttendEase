namespace AE.Application
{
    partial class UC_StudentRow
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
            btnLate = new Syncfusion.WinForms.Controls.SfButton();
            lblNumber = new Label();
            lblStudentName = new Label();
            label3 = new Label();
            btnExcused = new Syncfusion.WinForms.Controls.SfButton();
            btnAbsent = new Syncfusion.WinForms.Controls.SfButton();
            btnDeleteStudent = new Syncfusion.WinForms.Controls.SfButton();
            btnCheck = new Syncfusion.WinForms.Controls.SfButton();
            SuspendLayout();
            // 
            // btnLate
            // 
            btnLate.Font = new Font("Segoe UI Semibold", 9F);
            btnLate.Location = new Point(547, 28);
            btnLate.Name = "btnLate";
            btnLate.Size = new Size(45, 45);
            btnLate.Style.Image = Properties.Resources.right_arrow;
            btnLate.TabIndex = 0;
            // 
            // lblNumber
            // 
            lblNumber.Font = new Font("Segoe UI", 12F);
            lblNumber.Location = new Point(23, 32);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(36, 36);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "01";
            lblNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblStudentName.Location = new Point(85, 24);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(192, 30);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Emma Thompson";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(87, 58);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 3;
            label3.Text = "Not Marked";
            // 
            // btnExcused
            // 
            btnExcused.Font = new Font("Segoe UI Semibold", 9F);
            btnExcused.Location = new Point(602, 28);
            btnExcused.Name = "btnExcused";
            btnExcused.Size = new Size(45, 45);
            btnExcused.Style.Image = Properties.Resources.right_arrow;
            btnExcused.TabIndex = 4;
            // 
            // btnAbsent
            // 
            btnAbsent.Font = new Font("Segoe UI Semibold", 9F);
            btnAbsent.Location = new Point(657, 28);
            btnAbsent.Name = "btnAbsent";
            btnAbsent.Size = new Size(45, 45);
            btnAbsent.Style.Image = Properties.Resources.right_arrow;
            btnAbsent.TabIndex = 5;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Font = new Font("Segoe UI Semibold", 9F);
            btnDeleteStudent.Location = new Point(730, 28);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(45, 45);
            btnDeleteStudent.Style.Image = Properties.Resources.right_arrow;
            btnDeleteStudent.TabIndex = 6;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI Semibold", 9F);
            btnCheck.Location = new Point(492, 28);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(45, 45);
            btnCheck.Style.Image = Properties.Resources.right_arrow;
            btnCheck.TabIndex = 7;
            // 
            // UC_StudentRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCheck);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnAbsent);
            Controls.Add(btnExcused);
            Controls.Add(label3);
            Controls.Add(lblStudentName);
            Controls.Add(lblNumber);
            Controls.Add(btnLate);
            Name = "UC_StudentRow";
            Size = new Size(800, 100);
            Load += UC_StudentRow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton btnLate;
        private Label lblNumber;
        private Label lblStudentName;
        private Label label3;
        private Syncfusion.WinForms.Controls.SfButton btnExcused;
        private Syncfusion.WinForms.Controls.SfButton btnAbsent;
        private Syncfusion.WinForms.Controls.SfButton btnDeleteStudent;
        private Syncfusion.WinForms.Controls.SfButton btnCheck;
    }
}
