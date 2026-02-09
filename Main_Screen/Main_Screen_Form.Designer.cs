namespace Main_Screen
{
    partial class Main_Screen_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Screen_Form));
            header = new Panel();
            hamburger = new PictureBox();
            label1 = new Label();
            logo = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            btnHome = new Syncfusion.WinForms.Controls.SfButton();
            imageList1 = new ImageList(components);
            panel3 = new Panel();
            btnClasses = new Syncfusion.WinForms.Controls.SfButton();
            panel4 = new Panel();
            btnRecords = new Syncfusion.WinForms.Controls.SfButton();
            panel5 = new Panel();
            btnTeacher = new Syncfusion.WinForms.Controls.SfButton();
            sidebar = new Panel();
            panel6 = new Panel();
            btnLogOut = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            pnlMainContent = new Panel();
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
            panel2.Controls.Add(btnHome);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 60);
            panel2.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.Dock = DockStyle.Fill;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI Semibold", 9F);
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.ImageKey = "home.png";
            btnHome.ImageList = imageList1;
            btnHome.ImageMargin = new Padding(0);
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(10, 0, 0, 0);
            btnHome.Size = new Size(200, 60);
            btnHome.Style.BackColor = Color.Transparent;
            btnHome.TabIndex = 0;
            btnHome.Text = "    Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
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
            // panel3
            // 
            panel3.Controls.Add(btnClasses);
            panel3.Location = new Point(0, 60);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 60);
            panel3.TabIndex = 3;
            // 
            // btnClasses
            // 
            btnClasses.BackColor = Color.Transparent;
            btnClasses.Dock = DockStyle.Fill;
            btnClasses.FlatStyle = FlatStyle.Flat;
            btnClasses.Font = new Font("Segoe UI Semibold", 9F);
            btnClasses.ImageAlign = ContentAlignment.MiddleLeft;
            btnClasses.ImageKey = "people.png";
            btnClasses.ImageList = imageList1;
            btnClasses.ImageMargin = new Padding(0);
            btnClasses.Location = new Point(0, 0);
            btnClasses.Margin = new Padding(0);
            btnClasses.Name = "btnClasses";
            btnClasses.Padding = new Padding(10, 0, 0, 0);
            btnClasses.Size = new Size(200, 60);
            btnClasses.Style.BackColor = Color.Transparent;
            btnClasses.TabIndex = 3;
            btnClasses.Text = "    Classes";
            btnClasses.TextAlign = ContentAlignment.MiddleLeft;
            btnClasses.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnRecords);
            panel4.Location = new Point(0, 120);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 60);
            panel4.TabIndex = 4;
            // 
            // btnRecords
            // 
            btnRecords.BackColor = Color.Transparent;
            btnRecords.Dock = DockStyle.Fill;
            btnRecords.FlatStyle = FlatStyle.Flat;
            btnRecords.Font = new Font("Segoe UI Semibold", 9F);
            btnRecords.ImageAlign = ContentAlignment.MiddleLeft;
            btnRecords.ImageKey = "edit.png";
            btnRecords.ImageList = imageList1;
            btnRecords.ImageMargin = new Padding(0);
            btnRecords.Location = new Point(0, 0);
            btnRecords.Margin = new Padding(0);
            btnRecords.Name = "btnRecords";
            btnRecords.Padding = new Padding(10, 0, 0, 0);
            btnRecords.Size = new Size(200, 60);
            btnRecords.Style.BackColor = Color.Transparent;
            btnRecords.TabIndex = 2;
            btnRecords.Text = "    Records";
            btnRecords.TextAlign = ContentAlignment.MiddleLeft;
            btnRecords.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnTeacher);
            panel5.Location = new Point(0, 180);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 60);
            panel5.TabIndex = 5;
            // 
            // btnTeacher
            // 
            btnTeacher.BackColor = Color.Transparent;
            btnTeacher.Dock = DockStyle.Fill;
            btnTeacher.FlatStyle = FlatStyle.Flat;
            btnTeacher.Font = new Font("Segoe UI Semibold", 9F);
            btnTeacher.ImageAlign = ContentAlignment.MiddleLeft;
            btnTeacher.ImageKey = "teacher.png";
            btnTeacher.ImageList = imageList1;
            btnTeacher.ImageMargin = new Padding(0);
            btnTeacher.Location = new Point(0, 0);
            btnTeacher.Margin = new Padding(0);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Padding = new Padding(10, 0, 0, 0);
            btnTeacher.Size = new Size(200, 60);
            btnTeacher.Style.BackColor = Color.Transparent;
            btnTeacher.TabIndex = 1;
            btnTeacher.Text = "    Teacher";
            btnTeacher.TextAlign = ContentAlignment.MiddleLeft;
            btnTeacher.UseVisualStyleBackColor = false;
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
            btnLogOut.Click += btnLogOut_Click;
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
            // Main_Screen_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 720);
            ControlBox = false;
            Controls.Add(pnlMainContent);
            Controls.Add(sidebar);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Screen_Form";
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
        private Syncfusion.WinForms.Controls.SfButton btnHome;
        private Syncfusion.WinForms.Controls.SfButton btnClasses;
        private Syncfusion.WinForms.Controls.SfButton btnRecords;
        private Syncfusion.WinForms.Controls.SfButton btnTeacher;
    }
}
