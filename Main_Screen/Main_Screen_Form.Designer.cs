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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Screen_Form));
            Krypton.Toolkit.KryptonCheckSet kryptonCheckSet1;
            header = new Panel();
            hamburger = new PictureBox();
            label1 = new Label();
            logo = new PictureBox();
            imageList1 = new ImageList(components);
            sidebarTimer = new System.Windows.Forms.Timer(components);
            pnlMainContent = new Panel();
            sidebar = new Krypton.Toolkit.KryptonPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnHome = new Krypton.Toolkit.KryptonCheckButton();
            ButtonPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            btnClasses = new Krypton.Toolkit.KryptonCheckButton();
            btnRecords = new Krypton.Toolkit.KryptonCheckButton();
            btnTeacher = new Krypton.Toolkit.KryptonCheckButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            CustomPanelPallete = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonCheckSet1 = new Krypton.Toolkit.KryptonCheckSet(components);
            header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hamburger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sidebar).BeginInit();
            sidebar.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonCheckSet1).BeginInit();
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
            sidebar.Controls.Add(kryptonButton1);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 80);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(50, 640);
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
            flowLayoutPanel2.Size = new Size(50, 580);
            flowLayoutPanel2.TabIndex = 2;
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
            btnClasses.Values.Text = "";
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
            btnRecords.Values.Text = "";
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
            btnTeacher.Values.Text = "";
            btnTeacher.Click += btnTeacher_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Dock = DockStyle.Bottom;
            kryptonButton1.LocalCustomPalette = ButtonPalette;
            kryptonButton1.Location = new Point(0, 580);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            kryptonButton1.Size = new Size(50, 60);
            kryptonButton1.StateCommon.Back.Color1 = Color.Transparent;
            kryptonButton1.StateCommon.Back.Color2 = Color.Transparent;
            kryptonButton1.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton1.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            kryptonButton1.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton1.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top;
            kryptonButton1.StateCommon.Border.Rounding = 3F;
            kryptonButton1.StateCommon.Border.Width = 1;
            kryptonButton1.StateCommon.Content.LongText.Color1 = Color.FromArgb(223, 58, 58);
            kryptonButton1.StateCommon.Content.Padding = new Padding(9, 0, 0, 0);
            kryptonButton1.StateCommon.Content.ShortText.Color1 = Color.FromArgb(223, 58, 58);
            kryptonButton1.StateNormal.Back.Color1 = Color.Transparent;
            kryptonButton1.StateTracking.Back.Color1 = Color.FromArgb(246, 231, 231);
            kryptonButton1.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            kryptonButton1.TabIndex = 1;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.ExtraText = "Logout";
            kryptonButton1.Values.Text = "";
            kryptonButton1.Click += btnLogOut_Click;
            // 
            // CustomPanelPallete
            // 
            CustomPanelPallete.Common.StateCommon.Back.Color1 = Color.White;
            CustomPanelPallete.Common.StateCommon.Border.Color1 = Color.FromArgb(224, 230, 235);
            CustomPanelPallete.Common.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Right;
            CustomPanelPallete.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // kryptonCheckSet1
            // 
            kryptonCheckSet1.CheckButtons.Add(btnHome);
            kryptonCheckSet1.CheckButtons.Add(btnClasses);
            kryptonCheckSet1.CheckButtons.Add(btnRecords);
            kryptonCheckSet1.CheckButtons.Add(btnTeacher);
            kryptonCheckSet1.CheckedButtonChanged += btnHome_Click;
            // 
            // Main_Screen_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 720);
            ControlBox = false;
            Controls.Add(sidebar);
            Controls.Add(pnlMainContent);
            Controls.Add(header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Screen_Form";
            StartPosition = FormStartPosition.CenterScreen;
            header.ResumeLayout(false);
            header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hamburger).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)sidebar).EndInit();
            sidebar.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonCheckSet1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Label label1;
        private PictureBox logo;
        private PictureBox hamburger;
        private ImageList imageList1;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel pnlMainContent;
        private Krypton.Toolkit.KryptonPanel sidebar;
        private Krypton.Toolkit.KryptonCustomPaletteBase CustomPanelPallete;
        private FlowLayoutPanel flowLayoutPanel2;
        private Krypton.Toolkit.KryptonCheckButton btnHome;
        private Krypton.Toolkit.KryptonCheckButton btnClasses;
        private Krypton.Toolkit.KryptonCheckButton btnRecords;
        private Krypton.Toolkit.KryptonCheckButton btnTeacher;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonCustomPaletteBase ButtonPalette;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSet1;
    }
}
