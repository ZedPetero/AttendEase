namespace Brevi.Application
{
    partial class LoginFormUser
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnCollapse = new Krypton.Toolkit.KryptonButton();
            btnMaximize = new Krypton.Toolkit.KryptonButton();
            btnClose = new Krypton.Toolkit.KryptonButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            pictureBox1 = new PictureBox();
            btnAboutUs = new Krypton.Toolkit.KryptonButton();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            lightModePallete = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            btnSignUp = new Krypton.Toolkit.KryptonButton();
            pnlMainContent = new Panel();
            darkModePallete = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnCollapse);
            kryptonPanel1.Controls.Add(btnMaximize);
            kryptonPanel1.Controls.Add(btnClose);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1184, 32);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(39, 165, 153);
            kryptonPanel1.TabIndex = 0;
            // 
            // btnCollapse
            // 
            btnCollapse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCollapse.Cursor = Cursors.Hand;
            btnCollapse.Location = new Point(1091, 4);
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
            btnCollapse.TabIndex = 5;
            btnCollapse.Values.DropDownArrowColor = Color.Empty;
            btnCollapse.Values.Image = Properties.Resources.green_circle;
            btnCollapse.Values.Text = "";
            btnCollapse.Click += btnCollapse_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.Location = new Point(1121, 4);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.OverrideDefault.Back.Color1 = Color.Transparent;
            btnMaximize.OverrideDefault.Back.Color2 = Color.Transparent;
            btnMaximize.OverrideFocus.Back.Color1 = Color.Transparent;
            btnMaximize.OverrideFocus.Back.Color2 = Color.Transparent;
            btnMaximize.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnMaximize.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnMaximize.Size = new Size(24, 24);
            btnMaximize.StateCommon.Back.Color1 = Color.Transparent;
            btnMaximize.StateCommon.Back.Color2 = Color.Transparent;
            btnMaximize.StateCommon.Border.Color1 = Color.Transparent;
            btnMaximize.StateCommon.Border.Color2 = Color.Transparent;
            btnMaximize.TabIndex = 4;
            btnMaximize.Values.DropDownArrowColor = Color.Empty;
            btnMaximize.Values.Image = Properties.Resources.yellow_circle;
            btnMaximize.Values.Text = "";
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(1151, 4);
            btnClose.Name = "btnClose";
            btnClose.OverrideDefault.Back.Color1 = Color.Transparent;
            btnClose.OverrideDefault.Back.Color2 = Color.Transparent;
            btnClose.OverrideFocus.Back.Color1 = Color.Transparent;
            btnClose.OverrideFocus.Back.Color2 = Color.Transparent;
            btnClose.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnClose.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnClose.Size = new Size(24, 24);
            btnClose.StateCommon.Back.Color1 = Color.Transparent;
            btnClose.StateCommon.Back.Color2 = Color.Transparent;
            btnClose.StateCommon.Border.Color1 = Color.Transparent;
            btnClose.StateCommon.Border.Color2 = Color.Transparent;
            btnClose.TabIndex = 3;
            btnClose.Values.DropDownArrowColor = Color.Empty;
            btnClose.Values.Image = Properties.Resources.red_circle;
            btnClose.Values.Text = "";
            btnClose.Click += btnClose_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(pictureBox1);
            kryptonPanel2.Controls.Add(btnAboutUs);
            kryptonPanel2.Controls.Add(btnLogin);
            kryptonPanel2.Controls.Add(btnSignUp);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(0, 32);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1184, 50);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = Properties.Resources.Logo_Name_only_removedBg;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(54, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnAboutUs
            // 
            btnAboutUs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAboutUs.Cursor = Cursors.Hand;
            btnAboutUs.Location = new Point(811, 9);
            btnAboutUs.Name = "btnAboutUs";
            btnAboutUs.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnAboutUs.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnAboutUs.OverrideFocus.Back.Color1 = Color.FromArgb(229, 242, 240);
            btnAboutUs.OverrideFocus.Back.Color2 = Color.FromArgb(229, 242, 240);
            btnAboutUs.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnAboutUs.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnAboutUs.OverrideFocus.Content.LongText.Color1 = Color.FromArgb(29, 37, 48);
            btnAboutUs.OverrideFocus.Content.LongText.Color2 = Color.FromArgb(29, 37, 48);
            btnAboutUs.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnAboutUs.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            btnAboutUs.Size = new Size(110, 32);
            btnAboutUs.StateCommon.Back.Color1 = Color.White;
            btnAboutUs.StateCommon.Back.Color2 = Color.White;
            btnAboutUs.StateCommon.Border.Color1 = Color.White;
            btnAboutUs.StateCommon.Border.Color2 = Color.White;
            btnAboutUs.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnAboutUs.StateCommon.Border.Rounding = 10F;
            btnAboutUs.StateCommon.Content.LongText.Color1 = Color.FromArgb(29, 37, 48);
            btnAboutUs.StateCommon.Content.LongText.Color2 = Color.FromArgb(29, 37, 48);
            btnAboutUs.StateCommon.Content.LongText.Font = new Font("Inter", 9.75F);
            btnAboutUs.StateCommon.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnAboutUs.StateCommon.Content.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            btnAboutUs.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 15.7499981F);
            btnAboutUs.StateNormal.Back.Color1 = Color.White;
            btnAboutUs.StateNormal.Back.Color2 = Color.White;
            btnAboutUs.StateNormal.Border.Color1 = Color.White;
            btnAboutUs.StateNormal.Border.Color2 = Color.White;
            btnAboutUs.StateNormal.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnAboutUs.StateNormal.Content.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            btnAboutUs.StatePressed.Back.Color1 = Color.FromArgb(209, 222, 220);
            btnAboutUs.StatePressed.Back.Color2 = Color.FromArgb(209, 222, 220);
            btnAboutUs.StatePressed.Border.Color1 = Color.Transparent;
            btnAboutUs.StatePressed.Border.Color2 = Color.Transparent;
            btnAboutUs.StatePressed.Content.LongText.Color1 = Color.FromArgb(29, 37, 48);
            btnAboutUs.StatePressed.Content.LongText.Color2 = Color.FromArgb(29, 37, 48);
            btnAboutUs.StatePressed.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnAboutUs.StatePressed.Content.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            btnAboutUs.StateTracking.Back.Color1 = Color.FromArgb(239, 252, 250);
            btnAboutUs.StateTracking.Border.Color1 = Color.Transparent;
            btnAboutUs.StateTracking.Border.Color2 = Color.Transparent;
            btnAboutUs.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnAboutUs.TabIndex = 2;
            btnAboutUs.Values.DropDownArrowColor = Color.Empty;
            btnAboutUs.Values.ExtraText = "About Us";
            btnAboutUs.Values.Text = "";
            btnAboutUs.Click += btnAboutUs_Click;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogin.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.LocalCustomPalette = lightModePallete;
            btnLogin.Location = new Point(943, 9);
            btnLogin.Name = "btnLogin";
            btnLogin.OverrideDefault.Back.Color1 = Color.FromArgb(229, 242, 240);
            btnLogin.OverrideDefault.Back.Color2 = Color.FromArgb(229, 242, 240);
            btnLogin.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnLogin.OverrideDefault.Border.Color1 = Color.White;
            btnLogin.OverrideDefault.Border.Color2 = Color.White;
            btnLogin.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnLogin.OverrideFocus.Back.Color1 = Color.FromArgb(229, 242, 240);
            btnLogin.OverrideFocus.Back.Color2 = Color.FromArgb(229, 242, 240);
            btnLogin.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.True;
            btnLogin.OverrideFocus.Border.Color1 = Color.White;
            btnLogin.OverrideFocus.Border.Color2 = Color.White;
            btnLogin.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnLogin.OverrideFocus.Content.LongText.Color1 = Color.FromArgb(29, 37, 48);
            btnLogin.OverrideFocus.Content.LongText.Color2 = Color.FromArgb(29, 37, 48);
            btnLogin.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnLogin.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            btnLogin.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            btnLogin.Size = new Size(79, 32);
            btnLogin.StateCommon.Back.Color1 = Color.FromArgb(39, 165, 153);
            btnLogin.StateCommon.Back.Color2 = Color.FromArgb(39, 165, 153);
            btnLogin.StateCommon.Border.Color1 = Color.White;
            btnLogin.StateCommon.Border.Color2 = Color.White;
            btnLogin.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLogin.StateCommon.Border.Rounding = 5F;
            btnLogin.StateCommon.Content.LongText.Color1 = Color.White;
            btnLogin.StateCommon.Content.LongText.Color2 = Color.White;
            btnLogin.StateCommon.Content.LongText.Font = new Font("Inter", 9F, FontStyle.Bold);
            btnLogin.StateCommon.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnLogin.StateCommon.Content.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            btnLogin.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 15.7499981F);
            btnLogin.StateNormal.Back.Color1 = Color.FromArgb(39, 165, 153);
            btnLogin.StateNormal.Back.Color2 = Color.FromArgb(39, 165, 153);
            btnLogin.StateNormal.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnLogin.StateNormal.Content.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            btnLogin.StatePressed.Back.Color1 = Color.FromArgb(209, 222, 220);
            btnLogin.StatePressed.Back.Color2 = Color.FromArgb(209, 222, 220);
            btnLogin.StatePressed.Border.Color1 = Color.DarkGray;
            btnLogin.StatePressed.Border.Color2 = Color.DarkGray;
            btnLogin.StatePressed.Content.LongText.Color1 = Color.FromArgb(29, 37, 48);
            btnLogin.StatePressed.Content.LongText.Color2 = Color.FromArgb(29, 37, 48);
            btnLogin.StatePressed.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            btnLogin.StatePressed.Content.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            btnLogin.StateTracking.Back.Color1 = Color.FromArgb(239, 252, 250);
            btnLogin.StateTracking.Back.Color2 = Color.FromArgb(239, 252, 250);
            btnLogin.StateTracking.Border.Color1 = Color.Transparent;
            btnLogin.StateTracking.Border.Color2 = Color.Transparent;
            btnLogin.StateTracking.Border.Draw = Krypton.Toolkit.InheritBool.True;
            btnLogin.TabIndex = 1;
            btnLogin.Values.DropDownArrowColor = Color.Empty;
            btnLogin.Values.ExtraText = "Login";
            btnLogin.Values.Text = "";
            btnLogin.Click += btnLogin_Click;
            // 
            // lightModePallete
            // 
            lightModePallete.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = Color.FromArgb(229, 242, 240);
            lightModePallete.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = Color.FromArgb(229, 242, 240);
            lightModePallete.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color1 = Color.White;
            lightModePallete.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color2 = Color.White;
            lightModePallete.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color1 = Color.FromArgb(229, 242, 240);
            lightModePallete.ButtonStyles.ButtonCustom1.OverrideFocus.Back.Color2 = Color.FromArgb(229, 242, 240);
            lightModePallete.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Color1 = Color.White;
            lightModePallete.ButtonStyles.ButtonCustom1.OverrideFocus.Border.Color2 = Color.White;
            lightModePallete.ButtonStyles.ButtonCustom1.OverrideFocus.Content.LongText.Color1 = Color.FromArgb(29, 37, 48);
            lightModePallete.ButtonStyles.ButtonCustom1.OverrideFocus.Content.LongText.Color2 = Color.FromArgb(29, 37, 48);
            lightModePallete.ButtonStyles.ButtonCustom1.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            lightModePallete.ButtonStyles.ButtonCustom1.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            lightModePallete.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = Color.FromArgb(39, 165, 153);
            lightModePallete.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = Color.FromArgb(39, 165, 153);
            lightModePallete.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = Color.White;
            lightModePallete.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = Color.White;
            lightModePallete.ButtonStyles.ButtonCustom1.StateCommon.Border.Rounding = 5F;
            lightModePallete.ButtonStyles.ButtonCustom1.StateCommon.Content.LongText.Font = new Font("Inter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lightModePallete.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lightModePallete.ButtonStyles.ButtonCustom1.StateNormal.Back.Color1 = Color.FromArgb(39, 165, 153);
            lightModePallete.ButtonStyles.ButtonCustom1.StateNormal.Back.Color2 = Color.FromArgb(39, 165, 153);
            lightModePallete.ButtonStyles.ButtonCustom1.StatePressed.Back.Color1 = Color.FromArgb(209, 222, 220);
            lightModePallete.ButtonStyles.ButtonCustom1.StatePressed.Back.Color2 = Color.FromArgb(209, 222, 220);
            lightModePallete.ButtonStyles.ButtonCustom1.StatePressed.Border.Color1 = Color.DarkGray;
            lightModePallete.ButtonStyles.ButtonCustom1.StatePressed.Border.Color2 = Color.DarkGray;
            lightModePallete.ButtonStyles.ButtonCustom1.StatePressed.Content.LongText.Color1 = Color.FromArgb(29, 37, 48);
            lightModePallete.ButtonStyles.ButtonCustom1.StatePressed.Content.LongText.Color2 = Color.FromArgb(29, 37, 48);
            lightModePallete.ButtonStyles.ButtonCustom1.StatePressed.Content.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            lightModePallete.ButtonStyles.ButtonCustom1.StatePressed.Content.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            lightModePallete.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = Color.FromArgb(239, 252, 250);
            lightModePallete.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = Color.FromArgb(239, 252, 250);
            lightModePallete.ButtonStyles.ButtonCustom1.StateTracking.Border.Color1 = Color.Transparent;
            lightModePallete.ButtonStyles.ButtonCustom1.StateTracking.Border.Color2 = Color.Transparent;
            lightModePallete.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // btnSignUp
            // 
            btnSignUp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSignUp.ButtonStyle = Krypton.Toolkit.ButtonStyle.Custom1;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.Location = new Point(1040, 9);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnSignUp.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnSignUp.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnSignUp.OverrideFocus.Border.Color1 = Color.DarkGray;
            btnSignUp.OverrideFocus.Border.Color2 = Color.DarkGray;
            btnSignUp.OverrideFocus.Content.LongText.Color1 = Color.FromArgb(39, 165, 153);
            btnSignUp.OverrideFocus.Content.LongText.Color2 = Color.FromArgb(39, 165, 153);
            btnSignUp.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(39, 165, 153);
            btnSignUp.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(39, 165, 153);
            btnSignUp.Size = new Size(75, 32);
            btnSignUp.StateCommon.Back.Color1 = Color.FromArgb(39, 165, 153);
            btnSignUp.StateCommon.Back.Color2 = Color.FromArgb(39, 165, 153);
            btnSignUp.StateCommon.Border.Color1 = Color.FromArgb(229, 242, 240);
            btnSignUp.StateCommon.Border.Color2 = Color.FromArgb(229, 242, 240);
            btnSignUp.StateCommon.Border.Rounding = 5F;
            btnSignUp.StateCommon.Content.LongText.Color1 = Color.White;
            btnSignUp.StateCommon.Content.LongText.Color2 = Color.White;
            btnSignUp.StateCommon.Content.LongText.Font = new Font("Inter", 9F, FontStyle.Bold);
            btnSignUp.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 15.7499981F);
            btnSignUp.StatePressed.Border.Color1 = Color.DarkGray;
            btnSignUp.StatePressed.Border.Color2 = Color.DarkGray;
            btnSignUp.TabIndex = 0;
            btnSignUp.Values.DropDownArrowColor = Color.Empty;
            btnSignUp.Values.ExtraText = "Sign Up";
            btnSignUp.Values.Text = "";
            btnSignUp.Click += btnSignUp_Click;
            // 
            // pnlMainContent
            // 
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(0, 82);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1184, 599);
            pnlMainContent.TabIndex = 2;
            // 
            // darkModePallete
            // 
            darkModePallete.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = Color.DarkBlue;
            darkModePallete.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = Color.DarkBlue;
            darkModePallete.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = Color.DarkBlue;
            darkModePallete.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = Color.DarkBlue;
            darkModePallete.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // LoginFormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1184, 681);
            Controls.Add(pnlMainContent);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginFormUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginFormUser";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnCollapse;
        private Krypton.Toolkit.KryptonButton btnMaximize;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonButton btnAboutUs;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Krypton.Toolkit.KryptonButton btnSignUp;
        private Panel pnlMainContent;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonCustomPaletteBase lightModePallete;
        private Krypton.Toolkit.KryptonCustomPaletteBase darkModePallete;
    }
}