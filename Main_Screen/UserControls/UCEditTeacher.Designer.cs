namespace Brevi.Application
{
    partial class UCEditTeacher
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
            vScrollBar1 = new VScrollBar();
            panel1 = new Panel();
            datePickerDate = new DateTimePicker();
            cmbSubject = new Krypton.Toolkit.KryptonComboBox();
            txtLastName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            txtMiddleName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            txtPhoneNum = new Krypton.Toolkit.KryptonTextBox();
            txtEmail = new Krypton.Toolkit.KryptonTextBox();
            txtBio = new Krypton.Toolkit.KryptonRichTextBox();
            txtFirstName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            btnUploadPicture = new Krypton.Toolkit.KryptonButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbSubject).BeginInit();
            SuspendLayout();
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(346, 313);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(8, 8);
            vScrollBar1.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(datePickerDate);
            panel1.Controls.Add(cmbSubject);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(kryptonLabel10);
            panel1.Controls.Add(txtMiddleName);
            panel1.Controls.Add(kryptonLabel1);
            panel1.Controls.Add(txtPhoneNum);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtBio);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(kryptonLabel5);
            panel1.Controls.Add(kryptonLabel9);
            panel1.Controls.Add(kryptonLabel8);
            panel1.Controls.Add(kryptonLabel7);
            panel1.Controls.Add(kryptonLabel6);
            panel1.Controls.Add(kryptonLabel4);
            panel1.Controls.Add(kryptonLabel3);
            panel1.Controls.Add(kryptonLabel2);
            panel1.Controls.Add(btnUploadPicture);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 516);
            panel1.TabIndex = 47;
            // 
            // datePickerDate
            // 
            datePickerDate.CalendarTitleBackColor = Color.FromArgb(39, 165, 153);
            datePickerDate.Location = new Point(292, 247);
            datePickerDate.Name = "datePickerDate";
            datePickerDate.Size = new Size(214, 23);
            datePickerDate.TabIndex = 51;
            // 
            // cmbSubject
            // 
            cmbSubject.DropDownWidth = 214;
            cmbSubject.Items.AddRange(new object[] { "Math", "Science", "History", "Literature", "Art", "Music", "PhysicalEducation", "ComputerScience" });
            cmbSubject.Location = new Point(34, 331);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(214, 22);
            cmbSubject.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbSubject.TabIndex = 52;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(371, 166);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(155, 30);
            txtLastName.StateCommon.Border.Rounding = 10F;
            txtLastName.StateCommon.Content.Font = new Font("Inter", 10F);
            txtLastName.TabIndex = 49;
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(371, 122);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new Size(110, 38);
            kryptonLabel10.StateCommon.LongText.Color1 = Color.FromArgb(108, 124, 137);
            kryptonLabel10.StateCommon.LongText.Color2 = Color.FromArgb(108, 124, 137);
            kryptonLabel10.StateCommon.LongText.Font = new Font("Inter", 10F);
            kryptonLabel10.StateCommon.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel10.StateCommon.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel10.StateCommon.ShortText.Color1 = Color.FromArgb(63, 174, 163);
            kryptonLabel10.StateCommon.ShortText.Color2 = Color.FromArgb(63, 174, 163);
            kryptonLabel10.StateCommon.ShortText.Font = new Font("Material Symbols Outlined", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel10.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel10.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel10.TabIndex = 65;
            kryptonLabel10.Values.ExtraText = "Last Name";
            kryptonLabel10.Values.Text = "";
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(201, 166);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(155, 30);
            txtMiddleName.StateCommon.Border.Rounding = 10F;
            txtMiddleName.StateCommon.Content.Font = new Font("Inter", 10F);
            txtMiddleName.TabIndex = 48;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(201, 122);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(110, 38);
            kryptonLabel1.StateCommon.LongText.Color1 = Color.FromArgb(108, 124, 137);
            kryptonLabel1.StateCommon.LongText.Color2 = Color.FromArgb(108, 124, 137);
            kryptonLabel1.StateCommon.LongText.Font = new Font("Inter", 10F);
            kryptonLabel1.StateCommon.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel1.StateCommon.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(63, 174, 163);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(63, 174, 163);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Material Symbols Outlined", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel1.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 64;
            kryptonLabel1.Values.ExtraText = "Middle Name";
            kryptonLabel1.Values.Text = "";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(292, 328);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(214, 30);
            txtPhoneNum.StateCommon.Border.Rounding = 10F;
            txtPhoneNum.StateCommon.Content.Font = new Font("Inter", 10F);
            txtPhoneNum.TabIndex = 53;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(34, 247);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(214, 30);
            txtEmail.StateCommon.Border.Rounding = 10F;
            txtEmail.StateCommon.Content.Font = new Font("Inter", 10F);
            txtEmail.TabIndex = 50;
            // 
            // txtBio
            // 
            txtBio.Location = new Point(31, 401);
            txtBio.Name = "txtBio";
            txtBio.Size = new Size(495, 96);
            txtBio.StateCommon.Border.Rounding = 10F;
            txtBio.StateCommon.Content.Font = new Font("Inter", 10F);
            txtBio.TabIndex = 54;
            txtBio.Text = "";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(31, 166);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(155, 30);
            txtFirstName.StateCommon.Border.Rounding = 10F;
            txtFirstName.StateCommon.Content.Font = new Font("Inter", 10F);
            txtFirstName.TabIndex = 47;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new Point(25, 370);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(143, 25);
            kryptonLabel5.StateCommon.ShortText.Color1 = Color.FromArgb(108, 124, 137);
            kryptonLabel5.StateCommon.ShortText.Color2 = Color.FromArgb(108, 124, 137);
            kryptonLabel5.StateCommon.ShortText.Font = new Font("Inter", 10F);
            kryptonLabel5.TabIndex = 63;
            kryptonLabel5.Values.Text = "Bio (optional)";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(25, 287);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new Size(109, 38);
            kryptonLabel9.StateCommon.LongText.Color1 = Color.FromArgb(108, 124, 137);
            kryptonLabel9.StateCommon.LongText.Color2 = Color.FromArgb(108, 124, 137);
            kryptonLabel9.StateCommon.LongText.Font = new Font("Inter", 10F);
            kryptonLabel9.StateCommon.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel9.StateCommon.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel9.StateCommon.ShortText.Color1 = Color.FromArgb(63, 174, 163);
            kryptonLabel9.StateCommon.ShortText.Color2 = Color.FromArgb(63, 174, 163);
            kryptonLabel9.StateCommon.ShortText.Font = new Font("Material Symbols Outlined", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel9.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel9.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel9.TabIndex = 62;
            kryptonLabel9.Values.ExtraText = "Subject";
            kryptonLabel9.Values.Text = "";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(292, 203);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new Size(128, 38);
            kryptonLabel8.StateCommon.LongText.Color1 = Color.FromArgb(108, 124, 137);
            kryptonLabel8.StateCommon.LongText.Color2 = Color.FromArgb(108, 124, 137);
            kryptonLabel8.StateCommon.LongText.Font = new Font("Inter", 10F);
            kryptonLabel8.StateCommon.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel8.StateCommon.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel8.StateCommon.ShortText.Color1 = Color.FromArgb(63, 174, 163);
            kryptonLabel8.StateCommon.ShortText.Color2 = Color.FromArgb(63, 174, 163);
            kryptonLabel8.StateCommon.ShortText.Font = new Font("Material Symbols Outlined", 18F);
            kryptonLabel8.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel8.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel8.TabIndex = 61;
            kryptonLabel8.Values.ExtraText = "Birthdate";
            kryptonLabel8.Values.Text = "";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(292, 284);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new Size(99, 38);
            kryptonLabel7.StateCommon.LongText.Color1 = Color.FromArgb(108, 124, 137);
            kryptonLabel7.StateCommon.LongText.Color2 = Color.FromArgb(108, 124, 137);
            kryptonLabel7.StateCommon.LongText.Font = new Font("Inter", 10F);
            kryptonLabel7.StateCommon.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel7.StateCommon.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel7.StateCommon.ShortText.Color1 = Color.FromArgb(63, 174, 163);
            kryptonLabel7.StateCommon.ShortText.Color2 = Color.FromArgb(63, 174, 163);
            kryptonLabel7.StateCommon.ShortText.Font = new Font("Material Symbols Outlined", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel7.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel7.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel7.TabIndex = 60;
            kryptonLabel7.Values.ExtraText = "Phone";
            kryptonLabel7.Values.Text = "";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(25, 203);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(91, 38);
            kryptonLabel6.StateCommon.LongText.Color1 = Color.FromArgb(108, 124, 137);
            kryptonLabel6.StateCommon.LongText.Color2 = Color.FromArgb(108, 124, 137);
            kryptonLabel6.StateCommon.LongText.Font = new Font("Inter", 10F);
            kryptonLabel6.StateCommon.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel6.StateCommon.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel6.StateCommon.ShortText.Color1 = Color.FromArgb(63, 174, 163);
            kryptonLabel6.StateCommon.ShortText.Color2 = Color.FromArgb(63, 174, 163);
            kryptonLabel6.StateCommon.ShortText.Font = new Font("Material Symbols Outlined", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel6.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel6.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel6.TabIndex = 59;
            kryptonLabel6.Values.ExtraText = "Email";
            kryptonLabel6.Values.Text = "";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(31, 122);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(81, 38);
            kryptonLabel4.StateCommon.LongText.Color1 = Color.FromArgb(108, 124, 137);
            kryptonLabel4.StateCommon.LongText.Color2 = Color.FromArgb(108, 124, 137);
            kryptonLabel4.StateCommon.LongText.Font = new Font("Inter", 10F);
            kryptonLabel4.StateCommon.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel4.StateCommon.LongText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.FromArgb(63, 174, 163);
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.FromArgb(63, 174, 163);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Material Symbols Outlined", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel4.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel4.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel4.TabIndex = 58;
            kryptonLabel4.Values.ExtraText = "First Name";
            kryptonLabel4.Values.Text = "";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(123, 65);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(226, 27);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(108, 124, 137);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(108, 124, 137);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Inter", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 57;
            kryptonLabel3.Values.Text = "Subject";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(123, 24);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(226, 35);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Inter", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 56;
            kryptonLabel2.Values.Text = "Name Of Teacher";
            // 
            // btnUploadPicture
            // 
            btnUploadPicture.Cursor = Cursors.Hand;
            btnUploadPicture.Location = new Point(25, 24);
            btnUploadPicture.Margin = new Padding(0);
            btnUploadPicture.Name = "btnUploadPicture";
            btnUploadPicture.Size = new Size(85, 85);
            btnUploadPicture.StateCommon.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnUploadPicture.StateCommon.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnUploadPicture.StateCommon.Border.Rounding = 50F;
            btnUploadPicture.StateCommon.Content.Padding = new Padding(-1, 6, -1, -1);
            btnUploadPicture.StateCommon.Content.ShortText.Color1 = Color.FromArgb(63, 174, 163);
            btnUploadPicture.StateCommon.Content.ShortText.Color2 = Color.FromArgb(63, 174, 163);
            btnUploadPicture.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 35F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            btnUploadPicture.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            btnUploadPicture.StateCommon.Content.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Far;
            btnUploadPicture.StateNormal.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnUploadPicture.StateNormal.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnUploadPicture.StateNormal.Content.ShortText.Color1 = Color.FromArgb(63, 174, 163);
            btnUploadPicture.StateNormal.Content.ShortText.Color2 = Color.FromArgb(63, 174, 163);
            btnUploadPicture.StatePressed.Back.Color1 = Color.FromArgb(208, 222, 220);
            btnUploadPicture.StatePressed.Back.Color2 = Color.FromArgb(208, 222, 220);
            btnUploadPicture.StatePressed.Border.Color1 = Color.FromArgb(43, 154, 143);
            btnUploadPicture.StatePressed.Border.Color2 = Color.FromArgb(43, 154, 143);
            btnUploadPicture.StatePressed.Content.ShortText.Color1 = Color.FromArgb(63, 174, 163);
            btnUploadPicture.StatePressed.Content.ShortText.Color2 = Color.FromArgb(63, 174, 163);
            btnUploadPicture.StateTracking.Back.Color1 = Color.FromArgb(228, 242, 240);
            btnUploadPicture.StateTracking.Back.Color2 = Color.FromArgb(228, 242, 240);
            btnUploadPicture.StateTracking.Border.Color1 = Color.FromArgb(43, 154, 143);
            btnUploadPicture.StateTracking.Border.Color2 = Color.FromArgb(43, 154, 143);
            btnUploadPicture.StateTracking.Content.ShortText.Color1 = Color.FromArgb(63, 174, 163);
            btnUploadPicture.StateTracking.Content.ShortText.Color2 = Color.FromArgb(63, 174, 163);
            btnUploadPicture.TabIndex = 55;
            btnUploadPicture.Values.DropDownArrowColor = Color.Empty;
            btnUploadPicture.Values.Text = "";
            // 
            // UCEditTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 230, 235);
            Controls.Add(panel1);
            Controls.Add(vScrollBar1);
            Name = "UCEditTeacher";
            Size = new Size(550, 520);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private VScrollBar vScrollBar1;
        private Panel panel1;
        private DateTimePicker datePickerDate;
        private Krypton.Toolkit.KryptonComboBox cmbSubject;
        private Krypton.Toolkit.KryptonTextBox txtLastName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonTextBox txtMiddleName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtPhoneNum;
        private Krypton.Toolkit.KryptonTextBox txtEmail;
        private Krypton.Toolkit.KryptonRichTextBox txtBio;
        private Krypton.Toolkit.KryptonTextBox txtFirstName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnUploadPicture;
    }
}
