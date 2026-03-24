namespace Brevi.Application
{
    partial class UCStudentRow
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
            lblStudentName = new Label();
            lblStatus = new Label();
            pnlContent = new Panel();
            panel1 = new Panel();
            btnExcused = new Krypton.Toolkit.KryptonCheckButton();
            btnAbsent = new Krypton.Toolkit.KryptonCheckButton();
            btnPresent = new Krypton.Toolkit.KryptonCheckButton();
            btnLate = new Krypton.Toolkit.KryptonCheckButton();
            btnDeleteStudent = new Krypton.Toolkit.KryptonButton();
            lblNumber = new Krypton.Toolkit.KryptonButton();
            kryptonCheckSet1 = new Krypton.Toolkit.KryptonCheckSet(components);
            pnlContent.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonCheckSet1).BeginInit();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.BackColor = Color.Transparent;
            lblStudentName.Font = new Font("Inter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentName.ForeColor = Color.FromArgb(29, 37, 48);
            lblStudentName.Location = new Point(97, 22);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(191, 30);
            lblStudentName.TabIndex = 2;
            lblStudentName.Text = "Emma Thompson";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(29, 37, 48);
            lblStatus.Location = new Point(99, 56);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(99, 23);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Not Marked";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Controls.Add(lblStatus);
            pnlContent.Controls.Add(lblStudentName);
            pnlContent.Controls.Add(panel1);
            pnlContent.Controls.Add(lblNumber);
            pnlContent.Location = new Point(8, 2);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(790, 96);
            pnlContent.TabIndex = 8;
            pnlContent.SizeChanged += RoundPanel;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnExcused);
            panel1.Controls.Add(btnAbsent);
            panel1.Controls.Add(btnPresent);
            panel1.Controls.Add(btnLate);
            panel1.Controls.Add(btnDeleteStudent);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(473, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 96);
            panel1.TabIndex = 5;
            // 
            // btnExcused
            // 
            btnExcused.Cursor = Cursors.Hand;
            btnExcused.Location = new Point(123, 26);
            btnExcused.Name = "btnExcused";
            btnExcused.Size = new Size(45, 45);
            btnExcused.StateCheckedNormal.Back.Color1 = Color.FromArgb(13, 162, 231);
            btnExcused.StateCheckedNormal.Back.Color2 = Color.FromArgb(13, 162, 231);
            btnExcused.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnExcused.StateCheckedNormal.Border.Color1 = Color.FromArgb(13, 162, 231);
            btnExcused.StateCheckedNormal.Border.Color2 = Color.FromArgb(13, 162, 231);
            btnExcused.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnExcused.StateCheckedNormal.Border.Rounding = 5F;
            btnExcused.StateCheckedNormal.Border.Width = 1;
            btnExcused.StateCheckedNormal.Content.ShortText.Color1 = Color.White;
            btnExcused.StateCheckedPressed.Back.Color1 = Color.FromArgb(13, 162, 231);
            btnExcused.StateCheckedPressed.Back.Color2 = Color.FromArgb(13, 162, 231);
            btnExcused.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnExcused.StateCheckedPressed.Border.Color1 = Color.FromArgb(13, 162, 231);
            btnExcused.StateCheckedPressed.Border.Color2 = Color.FromArgb(13, 162, 231);
            btnExcused.StateCheckedPressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnExcused.StateCheckedTracking.Back.Color1 = Color.FromArgb(13, 162, 231);
            btnExcused.StateCheckedTracking.Back.Color2 = Color.FromArgb(13, 162, 231);
            btnExcused.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnExcused.StateCheckedTracking.Border.Color1 = Color.FromArgb(13, 162, 231);
            btnExcused.StateCheckedTracking.Border.Color2 = Color.FromArgb(13, 162, 231);
            btnExcused.StateCheckedTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnExcused.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnExcused.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnExcused.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnExcused.StateCommon.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnExcused.StateCommon.Border.Rounding = 5F;
            btnExcused.StateCommon.Border.Width = 1;
            btnExcused.StateCommon.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnExcused.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcused.StatePressed.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnExcused.StatePressed.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnExcused.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnExcused.StatePressed.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnExcused.StatePressed.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnExcused.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnExcused.StatePressed.Border.Rounding = 5F;
            btnExcused.StatePressed.Border.Width = 1;
            btnExcused.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnExcused.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnExcused.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnExcused.StateTracking.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnExcused.StateTracking.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnExcused.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnExcused.StateTracking.Border.Rounding = 5F;
            btnExcused.StateTracking.Border.Width = 1;
            btnExcused.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 173);
            btnExcused.TabIndex = 2;
            btnExcused.Values.DropDownArrowColor = Color.Empty;
            btnExcused.Values.Text = "";
            btnExcused.Click += BtnExcused_Click;
            // 
            // btnAbsent
            // 
            btnAbsent.Cursor = Cursors.Hand;
            btnAbsent.Location = new Point(179, 26);
            btnAbsent.Name = "btnAbsent";
            btnAbsent.Size = new Size(45, 45);
            btnAbsent.StateCheckedNormal.Back.Color1 = Color.FromArgb(223, 58, 58);
            btnAbsent.StateCheckedNormal.Back.Color2 = Color.FromArgb(223, 58, 58);
            btnAbsent.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnAbsent.StateCheckedNormal.Border.Color1 = Color.FromArgb(223, 58, 58);
            btnAbsent.StateCheckedNormal.Border.Color2 = Color.FromArgb(223, 58, 58);
            btnAbsent.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnAbsent.StateCheckedNormal.Border.Rounding = 5F;
            btnAbsent.StateCheckedNormal.Border.Width = 1;
            btnAbsent.StateCheckedNormal.Content.ShortText.Color1 = Color.White;
            btnAbsent.StateCheckedPressed.Back.Color1 = Color.FromArgb(223, 58, 58);
            btnAbsent.StateCheckedPressed.Back.Color2 = Color.FromArgb(223, 58, 58);
            btnAbsent.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnAbsent.StateCheckedPressed.Border.Color1 = Color.FromArgb(223, 58, 58);
            btnAbsent.StateCheckedPressed.Border.Color2 = Color.FromArgb(223, 58, 58);
            btnAbsent.StateCheckedPressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnAbsent.StateCheckedTracking.Back.Color1 = Color.FromArgb(223, 58, 58);
            btnAbsent.StateCheckedTracking.Back.Color2 = Color.FromArgb(223, 58, 58);
            btnAbsent.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnAbsent.StateCheckedTracking.Border.Color1 = Color.FromArgb(223, 58, 58);
            btnAbsent.StateCheckedTracking.Border.Color2 = Color.FromArgb(223, 58, 58);
            btnAbsent.StateCheckedTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnAbsent.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnAbsent.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnAbsent.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnAbsent.StateCommon.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnAbsent.StateCommon.Border.Rounding = 5F;
            btnAbsent.StateCommon.Border.Width = 1;
            btnAbsent.StateCommon.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnAbsent.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAbsent.StatePressed.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnAbsent.StatePressed.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnAbsent.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnAbsent.StatePressed.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnAbsent.StatePressed.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnAbsent.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnAbsent.StatePressed.Border.Rounding = 5F;
            btnAbsent.StatePressed.Border.Width = 1;
            btnAbsent.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnAbsent.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnAbsent.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnAbsent.StateTracking.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnAbsent.StateTracking.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnAbsent.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnAbsent.StateTracking.Border.Rounding = 5F;
            btnAbsent.StateTracking.Border.Width = 1;
            btnAbsent.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 173);
            btnAbsent.TabIndex = 3;
            btnAbsent.Values.DropDownArrowColor = Color.Empty;
            btnAbsent.Values.Text = "";
            btnAbsent.Click += BtnAbsent_Click;
            // 
            // btnPresent
            // 
            btnPresent.Cursor = Cursors.Hand;
            btnPresent.Location = new Point(11, 26);
            btnPresent.Name = "btnPresent";
            btnPresent.Size = new Size(45, 45);
            btnPresent.StateCheckedNormal.Back.Color1 = Color.FromArgb(34, 195, 93);
            btnPresent.StateCheckedNormal.Back.Color2 = Color.FromArgb(34, 195, 93);
            btnPresent.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPresent.StateCheckedNormal.Border.Color1 = Color.FromArgb(34, 195, 93);
            btnPresent.StateCheckedNormal.Border.Color2 = Color.FromArgb(34, 195, 93);
            btnPresent.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPresent.StateCheckedNormal.Border.Rounding = 5F;
            btnPresent.StateCheckedNormal.Border.Width = 1;
            btnPresent.StateCheckedNormal.Content.ShortText.Color1 = Color.White;
            btnPresent.StateCheckedPressed.Back.Color1 = Color.FromArgb(34, 195, 93);
            btnPresent.StateCheckedPressed.Back.Color2 = Color.FromArgb(34, 195, 93);
            btnPresent.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPresent.StateCheckedPressed.Border.Color1 = Color.FromArgb(34, 195, 93);
            btnPresent.StateCheckedPressed.Border.Color2 = Color.FromArgb(34, 195, 93);
            btnPresent.StateCheckedPressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPresent.StateCheckedTracking.Back.Color1 = Color.FromArgb(34, 195, 93);
            btnPresent.StateCheckedTracking.Back.Color2 = Color.FromArgb(34, 195, 93);
            btnPresent.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPresent.StateCheckedTracking.Border.Color1 = Color.FromArgb(34, 195, 93);
            btnPresent.StateCheckedTracking.Border.Color2 = Color.FromArgb(34, 195, 93);
            btnPresent.StateCheckedTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPresent.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnPresent.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnPresent.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnPresent.StateCommon.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnPresent.StateCommon.Border.Rounding = 5F;
            btnPresent.StateCommon.Border.Width = 1;
            btnPresent.StateCommon.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnPresent.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPresent.StatePressed.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnPresent.StatePressed.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnPresent.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPresent.StatePressed.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnPresent.StatePressed.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnPresent.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPresent.StatePressed.Border.Rounding = 5F;
            btnPresent.StatePressed.Border.Width = 1;
            btnPresent.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnPresent.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnPresent.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnPresent.StateTracking.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnPresent.StateTracking.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnPresent.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnPresent.StateTracking.Border.Rounding = 5F;
            btnPresent.StateTracking.Border.Width = 1;
            btnPresent.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 173);
            btnPresent.TabIndex = 0;
            btnPresent.Values.DropDownArrowColor = Color.Empty;
            btnPresent.Values.Text = "";
            btnPresent.Click += BtnPresent_Click;
            // 
            // btnLate
            // 
            btnLate.Cursor = Cursors.Hand;
            btnLate.Location = new Point(67, 26);
            btnLate.Name = "btnLate";
            btnLate.Size = new Size(45, 45);
            btnLate.StateCheckedNormal.Back.Color1 = Color.FromArgb(245, 159, 10);
            btnLate.StateCheckedNormal.Back.Color2 = Color.FromArgb(245, 159, 10);
            btnLate.StateCheckedNormal.Border.Color1 = Color.FromArgb(245, 159, 10);
            btnLate.StateCheckedNormal.Border.Color2 = Color.FromArgb(245, 159, 10);
            btnLate.StateCheckedNormal.Border.Rounding = 5F;
            btnLate.StateCheckedNormal.Border.Width = 1;
            btnLate.StateCheckedNormal.Content.ShortText.Color1 = Color.White;
            btnLate.StateCheckedPressed.Back.Color1 = Color.FromArgb(245, 159, 10);
            btnLate.StateCheckedPressed.Back.Color2 = Color.FromArgb(245, 159, 10);
            btnLate.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnLate.StateCheckedPressed.Border.Color1 = Color.FromArgb(245, 159, 10);
            btnLate.StateCheckedPressed.Border.Color2 = Color.FromArgb(245, 159, 10);
            btnLate.StateCheckedPressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLate.StateCheckedTracking.Back.Color1 = Color.FromArgb(245, 159, 10);
            btnLate.StateCheckedTracking.Back.Color2 = Color.FromArgb(245, 159, 10);
            btnLate.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnLate.StateCheckedTracking.Border.Color1 = Color.FromArgb(245, 159, 10);
            btnLate.StateCheckedTracking.Border.Color2 = Color.FromArgb(245, 159, 10);
            btnLate.StateCheckedTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLate.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnLate.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnLate.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnLate.StateCommon.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnLate.StateCommon.Border.Rounding = 5F;
            btnLate.StateCommon.Border.Width = 1;
            btnLate.StateCommon.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnLate.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLate.StatePressed.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnLate.StatePressed.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnLate.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnLate.StatePressed.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnLate.StatePressed.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnLate.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLate.StatePressed.Border.Rounding = 5F;
            btnLate.StatePressed.Border.Width = 1;
            btnLate.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnLate.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnLate.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnLate.StateTracking.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnLate.StateTracking.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnLate.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLate.StateTracking.Border.Rounding = 5F;
            btnLate.StateTracking.Border.Width = 1;
            btnLate.StateTracking.Content.ShortText.Color1 = Color.FromArgb(39, 165, 173);
            btnLate.TabIndex = 1;
            btnLate.Values.DropDownArrowColor = Color.Empty;
            btnLate.Values.Text = "";
            btnLate.Click += BtnLate_Click;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Cursor = Cursors.Hand;
            btnDeleteStudent.Location = new Point(249, 26);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(45, 45);
            btnDeleteStudent.StateCommon.Back.Color1 = Color.FromArgb(249, 250, 251);
            btnDeleteStudent.StateCommon.Back.Color2 = Color.FromArgb(249, 250, 251);
            btnDeleteStudent.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnDeleteStudent.StateCommon.Border.Color2 = Color.FromArgb(224, 230, 235);
            btnDeleteStudent.StateCommon.Border.Rounding = 5F;
            btnDeleteStudent.StateCommon.Border.Width = 1;
            btnDeleteStudent.StateCommon.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnDeleteStudent.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteStudent.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnDeleteStudent.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnDeleteStudent.StateTracking.Content.ShortText.Color1 = Color.FromArgb(223, 58, 58);
            btnDeleteStudent.TabIndex = 4;
            btnDeleteStudent.Values.DropDownArrowColor = Color.Empty;
            btnDeleteStudent.Values.Text = "";
            btnDeleteStudent.Click += BtnDeleteStudent_Click;
            // 
            // lblNumber
            // 
            lblNumber.Location = new Point(13, 19);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(58, 58);
            lblNumber.StateCommon.Back.Color1 = Color.FromArgb(211, 215, 222);
            lblNumber.StateCommon.Back.Color2 = Color.FromArgb(211, 215, 222);
            lblNumber.StateCommon.Border.Color1 = Color.FromArgb(211, 215, 222);
            lblNumber.StateCommon.Border.Color2 = Color.FromArgb(211, 215, 222);
            lblNumber.StateCommon.Border.Rounding = 50F;
            lblNumber.StateCommon.Content.Padding = new Padding(0);
            lblNumber.StateCommon.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            lblNumber.StateCommon.Content.ShortText.Font = new Font("Inter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumber.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblNumber.TabIndex = 0;
            lblNumber.TabStop = false;
            lblNumber.Values.DropDownArrowColor = Color.Empty;
            lblNumber.Values.Text = "1";
            // 
            // kryptonCheckSet1
            // 
            kryptonCheckSet1.CheckButtons.Add(btnPresent);
            kryptonCheckSet1.CheckButtons.Add(btnLate);
            kryptonCheckSet1.CheckButtons.Add(btnExcused);
            kryptonCheckSet1.CheckButtons.Add(btnAbsent);
            // 
            // UCStudentRow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(211, 215, 222);
            Controls.Add(pnlContent);
            Name = "UCStudentRow";
            Size = new Size(800, 100);
            SizeChanged += RoundPanel;
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonCheckSet1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblStatus;
        private Panel pnlContent;
        private Krypton.Toolkit.KryptonButton lblNumber;
        private Krypton.Toolkit.KryptonCheckButton btnAbsent;
        private Krypton.Toolkit.KryptonCheckButton btnExcused;
        private Krypton.Toolkit.KryptonCheckButton btnLate;
        private Krypton.Toolkit.KryptonCheckButton btnPresent;
        private Krypton.Toolkit.KryptonButton btnDeleteStudent;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSet1;
        public Label lblStudentName;
        private Panel panel1;
    }
}
