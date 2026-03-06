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
            comboSubject = new ComboBox();
            dateTimeStarting = new DateTimePicker();
            dateTimeEnding = new DateTimePicker();
            label4 = new Label();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnClose = new Krypton.Toolkit.KryptonButton();
            btnCancel = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(36, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(283, 27);
            txtName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(29, 37, 48);
            label1.Location = new Point(35, 53);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 1;
            label1.Text = "Class Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(29, 37, 48);
            label2.Location = new Point(35, 114);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 3;
            label2.Text = "Subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(29, 37, 48);
            label3.Location = new Point(35, 176);
            label3.Name = "label3";
            label3.Size = new Size(53, 23);
            label3.TabIndex = 5;
            label3.Text = "Time:";
            // 
            // comboSubject
            // 
            comboSubject.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboSubject.FormattingEnabled = true;
            comboSubject.Items.AddRange(new object[] { "Math", "Science", "History", "Literature", "Art", "Music", "PhysicalEducation", "ComputerScience" });
            comboSubject.Location = new Point(35, 141);
            comboSubject.Name = "comboSubject";
            comboSubject.Size = new Size(284, 31);
            comboSubject.TabIndex = 1;
            comboSubject.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimeStarting
            // 
            dateTimeStarting.Format = DateTimePickerFormat.Time;
            dateTimeStarting.Location = new Point(35, 204);
            dateTimeStarting.Name = "dateTimeStarting";
            dateTimeStarting.ShowUpDown = true;
            dateTimeStarting.Size = new Size(96, 23);
            dateTimeStarting.TabIndex = 2;
            dateTimeStarting.Value = new DateTime(2026, 2, 24, 9, 0, 0, 0);
            // 
            // dateTimeEnding
            // 
            dateTimeEnding.Format = DateTimePickerFormat.Time;
            dateTimeEnding.Location = new Point(163, 204);
            dateTimeEnding.Name = "dateTimeEnding";
            dateTimeEnding.ShowUpDown = true;
            dateTimeEnding.Size = new Size(96, 23);
            dateTimeEnding.TabIndex = 3;
            dateTimeEnding.Value = new DateTime(2026, 2, 24, 10, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F);
            label4.Location = new Point(137, 207);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 10;
            label4.Text = "->";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnClose);
            kryptonPanel1.Controls.Add(btnCancel);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Controls.Add(kryptonButton1);
            kryptonPanel1.Controls.Add(txtName);
            kryptonPanel1.Controls.Add(label1);
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Controls.Add(label3);
            kryptonPanel1.Controls.Add(comboSubject);
            kryptonPanel1.Controls.Add(dateTimeStarting);
            kryptonPanel1.Controls.Add(dateTimeEnding);
            kryptonPanel1.Controls.Add(label4);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(387, 301);
            kryptonPanel1.StateCommon.Color1 = Color.Transparent;
            kryptonPanel1.TabIndex = 11;
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(332, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 43);
            btnClose.StateCommon.Back.Color1 = Color.White;
            btnClose.StateCommon.Back.Color2 = Color.White;
            btnClose.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnClose.StateCommon.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnClose.StateCommon.Border.Rounding = 20F;
            btnClose.StateCommon.Content.Padding = new Padding(0, 0, 1, 6);
            btnClose.StateCommon.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnClose.StateCommon.Content.ShortText.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            btnClose.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnClose.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnClose.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 153);
            btnClose.TabIndex = 13;
            btnClose.Values.DropDownArrowColor = Color.Empty;
            btnClose.Values.Text = "x";
            btnClose.Click += btnClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(35, 249);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(73, 35);
            btnCancel.StateCommon.Back.Color1 = Color.White;
            btnCancel.StateCommon.Back.Color2 = Color.White;
            btnCancel.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnCancel.StateCommon.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnCancel.StateCommon.Border.Rounding = 4F;
            btnCancel.StateCommon.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnCancel.StateCommon.Content.ShortText.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            btnCancel.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnCancel.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnCancel.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 153);
            btnCancel.TabIndex = 4;
            btnCancel.Values.DropDownArrowColor = Color.Empty;
            btnCancel.Values.Text = "Cancel";
            btnCancel.Click += btnClose_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 12);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(201, 31);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 12;
            kryptonLabel1.Values.Text = "Create New Class";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Cursor = Cursors.Hand;
            kryptonButton1.Location = new Point(118, 249);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(141, 35);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(39, 165, 153);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(39, 165, 153);
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(39, 165, 153);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(39, 165, 153);
            kryptonButton1.StateCommon.Border.Rounding = 4F;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Inter SemiBold", 12F, FontStyle.Bold);
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(77, 180, 170);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(77, 180, 170);
            kryptonButton1.TabIndex = 5;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Save Class";
            kryptonButton1.Click += btnSave_Click;
            // 
            // AddSectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(387, 301);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboSubject;
        private DateTimePicker dateTimeStarting;
        private DateTimePicker dateTimeEnding;
        private Label label4;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonButton btnClose;
    }
}