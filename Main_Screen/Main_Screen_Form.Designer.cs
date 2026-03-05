namespace AE.Application
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
            Krypton.Toolkit.KryptonCheckSet kryptonCheckSet1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Screen_Form));
            btnHome = new Krypton.Toolkit.KryptonCheckButton();
            ButtonPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            btnClasses = new Krypton.Toolkit.KryptonCheckButton();
            btnRecords = new Krypton.Toolkit.KryptonCheckButton();
            btnTeacher = new Krypton.Toolkit.KryptonCheckButton();
            imageList1 = new ImageList(components);
            sidebarTimer = new System.Windows.Forms.Timer(components);
            pnlMainContent = new Panel();
            sidebar = new Krypton.Toolkit.KryptonPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnLogout = new Krypton.Toolkit.KryptonButton();
            kryptonBorderEdge2 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            btnMenu = new Krypton.Toolkit.KryptonButton();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            kryptonCheckSet1 = new Krypton.Toolkit.KryptonCheckSet(components);
            ((System.ComponentModel.ISupportInitialize)kryptonCheckSet1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sidebar).BeginInit();
            sidebar.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonCheckSet1
            // 
            kryptonCheckSet1.CheckButtons.Add(btnHome);
            kryptonCheckSet1.CheckButtons.Add(btnClasses);
            kryptonCheckSet1.CheckButtons.Add(btnRecords);
            kryptonCheckSet1.CheckButtons.Add(btnTeacher);
            kryptonCheckSet1.CheckedButtonChanged += btnHome_Click;
            // 
            // btnHome
            // 
            btnHome.LocalCustomPalette = ButtonPalette;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnHome.Size = new Size(200, 60);
            btnHome.StateTracking.Back.Color1 = Color.FromArgb(240, 247, 246);
            btnHome.TabIndex = 1;
            btnHome.Values.DropDownArrowColor = Color.Empty;
            btnHome.Values.ExtraText = "Home";
            btnHome.Values.Text = "";
            btnHome.Click += btnHome_Click;
            // 
            // ButtonPalette
            // 
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color1 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color2 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Color1 = Color.Transparent;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Rounding = 3F;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Width = 1;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.LongText.Color1 = Color.FromArgb(39, 165, 153);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Color1 = Color.FromArgb(39, 165, 153);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.AdjacentGap = 12;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.LongText.Color1 = Color.FromArgb(63, 63, 70);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.Padding = new Padding(8, 8, 12, 8);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Color1 = Color.FromArgb(63, 63, 70);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Back.Color1 = Color.FromArgb(223, 246, 244);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Back.Color2 = Color.FromArgb(223, 246, 244);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Border.Rounding = 3F;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Content.LongText.Color1 = Color.FromArgb(29, 37, 48);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Content.LongText.Color2 = Color.FromArgb(29, 37, 48);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            ButtonPalette.Common.StateCommon.Back.Color1 = Color.Transparent;
            ButtonPalette.Common.StateCommon.Content.LongText.Color1 = Color.FromArgb(63, 63, 70);
            ButtonPalette.Common.StateCommon.Content.ShortText.Color1 = Color.FromArgb(63, 63, 70);
            ButtonPalette.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // btnClasses
            // 
            btnClasses.LocalCustomPalette = ButtonPalette;
            btnClasses.Location = new Point(0, 60);
            btnClasses.Margin = new Padding(0);
            btnClasses.Name = "btnClasses";
            btnClasses.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnClasses.Size = new Size(200, 60);
            btnClasses.TabIndex = 2;
            btnClasses.Values.DropDownArrowColor = Color.Empty;
            btnClasses.Values.ExtraText = "Classes";
            btnClasses.Values.Text = "";
            btnClasses.Click += btnClasses_Click;
            // 
            // btnRecords
            // 
            btnRecords.LocalCustomPalette = ButtonPalette;
            btnRecords.Location = new Point(0, 120);
            btnRecords.Margin = new Padding(0);
            btnRecords.Name = "btnRecords";
            btnRecords.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnRecords.Size = new Size(200, 60);
            btnRecords.TabIndex = 3;
            btnRecords.Values.DropDownArrowColor = Color.Empty;
            btnRecords.Values.ExtraText = "Records";
            btnRecords.Values.Text = "";
            btnRecords.Click += btnRecords_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.LocalCustomPalette = ButtonPalette;
            btnTeacher.Location = new Point(0, 180);
            btnTeacher.Margin = new Padding(0);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnTeacher.Size = new Size(200, 60);
            btnTeacher.TabIndex = 4;
            btnTeacher.Values.DropDownArrowColor = Color.Empty;
            btnTeacher.Values.ExtraText = "Teacher";
            btnTeacher.Values.Text = "";
            btnTeacher.Click += btnTeacher_Click;
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
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = Color.White;
            pnlMainContent.Location = new Point(50, 80);
            pnlMainContent.Margin = new Padding(0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1150, 640);
            pnlMainContent.TabIndex = 3;
            // 
            // sidebar
            // 
            sidebar.Controls.Add(flowLayoutPanel2);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(kryptonBorderEdge2);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 80);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(55, 640);
            sidebar.StateCommon.Color1 = Color.FromArgb(250, 250, 250);
            sidebar.StateCommon.Color2 = Color.FromArgb(250, 250, 250);
            sidebar.StateCommon.Draw = Krypton.Toolkit.InheritBool.True;
            sidebar.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Controls.Add(btnHome);
            flowLayoutPanel2.Controls.Add(btnClasses);
            flowLayoutPanel2.Controls.Add(btnRecords);
            flowLayoutPanel2.Controls.Add(btnTeacher);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(53, 580);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.LocalCustomPalette = ButtonPalette;
            btnLogout.Location = new Point(0, 580);
            btnLogout.Name = "btnLogout";
            btnLogout.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnLogout.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnLogout.Size = new Size(53, 60);
            btnLogout.StateCommon.Back.Color1 = Color.Transparent;
            btnLogout.StateCommon.Back.Color2 = Color.Transparent;
            btnLogout.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnLogout.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnLogout.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLogout.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top;
            btnLogout.StateCommon.Border.Rounding = 3F;
            btnLogout.StateCommon.Border.Width = 2;
            btnLogout.StateCommon.Content.LongText.Color1 = Color.FromArgb(223, 58, 58);
            btnLogout.StateCommon.Content.Padding = new Padding(9, 0, 0, 0);
            btnLogout.StateCommon.Content.ShortText.Color1 = Color.FromArgb(223, 58, 58);
            btnLogout.StateNormal.Back.Color1 = Color.Transparent;
            btnLogout.StateNormal.Border.Color1 = Color.FromArgb(224, 230, 235);
            btnLogout.StateNormal.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLogout.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top;
            btnLogout.StateNormal.Border.Width = 2;
            btnLogout.StateTracking.Back.Color1 = Color.FromArgb(246, 231, 231);
            btnLogout.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnLogout.TabIndex = 5;
            btnLogout.Values.DropDownArrowColor = Color.Empty;
            btnLogout.Values.ExtraText = "Logout";
            btnLogout.Values.Text = "";
            btnLogout.Click += btnLogOut_Click;
            // 
            // kryptonBorderEdge2
            // 
            kryptonBorderEdge2.AutoSize = false;
            kryptonBorderEdge2.Dock = DockStyle.Right;
            kryptonBorderEdge2.Location = new Point(53, 0);
            kryptonBorderEdge2.Name = "kryptonBorderEdge2";
            kryptonBorderEdge2.Size = new Size(2, 640);
            kryptonBorderEdge2.StateCommon.Color1 = Color.FromArgb(224, 230, 235);
            kryptonBorderEdge2.StateCommon.Width = 2;
            kryptonBorderEdge2.Text = "kryptonBorderEdge2";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonBorderEdge1);
            kryptonPanel1.Controls.Add(btnMenu);
            kryptonPanel1.Controls.Add(pictureBox1);
            kryptonPanel1.Controls.Add(label2);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1200, 80);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(249, 250, 251);
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Dock = DockStyle.Bottom;
            kryptonBorderEdge1.Location = new Point(0, 78);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(1200, 2);
            kryptonBorderEdge1.StateCommon.Color1 = Color.FromArgb(224, 230, 235);
            kryptonBorderEdge1.StateCommon.Width = 2;
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // btnMenu
            // 
            btnMenu.LocalCustomPalette = ButtonPalette;
            btnMenu.Location = new Point(3, 18);
            btnMenu.Name = "btnMenu";
            btnMenu.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnMenu.Size = new Size(47, 44);
            btnMenu.StateCommon.Content.Padding = new Padding(3);
            btnMenu.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.TabIndex = 4;
            btnMenu.Values.DropDownArrowColor = Color.Empty;
            btnMenu.Values.Text = "";
            btnMenu.Click += btnMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.calendar;
            pictureBox1.Location = new Point(61, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.Location = new Point(149, 17);
            label2.Name = "label2";
            label2.Size = new Size(187, 45);
            label2.TabIndex = 3;
            label2.Text = "AttendEase";
            // 
            // Main_Screen_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 720);
            CloseBox = false;
            ControlBox = false;
            Controls.Add(sidebar);
            Controls.Add(pnlMainContent);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main_Screen_Form";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)kryptonCheckSet1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sidebar).EndInit();
            sidebar.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel pnlMainContent;
        private Krypton.Toolkit.KryptonPanel sidebar;
        private FlowLayoutPanel flowLayoutPanel2;
        private Krypton.Toolkit.KryptonCheckButton btnHome;
        private Krypton.Toolkit.KryptonCheckButton btnClasses;
        private Krypton.Toolkit.KryptonCheckButton btnRecords;
        private Krypton.Toolkit.KryptonCheckButton btnTeacher;
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Krypton.Toolkit.KryptonCustomPaletteBase ButtonPalette;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSet1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Krypton.Toolkit.KryptonButton btnMenu;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
    }
}
