using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Brevi.Application
{
    partial class MainScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreenForm));
            btnHome = new Krypton.Toolkit.KryptonCheckButton();
            ButtonPalette = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            btnClasses = new Krypton.Toolkit.KryptonCheckButton();
            btnRecords = new Krypton.Toolkit.KryptonCheckButton();
            btnTeacher = new Krypton.Toolkit.KryptonCheckButton();
            btnSettings = new Krypton.Toolkit.KryptonCheckButton();
            imageList1 = new ImageList(components);
            sidebarTimer = new System.Windows.Forms.Timer(components);
            pnlMainContent = new Panel();
            sidebar = new Krypton.Toolkit.KryptonPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnLogout = new Krypton.Toolkit.KryptonButton();
            kryptonBorderEdge2 = new Krypton.Toolkit.KryptonBorderEdge();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnCollapse = new Krypton.Toolkit.KryptonButton();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            pictureBox1 = new PictureBox();
            kryptonBorderEdge1 = new Krypton.Toolkit.KryptonBorderEdge();
            btnMenu = new Krypton.Toolkit.KryptonButton();
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
            kryptonCheckSet1.CheckButtons.Add(btnSettings);
            kryptonCheckSet1.CheckedButtonChanged += btnHome_Click;
            // 
            // btnHome
            // 
            btnHome.LocalCustomPalette = ButtonPalette;
            btnHome.Location = new Point(4, 5);
            btnHome.Margin = new Padding(0, 5, 0, 5);
            btnHome.Name = "btnHome";
            btnHome.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnHome.Size = new Size(44, 40);
            btnHome.StateTracking.Back.Color1 = Color.FromArgb(240, 247, 246);
            btnHome.TabIndex = 1;
            btnHome.Values.DropDownArrowColor = Color.Empty;
            btnHome.Values.ExtraText = "Home";
            btnHome.Values.Text = "";
            btnHome.Click += btnHome_Click;
            // 
            // ButtonPalette
            // 
            ButtonPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Back.Color1 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Back.Color2 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Border.Color1 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Border.Color2 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.OverrideFocus.Border.Rounding = 5F;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color1 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color2 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Color1 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Color2 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Rounding = 5F;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Width = 1;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.LongText.Color1 = Color.FromArgb(39, 165, 153);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.Padding = new Padding(0);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Color1 = Color.FromArgb(39, 165, 153);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Color1 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Color2 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Color1 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Color2 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Rounding = 5F;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Width = 1;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.LongText.Color1 = Color.FromArgb(39, 165, 153);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.Padding = new Padding(0);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Color1 = Color.FromArgb(39, 165, 153);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Color1 = Color.FromArgb(226, 239, 237);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Color2 = Color.FromArgb(226, 239, 237);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Color1 = Color.FromArgb(226, 239, 237);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Color2 = Color.FromArgb(226, 239, 237);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Rounding = 5F;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Width = 1;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.LongText.Color1 = Color.FromArgb(29, 37, 48);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Color1 = Color.FromArgb(250, 250, 250);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Color2 = Color.FromArgb(250, 250, 250);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Rounding = 5F;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Width = 1;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.AdjacentGap = 12;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.LongText.Color1 = Color.FromArgb(63, 63, 70);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.LongText.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.LongText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.Padding = new Padding(0);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Color1 = Color.FromArgb(63, 63, 70);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            ButtonPalette.ButtonStyles.ButtonStandalone.StatePressed.Back.Color1 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StatePressed.Back.Color2 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StatePressed.Back.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StatePressed.Border.Color1 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StatePressed.Border.Color2 = Color.FromArgb(229, 242, 240);
            ButtonPalette.ButtonStyles.ButtonStandalone.StatePressed.Border.Rounding = 5F;
            ButtonPalette.ButtonStyles.ButtonStandalone.StatePressed.Border.Width = 1;
            ButtonPalette.ButtonStyles.ButtonStandalone.StatePressed.Content.LongText.Color1 = Color.FromArgb(39, 165, 153);
            ButtonPalette.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Color1 = Color.FromArgb(39, 165, 153);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Back.Color1 = Color.FromArgb(223, 246, 244);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Back.Color2 = Color.FromArgb(223, 246, 244);
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Back.Draw = Krypton.Toolkit.InheritBool.True;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Border.Rounding = 5F;
            ButtonPalette.ButtonStyles.ButtonStandalone.StateTracking.Border.Width = 1;
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
            btnClasses.Location = new Point(4, 55);
            btnClasses.Margin = new Padding(0, 5, 0, 5);
            btnClasses.Name = "btnClasses";
            btnClasses.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnClasses.Size = new Size(44, 40);
            btnClasses.TabIndex = 2;
            btnClasses.Values.DropDownArrowColor = Color.Empty;
            btnClasses.Values.ExtraText = "Classes";
            btnClasses.Values.Text = "";
            btnClasses.Click += btnClasses_Click;
            // 
            // btnRecords
            // 
            btnRecords.LocalCustomPalette = ButtonPalette;
            btnRecords.Location = new Point(4, 105);
            btnRecords.Margin = new Padding(0, 5, 0, 5);
            btnRecords.Name = "btnRecords";
            btnRecords.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnRecords.Size = new Size(44, 40);
            btnRecords.TabIndex = 3;
            btnRecords.Values.DropDownArrowColor = Color.Empty;
            btnRecords.Values.ExtraText = "Records";
            btnRecords.Values.Text = "";
            btnRecords.Click += btnRecords_Click;
            // 
            // btnTeacher
            // 
            btnTeacher.LocalCustomPalette = ButtonPalette;
            btnTeacher.Location = new Point(4, 155);
            btnTeacher.Margin = new Padding(0, 5, 0, 5);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnTeacher.Size = new Size(44, 40);
            btnTeacher.TabIndex = 4;
            btnTeacher.Values.DropDownArrowColor = Color.Empty;
            btnTeacher.Values.ExtraText = "Teacher";
            btnTeacher.Values.Text = "";
            btnTeacher.Click += btnTeacher_Click;
            // 
            // btnSettings
            // 
            btnSettings.LocalCustomPalette = ButtonPalette;
            btnSettings.Location = new Point(4, 205);
            btnSettings.Margin = new Padding(0, 5, 0, 5);
            btnSettings.Name = "btnSettings";
            btnSettings.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnSettings.Size = new Size(44, 40);
            btnSettings.TabIndex = 5;
            btnSettings.Values.DropDownArrowColor = Color.Empty;
            btnSettings.Values.ExtraText = "Settings";
            btnSettings.Values.Text = "";
            btnSettings.Click += btnSettings_Click;
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
            pnlMainContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlMainContent.BackColor = Color.White;
            pnlMainContent.Location = new Point(55, 60);
            pnlMainContent.Margin = new Padding(0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1145, 660);
            pnlMainContent.TabIndex = 3;
            pnlMainContent.Paint += pnlMainContent_Paint;
            // 
            // sidebar
            // 
            sidebar.Controls.Add(flowLayoutPanel2);
            sidebar.Controls.Add(btnLogout);
            sidebar.Controls.Add(kryptonBorderEdge2);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 60);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(55, 630);
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
            flowLayoutPanel2.Controls.Add(btnSettings);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(4, 0, 0, 0);
            flowLayoutPanel2.Size = new Size(53, 570);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.LocalCustomPalette = ButtonPalette;
            btnLogout.Location = new Point(0, 570);
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
            kryptonBorderEdge2.Size = new Size(2, 630);
            kryptonBorderEdge2.StateCommon.Color1 = Color.FromArgb(224, 230, 235);
            kryptonBorderEdge2.StateCommon.Width = 2;
            kryptonBorderEdge2.Text = "kryptonBorderEdge2";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnCollapse);
            kryptonPanel1.Controls.Add(kryptonButton1);
            kryptonPanel1.Controls.Add(kryptonButton2);
            kryptonPanel1.Controls.Add(pictureBox1);
            kryptonPanel1.Controls.Add(kryptonBorderEdge1);
            kryptonPanel1.Controls.Add(btnMenu);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1200, 60);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(249, 250, 251);
            kryptonPanel1.TabIndex = 0;
            // 
            // btnCollapse
            // 
            btnCollapse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCollapse.Location = new Point(1104, 12);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.OverrideDefault.Back.Color1 = Color.Transparent;
            btnCollapse.OverrideDefault.Back.Color2 = Color.Transparent;
            btnCollapse.OverrideFocus.Back.Color1 = Color.Transparent;
            btnCollapse.OverrideFocus.Back.Color2 = Color.Transparent;
            btnCollapse.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnCollapse.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnCollapse.Size = new Size(24, 24);
            btnCollapse.StateCommon.Back.Color1 = Color.Transparent;
            btnCollapse.StateCommon.Back.Color2 = Color.Transparent;
            btnCollapse.StateCommon.Border.Color1 = Color.Transparent;
            btnCollapse.StateCommon.Border.Color2 = Color.Transparent;
            btnCollapse.TabIndex = 6;
            btnCollapse.Values.DropDownArrowColor = Color.Empty;
            btnCollapse.Values.Image = Properties.Resources.green_circle;
            btnCollapse.Values.Text = "";
            btnCollapse.Click += btnMinimize_Click;
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonButton1.Location = new Point(1134, 12);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.OverrideDefault.Back.Color1 = Color.Transparent;
            kryptonButton1.OverrideDefault.Back.Color2 = Color.Transparent;
            kryptonButton1.OverrideFocus.Back.Color1 = Color.Transparent;
            kryptonButton1.OverrideFocus.Back.Color2 = Color.Transparent;
            kryptonButton1.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton1.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton1.Size = new Size(24, 24);
            kryptonButton1.StateCommon.Back.Color1 = Color.Transparent;
            kryptonButton1.StateCommon.Back.Color2 = Color.Transparent;
            kryptonButton1.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButton1.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButton1.TabIndex = 5;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Image = Properties.Resources.yellow_circle;
            kryptonButton1.Values.Text = "";
            kryptonButton1.Click += btnMaximize_Click;
            // 
            // kryptonButton2
            // 
            kryptonButton2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            kryptonButton2.Location = new Point(1164, 12);
            kryptonButton2.Name = "kryptonButton2";
            kryptonButton2.OverrideDefault.Back.Color1 = Color.Transparent;
            kryptonButton2.OverrideDefault.Back.Color2 = Color.Transparent;
            kryptonButton2.OverrideFocus.Back.Color1 = Color.Transparent;
            kryptonButton2.OverrideFocus.Back.Color2 = Color.Transparent;
            kryptonButton2.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton2.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton2.Size = new Size(24, 24);
            kryptonButton2.StateCommon.Back.Color1 = Color.Transparent;
            kryptonButton2.StateCommon.Back.Color2 = Color.Transparent;
            kryptonButton2.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButton2.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButton2.TabIndex = 4;
            kryptonButton2.Values.DropDownArrowColor = Color.Empty;
            kryptonButton2.Values.Image = Properties.Resources.red_circle;
            kryptonButton2.Values.Text = "";
            kryptonButton2.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo_Name_only_removedBg;
            pictureBox1.Location = new Point(53, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // kryptonBorderEdge1
            // 
            kryptonBorderEdge1.Dock = DockStyle.Bottom;
            kryptonBorderEdge1.Location = new Point(0, 58);
            kryptonBorderEdge1.Name = "kryptonBorderEdge1";
            kryptonBorderEdge1.Size = new Size(1200, 2);
            kryptonBorderEdge1.StateCommon.Color1 = Color.FromArgb(224, 230, 235);
            kryptonBorderEdge1.StateCommon.Width = 2;
            kryptonBorderEdge1.Text = "kryptonBorderEdge1";
            // 
            // btnMenu
            // 
            btnMenu.LocalCustomPalette = ButtonPalette;
            btnMenu.Location = new Point(4, 9);
            btnMenu.Name = "btnMenu";
            btnMenu.OverrideDefault.Border.Color1 = Color.Transparent;
            btnMenu.OverrideDefault.Border.Color2 = Color.Transparent;
            btnMenu.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnMenu.OverrideDefault.Border.Rounding = 5F;
            btnMenu.OverrideDefault.Border.Width = 1;
            btnMenu.OverrideDefault.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnMenu.OverrideDefault.Content.Padding = new Padding(0);
            btnMenu.OverrideFocus.Border.Color1 = Color.Transparent;
            btnMenu.OverrideFocus.Border.Color2 = Color.Transparent;
            btnMenu.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnMenu.OverrideFocus.Border.Rounding = 5F;
            btnMenu.OverrideFocus.Border.Width = 1;
            btnMenu.OverrideFocus.Content.Draw = Krypton.Toolkit.InheritBool.True;
            btnMenu.OverrideFocus.Content.Padding = new Padding(0);
            btnMenu.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnMenu.Size = new Size(47, 42);
            btnMenu.StateCommon.Content.Padding = new Padding(0, 3, 3, 3);
            btnMenu.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.TabIndex = 4;
            btnMenu.Values.DropDownArrowColor = Color.Empty;
            btnMenu.Values.Text = "";
            btnMenu.Click += btnMenu_Click;
            // 
            // MainScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 690);
            ControlBox = false;
            Controls.Add(sidebar);
            Controls.Add(kryptonPanel1);
            Controls.Add(pnlMainContent);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainScreenForm";
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
        private Krypton.Toolkit.KryptonButton btnLogout;
        private Krypton.Toolkit.KryptonCustomPaletteBase ButtonPalette;
        private Krypton.Toolkit.KryptonCheckSet kryptonCheckSet1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnMenu;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge1;
        private Krypton.Toolkit.KryptonBorderEdge kryptonBorderEdge2;
        private Krypton.Toolkit.KryptonCheckButton btnTeacher;
        private Krypton.Toolkit.KryptonCheckButton btnSettings;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton btnCollapse;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
    }
}
