using Brevi.Domain.Models;

namespace Brevi.Application
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
            btnClose = new Krypton.Toolkit.KryptonButton();
            btnCancel = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            btnSaveClass = new Krypton.Toolkit.KryptonButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimeStarting = new DateTimePicker();
            dateTimeEnding = new DateTimePicker();
            label4 = new Label();
            txtName = new Krypton.Toolkit.KryptonTextBox();
            comboSubject = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)comboSubject).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(365, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 43);
            btnClose.StateCommon.Back.Color1 = Color.White;
            btnClose.StateCommon.Back.Color2 = Color.White;
            btnClose.StateCommon.Border.Color1 = Color.White;
            btnClose.StateCommon.Border.Color2 = Color.White;
            btnClose.StateCommon.Border.Rounding = 20F;
            btnClose.StateCommon.Content.Padding = new Padding(0, 0, 1, 6);
            btnClose.StateCommon.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnClose.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnClose.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnClose.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 153);
            btnClose.TabIndex = 25;
            btnClose.TabStop = false;
            btnClose.Values.DropDownArrowColor = Color.Empty;
            btnClose.Values.Text = "";
            btnClose.Click += btnClose_Click;
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(217, 293);
            btnCancel.Name = "btnCancel";
            btnCancel.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            btnCancel.Size = new Size(73, 35);
            btnCancel.StateCommon.Back.Color1 = Color.White;
            btnCancel.StateCommon.Back.Color2 = Color.White;
            btnCancel.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnCancel.StateCommon.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnCancel.StateCommon.Border.Rounding = 4F;
            btnCancel.StateCommon.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnCancel.StateCommon.Content.ShortText.Font = new Font("Inter", 12F, FontStyle.Bold);
            btnCancel.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnCancel.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnCancel.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 153);
            btnCancel.TabIndex = 7;
            btnCancel.Values.DropDownArrowColor = Color.Empty;
            btnCancel.Values.Text = "Cancel";
            btnCancel.Click += btnClose_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 12);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(204, 31);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Inter", 16F, FontStyle.Bold);
            kryptonLabel1.TabIndex = 24;
            kryptonLabel1.Values.Text = "Create New Class";
            // 
            // btnSaveClass
            // 
            btnSaveClass.Cursor = Cursors.Hand;
            btnSaveClass.Location = new Point(296, 293);
            btnSaveClass.Name = "btnSaveClass";
            btnSaveClass.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            btnSaveClass.Size = new Size(112, 35);
            btnSaveClass.StateCommon.Back.Color1 = Color.FromArgb(39, 165, 153);
            btnSaveClass.StateCommon.Back.Color2 = Color.FromArgb(39, 165, 153);
            btnSaveClass.StateCommon.Border.Color1 = Color.FromArgb(39, 165, 153);
            btnSaveClass.StateCommon.Border.Color2 = Color.FromArgb(39, 165, 153);
            btnSaveClass.StateCommon.Border.Rounding = 4F;
            btnSaveClass.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSaveClass.StateCommon.Content.ShortText.Font = new Font("Inter", 12F, FontStyle.Bold);
            btnSaveClass.StateTracking.Back.Color1 = Color.FromArgb(77, 180, 170);
            btnSaveClass.StateTracking.Back.Color2 = Color.FromArgb(77, 180, 170);
            btnSaveClass.TabIndex = 6;
            btnSaveClass.Values.DropDownArrowColor = Color.Empty;
            btnSaveClass.Values.Text = "Save Class";
            btnSaveClass.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(29, 37, 48);
            label1.Location = new Point(60, 70);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 15;
            label1.Text = "Class Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(29, 37, 48);
            label2.Location = new Point(60, 139);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 18;
            label2.Text = "Subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Inter", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(29, 37, 48);
            label3.Location = new Point(60, 211);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 22;
            label3.Text = "Time:";
            // 
            // dateTimeStarting
            // 
            dateTimeStarting.Font = new Font("Inter", 12F);
            dateTimeStarting.Format = DateTimePickerFormat.Time;
            dateTimeStarting.Location = new Point(60, 244);
            dateTimeStarting.Name = "dateTimeStarting";
            dateTimeStarting.ShowUpDown = true;
            dateTimeStarting.Size = new Size(130, 27);
            dateTimeStarting.TabIndex = 3;
            dateTimeStarting.Value = new DateTime(2026, 2, 24, 9, 0, 0, 0);
            // 
            // dateTimeEnding
            // 
            dateTimeEnding.Font = new Font("Inter", 12F);
            dateTimeEnding.Format = DateTimePickerFormat.Time;
            dateTimeEnding.Location = new Point(230, 244);
            dateTimeEnding.Name = "dateTimeEnding";
            dateTimeEnding.ShowUpDown = true;
            dateTimeEnding.Size = new Size(130, 27);
            dateTimeEnding.TabIndex = 4;
            dateTimeEnding.Value = new DateTime(2026, 2, 24, 10, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Material Symbols Outlined", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(193, 245);
            label4.Name = "label4";
            label4.Size = new Size(34, 26);
            label4.TabIndex = 23;
            label4.Text = "";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(61, 96);
            txtName.Name = "txtName";
            txtName.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            txtName.Size = new Size(299, 28);
            txtName.StateCommon.Border.Rounding = 5F;
            txtName.StateCommon.Content.Font = new Font("Inter", 10F);
            txtName.TabIndex = 1;
            // 
            // comboSubject
            // 
            comboSubject.DropDownWidth = 295;
            comboSubject.Items.AddRange(new object[] { "Math", "Science", "History", "Literature", "Art", "Music", "PhysicalEducation", "ComputerScience" });
            comboSubject.Location = new Point(60, 173);
            comboSubject.Name = "comboSubject";
            comboSubject.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            comboSubject.Size = new Size(300, 27);
            comboSubject.StateCommon.ComboBox.Border.Rounding = 5F;
            comboSubject.StateCommon.ComboBox.Content.Font = new Font("Inter", 10F);
            comboSubject.StateCommon.ComboBox.Content.Padding = new Padding(-1, 5, -1, 5);
            comboSubject.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboSubject.StateCommon.Item.Content.ShortText.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboSubject.TabIndex = 2;
            // 
            // AddSectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(420, 340);
            Controls.Add(comboSubject);
            Controls.Add(txtName);
            Controls.Add(kryptonLabel1);
            Controls.Add(btnClose);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(dateTimeEnding);
            Controls.Add(label3);
            Controls.Add(dateTimeStarting);
            Controls.Add(btnSaveClass);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddSectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)comboSubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnCancel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnSaveClass;
        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimeStarting;
        private DateTimePicker dateTimeEnding;
        private Label label4;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private Krypton.Toolkit.KryptonComboBox comboSubject;
    }
}