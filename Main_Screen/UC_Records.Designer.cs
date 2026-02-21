namespace AE.Application
{
    partial class UC_Records
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
            archivedclasspanel = new Panel();
            currentclasspanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            currentclasseslistbox = new ListBox();
            archivedclasseslistbox = new ListBox();
            archivebutton = new Button();
            restorebutton = new Button();
            archivedclasspanel.SuspendLayout();
            currentclasspanel.SuspendLayout();
            SuspendLayout();
            // 
            // archivedclasspanel
            // 
            archivedclasspanel.BackColor = Color.White;
            archivedclasspanel.Controls.Add(restorebutton);
            archivedclasspanel.Controls.Add(archivedclasseslistbox);
            archivedclasspanel.Controls.Add(label3);
            archivedclasspanel.Location = new Point(15, 229);
            archivedclasspanel.Name = "archivedclasspanel";
            archivedclasspanel.Size = new Size(587, 146);
            archivedclasspanel.TabIndex = 3;
            // 
            // currentclasspanel
            // 
            currentclasspanel.Controls.Add(archivebutton);
            currentclasspanel.Controls.Add(currentclasseslistbox);
            currentclasspanel.Controls.Add(label2);
            currentclasspanel.Location = new Point(15, 94);
            currentclasspanel.Name = "currentclasspanel";
            currentclasspanel.Size = new Size(587, 129);
            currentclasspanel.TabIndex = 4;
            currentclasspanel.Paint += currentclasspanel_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(15, 27);
            label1.Name = "label1";
            label1.Size = new Size(126, 40);
            label1.TabIndex = 5;
            label1.Text = "Records";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(158, 30);
            label2.TabIndex = 0;
            label2.Text = "Current Classes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 18);
            label3.Name = "label3";
            label3.Size = new Size(170, 30);
            label3.TabIndex = 1;
            label3.Text = "Archived Classes";
            // 
            // currentclasseslistbox
            // 
            currentclasseslistbox.FormattingEnabled = true;
            currentclasseslistbox.Location = new Point(13, 48);
            currentclasseslistbox.Name = "currentclasseslistbox";
            currentclasseslistbox.Size = new Size(555, 64);
            currentclasseslistbox.TabIndex = 1;
            // 
            // archivedclasseslistbox
            // 
            archivedclasseslistbox.FormattingEnabled = true;
            archivedclasseslistbox.Location = new Point(13, 51);
            archivedclasseslistbox.Name = "archivedclasseslistbox";
            archivedclasseslistbox.Size = new Size(555, 64);
            archivedclasseslistbox.TabIndex = 2;
            // 
            // archivebutton
            // 
            archivebutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            archivebutton.Location = new Point(484, 6);
            archivebutton.Name = "archivebutton";
            archivebutton.Size = new Size(84, 38);
            archivebutton.TabIndex = 2;
            archivebutton.Text = "Archive";
            archivebutton.UseVisualStyleBackColor = true;
            // 
            // restorebutton
            // 
            restorebutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            restorebutton.Location = new Point(484, 7);
            restorebutton.Name = "restorebutton";
            restorebutton.Size = new Size(84, 38);
            restorebutton.TabIndex = 3;
            restorebutton.Text = "Restore";
            restorebutton.UseVisualStyleBackColor = true;
            // 
            // UC_Records
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(currentclasspanel);
            Controls.Add(archivedclasspanel);
            Name = "UC_Records";
            Size = new Size(1150, 640);
            archivedclasspanel.ResumeLayout(false);
            archivedclasspanel.PerformLayout();
            currentclasspanel.ResumeLayout(false);
            currentclasspanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel archivedclasspanel;
        private Panel currentclasspanel;
        private Label label1;
        private Label label2;
        private ListBox archivedclasseslistbox;
        private Label label3;
        private ListBox currentclasseslistbox;
        private Button restorebutton;
        private Button archivebutton;
    }
}
