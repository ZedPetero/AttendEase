namespace AE.Application
{
    partial class Form_AddStudent
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
            btnSave = new Button();
            txtFirstName = new Krypton.Toolkit.KryptonTextBox();
            txtMiddleName = new Krypton.Toolkit.KryptonTextBox();
            txtLastName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            btnClose = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(333, 276);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(57, 37);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(61, 95);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(282, 30);
            txtFirstName.StateCommon.Border.Rounding = 10F;
            txtFirstName.StateCommon.Content.Font = new Font("Inter", 10F);
            txtFirstName.TabIndex = 8;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(61, 161);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(282, 30);
            txtMiddleName.StateCommon.Border.Rounding = 10F;
            txtMiddleName.StateCommon.Content.Font = new Font("Inter", 10F);
            txtMiddleName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(61, 227);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(282, 30);
            txtLastName.StateCommon.Border.Rounding = 10F;
            txtLastName.StateCommon.Content.Font = new Font("Inter", 10F);
            txtLastName.TabIndex = 10;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(61, 64);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(133, 25);
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel1.StateCommon.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Inter", 10F);
            kryptonLabel1.TabIndex = 11;
            kryptonLabel1.Values.Text = "First Name:";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(61, 130);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(133, 25);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Inter", 10F);
            kryptonLabel2.TabIndex = 12;
            kryptonLabel2.Values.Text = "Middle Name:";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(61, 196);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(133, 25);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Inter", 10F);
            kryptonLabel3.TabIndex = 13;
            kryptonLabel3.Values.Text = "Last Name:";
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.Location = new Point(341, 37);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(49, 46);
            btnClose.StateCommon.Back.Color1 = Color.Transparent;
            btnClose.StateCommon.Back.Color2 = Color.Transparent;
            btnClose.StateCommon.Border.Color1 = Color.Transparent;
            btnClose.StateCommon.Border.Color2 = Color.Transparent;
            btnClose.StateCommon.Border.Rounding = 30F;
            btnClose.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.TabIndex = 14;
            btnClose.Values.DropDownArrowColor = Color.Empty;
            btnClose.Values.Text = "";
            btnClose.Click += btnClose_Click;
            // 
            // Form_AddStudent
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 350);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(txtLastName);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(btnSave);
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
        private Button btnSave;
        private Krypton.Toolkit.KryptonTextBox txtFirstName;
        private Krypton.Toolkit.KryptonTextBox txtMiddleName;
        private Krypton.Toolkit.KryptonTextBox txtLastName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton btnClose;
    }
}