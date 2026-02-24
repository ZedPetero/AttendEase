using AE.Domain.Models;

namespace AE.Application
{
    partial class AddSectionForm
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
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSave = new Syncfusion.WinForms.Controls.SfButton();
            comboSubject = new ComboBox();
            dateTimeStarting = new DateTimePicker();
            dateTimeEnding = new DateTimePicker();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(331, 132);
            txtName.Name = "txtName";
            txtName.Size = new Size(216, 23);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(253, 135);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 1;
            label1.Text = "Class Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 177);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 222);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 5;
            label3.Text = "Time:";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Font = new Font("Segoe UI Semibold", 9F);
            btnSave.Location = new Point(331, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(216, 28);
            btnSave.Style.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Class";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // comboSubject
            // 
            comboSubject.FormattingEnabled = true;
            comboSubject.Items.AddRange(new object[] { "Math", "Science", "History", "Literature", "Art", "Music", "PhysicalEducation", "ComputerScience" });
            comboSubject.Location = new Point(331, 174);
            comboSubject.Name = "comboSubject";
            comboSubject.Size = new Size(216, 23);
            comboSubject.TabIndex = 7;
            comboSubject.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimeStarting
            // 
            dateTimeStarting.Format = DateTimePickerFormat.Time;
            dateTimeStarting.Location = new Point(331, 216);
            dateTimeStarting.Name = "dateTimeStarting";
            dateTimeStarting.ShowUpDown = true;
            dateTimeStarting.Size = new Size(96, 23);
            dateTimeStarting.TabIndex = 8;
            dateTimeStarting.Value = new DateTime(2026, 2, 24, 9, 0, 0, 0);
            // 
            // dateTimeEnding
            // 
            dateTimeEnding.Format = DateTimePickerFormat.Time;
            dateTimeEnding.Location = new Point(451, 216);
            dateTimeEnding.Name = "dateTimeEnding";
            dateTimeEnding.ShowUpDown = true;
            dateTimeEnding.Size = new Size(96, 23);
            dateTimeEnding.TabIndex = 9;
            dateTimeEnding.Value = new DateTime(2026, 2, 24, 10, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(429, 220);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 10;
            label4.Text = "->";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddSectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(dateTimeEnding);
            Controls.Add(dateTimeStarting);
            Controls.Add(comboSubject);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSectionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddSectionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Syncfusion.WinForms.Controls.SfButton btnSave;
        private ComboBox comboSubject;
        private DateTimePicker dateTimeStarting;
        private DateTimePicker dateTimeEnding;
        private Label label4;
    }
}