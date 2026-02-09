namespace Main_Screen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            header = new Panel();
            hamburger = new PictureBox();
            label1 = new Label();
            logo = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            imageList1 = new ImageList(components);
            panel4 = new Panel();
            panel5 = new Panel();
            sidebar = new Panel();
            panel6 = new Panel();
            btnLogOut = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            pnlMainContent = new Panel();
            sfButton4 = new Syncfusion.WinForms.Controls.SfButton();
            sfButton3 = new Syncfusion.WinForms.Controls.SfButton();
            sfButton2 = new Syncfusion.WinForms.Controls.SfButton();
            sfButton1 = new Syncfusion.WinForms.Controls.SfButton();
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hamburger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            sidebar.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.BackColor = Color.White;
            header.Controls.Add(hamburger);
            header.Controls.Add(label1);
            header.Controls.Add(logo);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(1200, 80);
            header.TabIndex = 0;
            // 
            // hamburger
            // 
            hamburger.Image = Properties.Resources.more;
            hamburger.Location = new Point(14, 26);
            hamburger.Name = "hamburger";
            hamburger.Size = new Size(24, 24);
            hamburger.SizeMode = PictureBoxSizeMode.Zoom;
            hamburger.TabIndex = 2;
            hamburger.TabStop = false;
            hamburger.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(143, 17);
            label1.Name = "label1";
            label1.Size = new Size(187, 45);
            label1.TabIndex = 1;
            label1.Text = "AttendEase";
            // 
            // logo
            // 
            logo.Image = Properties.Resources.calendar;
            logo.Location = new Point(64, 12);
            logo.Name = "logo";
            logo.Size = new Size(73, 50);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(50, 640);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(sfButton1);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 60);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(sfButton4);
            panel3.Location = new Point(0, 60);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 60);
            panel3.TabIndex = 3;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "right-arrow.png");
            imageList1.Images.SetKeyName(1, "calendar.png");
            imageList1.Images.SetKeyName(2, "more.png");
            imageList1.Images.SetKeyName(3, "home.png");
            imageList1.Images.SetKeyName(4, "log-out.png");
            imageList1.Images.SetKeyName(5, "teacher.png");
            imageList1.Images.SetKeyName(6, "edit.png");
            imageList1.Images.SetKeyName(7, "people.png");
            // 
            // panel4
            // 
            panel4.Controls.Add(sfButton3);
            panel4.Location = new Point(0, 120);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 60);
            panel4.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(sfButton2);
            panel5.Location = new Point(0, 180);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 60);
            panel5.TabIndex = 5;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(flowLayoutPanel1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 80);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(50, 640);
            sidebar.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnLogOut);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(0, 580);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(50, 60);
            panel6.TabIndex = 3;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.ImageKey = "log-out.png";
            btnLogOut.ImageList = imageList1;
            btnLogOut.Location = new Point(0, 0);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Padding = new Padding(12, 0, 0, 0);
            btnLogOut.Size = new Size(200, 60);
            btnLogOut.TabIndex = 0;
            btnLogOut.Text = "    Log Out";
            btnLogOut.TextAlign = ContentAlignment.MiddleLeft;
            btnLogOut.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // pnlMainContent
            // 
            pnlMainContent.Anchor = AnchorStyles.None;
            pnlMainContent.BackColor = Color.White;
            pnlMainContent.Location = new Point(50, 80);
            pnlMainContent.Margin = new Padding(0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1150, 640);
            pnlMainContent.TabIndex = 3;
            // 
            // sfButton4
            // 
            sfButton4.BackColor = Color.Transparent;
            sfButton4.Dock = DockStyle.Fill;
            sfButton4.FlatStyle = FlatStyle.Flat;
            sfButton4.Font = new Font("Segoe UI Semibold", 9F);
            sfButton4.ImageAlign = ContentAlignment.MiddleLeft;
            sfButton4.ImageKey = "people.png";
            sfButton4.ImageList = imageList1;
            sfButton4.ImageMargin = new Padding(0);
            sfButton4.Location = new Point(0, 0);
            sfButton4.Margin = new Padding(0);
            sfButton4.Name = "sfButton4";
            sfButton4.Padding = new Padding(10, 0, 0, 0);
            sfButton4.Size = new Size(200, 60);
            sfButton4.Style.BackColor = Color.Transparent;
            sfButton4.TabIndex = 3;
            sfButton4.Text = "    Classes";
            sfButton4.TextAlign = ContentAlignment.MiddleLeft;
            sfButton4.UseVisualStyleBackColor = false;
            // 
            // sfButton3
            // 
            sfButton3.BackColor = Color.Transparent;
            sfButton3.Dock = DockStyle.Fill;
            sfButton3.FlatStyle = FlatStyle.Flat;
            sfButton3.Font = new Font("Segoe UI Semibold", 9F);
            sfButton3.ImageAlign = ContentAlignment.MiddleLeft;
            sfButton3.ImageKey = "edit.png";
            sfButton3.ImageList = imageList1;
            sfButton3.ImageMargin = new Padding(0);
            sfButton3.Location = new Point(0, 0);
            sfButton3.Margin = new Padding(0);
            sfButton3.Name = "sfButton3";
            sfButton3.Padding = new Padding(10, 0, 0, 0);
            sfButton3.Size = new Size(200, 60);
            sfButton3.Style.BackColor = Color.Transparent;
            sfButton3.TabIndex = 2;
            sfButton3.Text = "    Records";
            sfButton3.TextAlign = ContentAlignment.MiddleLeft;
            sfButton3.UseVisualStyleBackColor = false;
            // 
            // sfButton2
            // 
            sfButton2.BackColor = Color.Transparent;
            sfButton2.Dock = DockStyle.Fill;
            sfButton2.FlatStyle = FlatStyle.Flat;
            sfButton2.Font = new Font("Segoe UI Semibold", 9F);
            sfButton2.ImageAlign = ContentAlignment.MiddleLeft;
            sfButton2.ImageKey = "teacher.png";
            sfButton2.ImageList = imageList1;
            sfButton2.ImageMargin = new Padding(0);
            sfButton2.Location = new Point(0, 0);
            sfButton2.Margin = new Padding(0);
            sfButton2.Name = "sfButton2";
            sfButton2.Padding = new Padding(10, 0, 0, 0);
            sfButton2.Size = new Size(200, 60);
            sfButton2.Style.BackColor = Color.Transparent;
            sfButton2.TabIndex = 1;
            sfButton2.Text = "    Teacher";
            sfButton2.TextAlign = ContentAlignment.MiddleLeft;
            sfButton2.UseVisualStyleBackColor = false;
            // 
            // sfButton1
            // 
            sfButton1.BackColor = Color.Transparent;
            sfButton1.Dock = DockStyle.Fill;
            sfButton1.FlatStyle = FlatStyle.Flat;
            sfButton1.Font = new Font("Segoe UI Semibold", 9F);
            sfButton1.ImageAlign = ContentAlignment.MiddleLeft;
            sfButton1.ImageKey = "home.png";
            sfButton1.ImageList = imageList1;
            sfButton1.ImageMargin = new Padding(0);
            sfButton1.Location = new Point(0, 0);
            sfButton1.Margin = new Padding(0);
            sfButton1.Name = "sfButton1";
            sfButton1.Padding = new Padding(10, 0, 0, 0);
            sfButton1.Size = new Size(200, 60);
            sfButton1.Style.BackColor = Color.Transparent;
            sfButton1.TabIndex = 0;
            sfButton1.Text = "    Home";
            sfButton1.TextAlign = ContentAlignment.MiddleLeft;
            sfButton1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 720);
            ControlBox = false;
            Controls.Add(pnlMainContent);
            Controls.Add(sidebar);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hamburger).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Label label1;
        private PictureBox logo;
        private PictureBox hamburger;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private ImageList imageList1;
        private Panel sidebar;
        private Panel panel6;
        private Button btnLogOut;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel pnlMainContent;
        private Syncfusion.WinForms.Controls.SfButton sfButton1;
        private Syncfusion.WinForms.Controls.SfButton sfButton4;
        private Syncfusion.WinForms.Controls.SfButton sfButton3;
        private Syncfusion.WinForms.Controls.SfButton sfButton2;
    }
}
