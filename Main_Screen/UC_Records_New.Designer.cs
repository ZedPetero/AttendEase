namespace AE.Application
{
    partial class UC_Records_New
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
            label1 = new Label();
            CurrentClassespanel = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            label2 = new Label();
            label3 = new Label();
            Restorebutton = new Krypton.Toolkit.KryptonButton();
            Archivebutton = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)CurrentClassespanel).BeginInit();
            CurrentClassespanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 37, 48);
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(126, 40);
            label1.TabIndex = 6;
            label1.Text = "Records";
            // 
            // CurrentClassespanel
            // 
            CurrentClassespanel.Controls.Add(Archivebutton);
            CurrentClassespanel.Controls.Add(label2);
            CurrentClassespanel.Location = new Point(41, 87);
            CurrentClassespanel.Name = "CurrentClassespanel";
            CurrentClassespanel.Size = new Size(573, 142);
            CurrentClassespanel.StateCommon.Color1 = Color.White;
            CurrentClassespanel.StateCommon.Color2 = Color.White;
            CurrentClassespanel.TabIndex = 7;
            CurrentClassespanel.Paint += kryptonPanel1_Paint;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(Restorebutton);
            kryptonPanel1.Controls.Add(label3);
            kryptonPanel1.Location = new Point(41, 261);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(573, 142);
            kryptonPanel1.StateCommon.Color1 = Color.White;
            kryptonPanel1.StateCommon.Color2 = Color.White;
            kryptonPanel1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(29, 37, 48);
            label2.Location = new Point(3, 10);
            label2.Name = "label2";
            label2.Size = new Size(219, 40);
            label2.TabIndex = 9;
            label2.Text = "Current Classes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(29, 37, 48);
            label3.Location = new Point(3, 10);
            label3.Name = "label3";
            label3.Size = new Size(236, 40);
            label3.TabIndex = 10;
            label3.Text = "Archived Classes";
            // 
            // Restorebutton
            // 
            Restorebutton.Location = new Point(480, 10);
            Restorebutton.Name = "Restorebutton";
            Restorebutton.Size = new Size(90, 36);
            Restorebutton.StateCommon.Border.Rounding = 20F;
            Restorebutton.StateCommon.Content.ShortText.Color1 = Color.White;
            Restorebutton.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Restorebutton.StateNormal.Back.Color1 = Color.FromArgb(39, 165, 153);
            Restorebutton.StateNormal.Back.Color2 = Color.FromArgb(39, 165, 153);
            Restorebutton.TabIndex = 11;
            Restorebutton.Values.DropDownArrowColor = Color.Empty;
            Restorebutton.Values.Text = "Restore";
            // 
            // Archivebutton
            // 
            Archivebutton.Location = new Point(480, 14);
            Archivebutton.Name = "Archivebutton";
            Archivebutton.Size = new Size(90, 36);
            Archivebutton.StateCommon.Border.Rounding = 20F;
            Archivebutton.StateCommon.Content.ShortText.Color1 = Color.White;
            Archivebutton.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Archivebutton.StateNormal.Back.Color1 = Color.FromArgb(39, 165, 153);
            Archivebutton.StateNormal.Back.Color2 = Color.FromArgb(39, 165, 153);
            Archivebutton.TabIndex = 12;
            Archivebutton.Values.DropDownArrowColor = Color.Empty;
            Archivebutton.Values.Text = "Archive";
            // 
            // UC_Records_New
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            Controls.Add(kryptonPanel1);
            Controls.Add(CurrentClassespanel);
            Controls.Add(label1);
            Name = "UC_Records_New";
            Size = new Size(1150, 640);
            ((System.ComponentModel.ISupportInitialize)CurrentClassespanel).EndInit();
            CurrentClassespanel.ResumeLayout(false);
            CurrentClassespanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Krypton.Toolkit.KryptonPanel CurrentClassespanel;
        private Label label2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton Restorebutton;
        private Label label3;
        private Krypton.Toolkit.KryptonButton Archivebutton;
    }
}
