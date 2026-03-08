namespace AE.Application
{
    partial class UC_RecordsClass
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
            Archivebutton = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
            // 
            // Archivebutton
            // 
            Archivebutton.Location = new Point(376, 12);
            Archivebutton.Name = "Archivebutton";
            Archivebutton.Size = new Size(90, 36);
            Archivebutton.StateCommon.Border.Rounding = 20F;
            Archivebutton.StateCommon.Content.ShortText.Color1 = Color.White;
            Archivebutton.StateCommon.Content.ShortText.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Archivebutton.StateNormal.Back.Color1 = Color.FromArgb(39, 165, 153);
            Archivebutton.StateNormal.Back.Color2 = Color.FromArgb(39, 165, 153);
            Archivebutton.TabIndex = 13;
            Archivebutton.Values.DropDownArrowColor = Color.Empty;
            Archivebutton.Values.Text = "Archive";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 18);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(116, 30);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 14;
            kryptonLabel1.Values.Text = "Class Name";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Location = new Point(504, 18);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(34, 25);
            kryptonButton1.StateCommon.Border.Rounding = 5F;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Material Symbols Sharp", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kryptonButton1.StateNormal.Back.Color1 = Color.White;
            kryptonButton1.StateNormal.Back.Color2 = Color.White;
            kryptonButton1.TabIndex = 15;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "";
            // 
            // UC_RecordsClass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(kryptonButton1);
            Controls.Add(kryptonLabel1);
            Controls.Add(Archivebutton);
            Name = "UC_RecordsClass";
            Size = new Size(550, 62);
            Load += this.UC_RecordsClass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonButton Archivebutton;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}
