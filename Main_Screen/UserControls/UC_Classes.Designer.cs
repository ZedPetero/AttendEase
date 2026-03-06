namespace AE.Application
{
    partial class UC_Classes
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
            panel1 = new Panel();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            flowLayoutPanelCards = new FlowLayoutPanel();
            label2 = new Label();
            lblTeacher = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 250, 251);
            panel1.Controls.Add(kryptonButton1);
            panel1.Controls.Add(flowLayoutPanelCards);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTeacher);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 640);
            panel1.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Cursor = Cursors.Hand;
            kryptonButton1.Location = new Point(961, 84);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.FromArgb(39, 165, 153);
            kryptonButton1.OverrideDefault.Back.Color2 = Color.FromArgb(39, 165, 153);
            kryptonButton1.OverrideDefault.Border.Color1 = Color.FromArgb(39, 165, 153);
            kryptonButton1.OverrideDefault.Border.Color2 = Color.FromArgb(39, 165, 153);
            kryptonButton1.OverrideDefault.Content.LongText.Color1 = Color.White;
            kryptonButton1.OverrideDefault.Content.ShortText.Color1 = Color.White;
            kryptonButton1.OverrideFocus.Back.Color1 = Color.FromArgb(39, 165, 153);
            kryptonButton1.OverrideFocus.Back.Color2 = Color.FromArgb(39, 165, 153);
            kryptonButton1.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton1.OverrideFocus.Border.Color1 = Color.FromArgb(39, 165, 153);
            kryptonButton1.OverrideFocus.Border.Color2 = Color.FromArgb(39, 165, 153);
            kryptonButton1.OverrideFocus.Content.LongText.Color1 = Color.White;
            kryptonButton1.OverrideFocus.Content.ShortText.Color1 = Color.White;
            kryptonButton1.Size = new Size(120, 45);
            kryptonButton1.StateCommon.Back.Color1 = Color.FromArgb(39, 165, 153);
            kryptonButton1.StateCommon.Back.Color2 = Color.FromArgb(39, 165, 153);
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(39, 165, 153);
            kryptonButton1.StateCommon.Border.Color2 = Color.FromArgb(39, 165, 153);
            kryptonButton1.StateCommon.Border.Rounding = 6F;
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.White;
            kryptonButton1.StateCommon.Content.ShortText.Font = new Font("Inter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonButton1.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton1.StatePressed.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(39, 166, 156);
            kryptonButton1.StateTracking.Back.Color2 = Color.FromArgb(39, 166, 156);
            kryptonButton1.StateTracking.Border.Color1 = Color.FromArgb(39, 166, 156);
            kryptonButton1.StateTracking.Border.Color2 = Color.FromArgb(39, 166, 156);
            kryptonButton1.TabIndex = 5;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "+  Add Class ";
            kryptonButton1.Click += btnAddClass_Click;
            // 
            // flowLayoutPanelCards
            // 
            flowLayoutPanelCards.AutoScroll = true;
            flowLayoutPanelCards.Location = new Point(27, 137);
            flowLayoutPanelCards.Name = "flowLayoutPanelCards";
            flowLayoutPanelCards.Size = new Size(1096, 463);
            flowLayoutPanelCards.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.ForeColor = Color.FromArgb(29, 37, 48);
            label2.Location = new Point(43, 101);
            label2.Name = "label2";
            label2.Size = new Size(82, 30);
            label2.TabIndex = 1;
            label2.Text = "Classes";
            // 
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTeacher.Location = new Point(36, 38);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(242, 45);
            lblTeacher.TabIndex = 0;
            lblTeacher.Text = "Hello, Teacher!";
            lblTeacher.Click += lblTeacher_Click;
            // 
            // UC_Classes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 250, 251);
            Controls.Add(panel1);
            Name = "UC_Classes";
            Size = new Size(1150, 640);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTeacher;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanelCards;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}
