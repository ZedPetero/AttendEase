namespace AE.Application
{
    partial class UC_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Home));
            panel1 = new Panel();
            btnGetStarted = new Syncfusion.WinForms.Controls.SfButton();
            imageList1 = new ImageList(components);
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 247, 247);
            panel1.Controls.Add(btnGetStarted);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1150, 640);
            panel1.TabIndex = 0;
            // 
            // btnGetStarted
            // 
            btnGetStarted.BackColor = Color.FromArgb(40, 164, 153);
            btnGetStarted.FlatStyle = FlatStyle.Flat;
            btnGetStarted.Font = new Font("Segoe UI Semibold", 18F);
            btnGetStarted.ForeColor = Color.White;
            btnGetStarted.ImageKey = "right-arrow (2).png";
            btnGetStarted.ImageList = imageList1;
            btnGetStarted.Location = new Point(489, 324);
            btnGetStarted.Name = "btnGetStarted";
            btnGetStarted.Padding = new Padding(2, 2, 4, 2);
            btnGetStarted.Size = new Size(173, 48);
            btnGetStarted.Style.BackColor = Color.FromArgb(40, 164, 153);
            btnGetStarted.Style.ForeColor = Color.White;
            btnGetStarted.TabIndex = 5;
            btnGetStarted.Text = "Get Started";
            btnGetStarted.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnGetStarted.UseVisualStyleBackColor = false;
            btnGetStarted.Click += btnGetStarted_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "right-arrow (2).png");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.ForeColor = Color.FromArgb(107, 124, 143);
            label4.Location = new Point(209, 262);
            label4.Name = "label4";
            label4.Size = new Size(732, 32);
            label4.TabIndex = 3;
            label4.Text = "present, late, and absent students with automatic score calculations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = Color.FromArgb(107, 124, 143);
            label3.Location = new Point(174, 226);
            label3.Name = "label3";
            label3.Size = new Size(802, 32);
            label3.TabIndex = 2;
            label3.Text = "A powerful yet simple attendance management system for teachers. Track";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(40, 164, 153);
            label2.Location = new Point(246, 121);
            label2.Name = "label2";
            label2.Size = new Size(658, 86);
            label2.TabIndex = 1;
            label2.Text = "Attendance Tracking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(28, 35, 46);
            label1.Location = new Point(355, 36);
            label1.Name = "label1";
            label1.Size = new Size(440, 86);
            label1.TabIndex = 0;
            label1.Text = "Simplify Your";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 404);
            panel2.Name = "panel2";
            panel2.Size = new Size(1150, 236);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(28, 35, 46);
            label5.Location = new Point(267, 9);
            label5.Name = "label5";
            label5.Size = new Size(659, 86);
            label5.TabIndex = 6;
            label5.Text = "Everything you need";
            // 
            // UC_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UC_Home";
            Size = new Size(1150, 640);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private ImageList imageList1;
        private Syncfusion.WinForms.Controls.SfButton btnGetStarted;
        private Label label5;
    }
}
