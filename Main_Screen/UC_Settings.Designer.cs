namespace AE.Application
{
    partial class UC_Settings
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
            AccountManagementPanel = new Krypton.Toolkit.KryptonPanel();
            PasswordChangeButton = new Krypton.Toolkit.KryptonButton();
            UsernameChangebutton = new Krypton.Toolkit.KryptonButton();
            PasswordChangetxtbox = new Krypton.Toolkit.KryptonTextBox();
            UsernameChangetxtbox = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            label1 = new Label();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)AccountManagementPanel).BeginInit();
            AccountManagementPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AccountManagementPanel
            // 
            AccountManagementPanel.Controls.Add(PasswordChangeButton);
            AccountManagementPanel.Controls.Add(UsernameChangebutton);
            AccountManagementPanel.Controls.Add(PasswordChangetxtbox);
            AccountManagementPanel.Controls.Add(UsernameChangetxtbox);
            AccountManagementPanel.Controls.Add(kryptonLabel3);
            AccountManagementPanel.Controls.Add(kryptonLabel2);
            AccountManagementPanel.Controls.Add(label1);
            AccountManagementPanel.Location = new Point(28, 51);
            AccountManagementPanel.Name = "AccountManagementPanel";
            AccountManagementPanel.Size = new Size(556, 261);
            AccountManagementPanel.StateCommon.Color1 = Color.White;
            AccountManagementPanel.TabIndex = 0;
            AccountManagementPanel.Paint += kryptonPanel1_Paint;
            // 
            // PasswordChangeButton
            // 
            PasswordChangeButton.Location = new Point(258, 188);
            PasswordChangeButton.Name = "PasswordChangeButton";
            PasswordChangeButton.Size = new Size(22, 23);
            PasswordChangeButton.StateCommon.Content.ShortText.Font = new Font("Material Symbols Sharp", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordChangeButton.StateNormal.Back.Color1 = Color.FromArgb(39, 165, 153);
            PasswordChangeButton.StateNormal.Back.Color2 = Color.FromArgb(39, 165, 153);
            PasswordChangeButton.StateNormal.Border.Color1 = Color.FromArgb(39, 165, 153);
            PasswordChangeButton.StateNormal.Border.Color2 = Color.FromArgb(39, 165, 153);
            PasswordChangeButton.StateNormal.Border.Rounding = 5F;
            PasswordChangeButton.StateNormal.Content.ShortText.Color1 = Color.White;
            PasswordChangeButton.StateNormal.Content.ShortText.Color2 = Color.White;
            PasswordChangeButton.StateNormal.Content.ShortText.Font = new Font("Material Symbols Sharp", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordChangeButton.TabIndex = 11;
            PasswordChangeButton.Values.DropDownArrowColor = Color.Empty;
            PasswordChangeButton.Values.Text = "";
            PasswordChangeButton.Values.UACShieldIconSize = Krypton.Toolkit.IconSize.Tiny;
            // 
            // UsernameChangebutton
            // 
            UsernameChangebutton.Location = new Point(258, 117);
            UsernameChangebutton.Name = "UsernameChangebutton";
            UsernameChangebutton.Size = new Size(22, 23);
            UsernameChangebutton.StateCommon.Content.ShortText.Font = new Font("Material Symbols Sharp", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameChangebutton.StateNormal.Back.Color1 = Color.FromArgb(39, 165, 153);
            UsernameChangebutton.StateNormal.Back.Color2 = Color.FromArgb(39, 165, 153);
            UsernameChangebutton.StateNormal.Border.Color1 = Color.FromArgb(39, 165, 153);
            UsernameChangebutton.StateNormal.Border.Color2 = Color.FromArgb(39, 165, 153);
            UsernameChangebutton.StateNormal.Border.Rounding = 5F;
            UsernameChangebutton.StateNormal.Content.ShortText.Color1 = Color.White;
            UsernameChangebutton.StateNormal.Content.ShortText.Color2 = Color.White;
            UsernameChangebutton.StateNormal.Content.ShortText.Font = new Font("Material Symbols Sharp", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameChangebutton.TabIndex = 10;
            UsernameChangebutton.Values.DropDownArrowColor = Color.Empty;
            UsernameChangebutton.Values.Text = "";
            UsernameChangebutton.Values.UACShieldIconSize = Krypton.Toolkit.IconSize.Tiny;
            // 
            // PasswordChangetxtbox
            // 
            PasswordChangetxtbox.Location = new Point(15, 188);
            PasswordChangetxtbox.Name = "PasswordChangetxtbox";
            PasswordChangetxtbox.Size = new Size(237, 23);
            PasswordChangetxtbox.TabIndex = 9;
            PasswordChangetxtbox.Text = "kryptonTextBox2";
            // 
            // UsernameChangetxtbox
            // 
            UsernameChangetxtbox.Location = new Point(15, 117);
            UsernameChangetxtbox.Name = "UsernameChangetxtbox";
            UsernameChangetxtbox.Size = new Size(237, 23);
            UsernameChangetxtbox.TabIndex = 8;
            UsernameChangetxtbox.Text = "kryptonTextBox1";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(15, 146);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(81, 54);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Material Symbols Sharp", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel3.StateDisabled.ShortText.Font = new Font("Material Symbols Sharp", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 7;
            kryptonLabel3.Values.ExtraText = "Password";
            kryptonLabel3.Values.Text = "";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(15, 91);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(81, 20);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Material Symbols Sharp", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.StateDisabled.ShortText.Font = new Font("Material Symbols Sharp", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel2.TabIndex = 2;
            kryptonLabel2.Values.ExtraText = "Username";
            kryptonLabel2.Values.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 37, 48);
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(322, 40);
            label1.TabIndex = 6;
            label1.Text = "Account Management";
            label1.Click += label1_Click_1;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(28, 21);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(24, 24);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Material Symbols Sharp", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.StateDisabled.ShortText.Font = new Font("Material Symbols Sharp", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 1;
            kryptonLabel1.Values.Text = "";
            // 
            // UC_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            Controls.Add(kryptonLabel1);
            Controls.Add(AccountManagementPanel);
            Name = "UC_Settings";
            Size = new Size(1150, 640);
            Load += UC_Settings_Load;
            ((System.ComponentModel.ISupportInitialize)AccountManagementPanel).EndInit();
            AccountManagementPanel.ResumeLayout(false);
            AccountManagementPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel AccountManagementPanel;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Label label1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton UsernameChangebutton;
        private Krypton.Toolkit.KryptonTextBox PasswordChangetxtbox;
        private Krypton.Toolkit.KryptonTextBox UsernameChangetxtbox;
        private Krypton.Toolkit.KryptonButton PasswordChangeButton;
    }
}
