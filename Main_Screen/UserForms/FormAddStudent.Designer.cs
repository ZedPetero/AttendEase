namespace AE.Application
{
    partial class FormAddStudent
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
            txtFirstName = new Krypton.Toolkit.KryptonTextBox();
            txtMiddleName = new Krypton.Toolkit.KryptonTextBox();
            txtLastName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            btnClose = new Krypton.Toolkit.KryptonButton();
            btnSave = new Krypton.Toolkit.KryptonButton();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            btnCancel = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(60, 92);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(330, 30);
            txtFirstName.StateCommon.Border.Rounding = 10F;
            txtFirstName.StateCommon.Content.Font = new Font("Inter", 10F);
            txtFirstName.TabIndex = 8;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(60, 174);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(330, 30);
            txtMiddleName.StateCommon.Border.Rounding = 10F;
            txtMiddleName.StateCommon.Content.Font = new Font("Inter", 10F);
            txtMiddleName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(60, 256);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(330, 30);
            txtLastName.StateCommon.Border.Rounding = 10F;
            txtLastName.StateCommon.Content.Font = new Font("Inter", 10F);
            txtLastName.TabIndex = 10;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(60, 53);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(181, 25);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Inter", 10F, FontStyle.Bold);
            kryptonLabel1.TabIndex = 11;
            kryptonLabel1.Values.Text = "First Name:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(60, 135);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(181, 25);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Inter", 10F, FontStyle.Bold);
            kryptonLabel2.TabIndex = 12;
            kryptonLabel2.Values.Text = "Middle Name (optional):";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(60, 217);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(181, 25);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Inter", 10F, FontStyle.Bold);
            kryptonLabel3.TabIndex = 13;
            kryptonLabel3.Values.Text = "Last Name:";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(395, 12);
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
            btnClose.TabIndex = 26;
            btnClose.TabStop = false;
            btnClose.Values.DropDownArrowColor = Color.Empty;
            btnClose.Values.Text = "";
            btnClose.Click += this.btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Cursor = Cursors.Hand;
            btnSave.Location = new Point(357, 303);
            btnSave.Name = "btnSave";
            btnSave.PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            btnSave.Size = new Size(81, 35);
            btnSave.StateCommon.Back.Color1 = Color.FromArgb(39, 165, 153);
            btnSave.StateCommon.Back.Color2 = Color.FromArgb(39, 165, 153);
            btnSave.StateCommon.Border.Color1 = Color.FromArgb(39, 165, 153);
            btnSave.StateCommon.Border.Color2 = Color.FromArgb(39, 165, 153);
            btnSave.StateCommon.Border.Rounding = 4F;
            btnSave.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSave.StateCommon.Content.ShortText.Font = new Font("Inter", 12F, FontStyle.Bold);
            btnSave.StateTracking.Back.Color1 = Color.FromArgb(77, 180, 170);
            btnSave.StateTracking.Back.Color2 = Color.FromArgb(77, 180, 170);
            btnSave.TabIndex = 27;
            btnSave.Values.DropDownArrowColor = Color.Empty;
            btnSave.Values.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(12, 12);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(181, 31);
            kryptonLabel4.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel4.StateCommon.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            kryptonLabel4.StateCommon.ShortText.Font = new Font("Inter", 16F, FontStyle.Bold);
            kryptonLabel4.TabIndex = 28;
            kryptonLabel4.Values.Text = "Add Student";
            // 
            // btnCancel
            // 
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Location = new Point(278, 303);
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
            btnCancel.TabIndex = 29;
            btnCancel.Values.DropDownArrowColor = Color.Empty;
            btnCancel.Values.Text = "Cancel";
            btnCancel.Click += btnClose_Click;
            // 
            // Form_AddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(450, 350);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(kryptonLabel4);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_AddStudent";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox txtFirstName;
        private Krypton.Toolkit.KryptonTextBox txtMiddleName;
        private Krypton.Toolkit.KryptonTextBox txtLastName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonButton btnCancel;
    }
}