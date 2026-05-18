namespace Brevi.Application
{
    partial class UCInteractionPage
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
            btnStartNow = new Krypton.Toolkit.KryptonButton();
            kryptonWrapLabel1 = new Krypton.Toolkit.KryptonWrapLabel();
            pictureBox2 = new PictureBox();
            loggedInViewPanel = new Krypton.Toolkit.KryptonPanel();
            borderPanel = new Krypton.Toolkit.KryptonPanel();
            pictureBox3 = new PictureBox();
            kryptonWrapLabel2 = new Krypton.Toolkit.KryptonWrapLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loggedInViewPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borderPanel).BeginInit();
            borderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.None;
            btnStartNow.Cursor = Cursors.Hand;
            btnStartNow.Location = new Point(109, 380);
            btnStartNow.Name = "btnStartNow";
            btnStartNow.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnStartNow.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.False;
            btnStartNow.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            btnStartNow.OverrideFocus.Border.Color1 = Color.DarkGray;
            btnStartNow.OverrideFocus.Border.Color2 = Color.DarkGray;
            btnStartNow.OverrideFocus.Content.LongText.Color1 = Color.FromArgb(39, 165, 153);
            btnStartNow.OverrideFocus.Content.LongText.Color2 = Color.FromArgb(39, 165, 153);
            btnStartNow.OverrideFocus.Content.ShortText.Color1 = Color.FromArgb(39, 165, 153);
            btnStartNow.OverrideFocus.Content.ShortText.Color2 = Color.FromArgb(39, 165, 153);
            btnStartNow.Size = new Size(128, 36);
            btnStartNow.StateCommon.Back.Color1 = Color.FromArgb(39, 165, 153);
            btnStartNow.StateCommon.Back.Color2 = Color.FromArgb(39, 165, 153);
            btnStartNow.StateCommon.Border.Color1 = Color.FromArgb(229, 242, 240);
            btnStartNow.StateCommon.Border.Color2 = Color.FromArgb(229, 242, 240);
            btnStartNow.StateCommon.Border.Rounding = 5F;
            btnStartNow.StateCommon.Content.LongText.Color1 = Color.White;
            btnStartNow.StateCommon.Content.LongText.Color2 = Color.White;
            btnStartNow.StateCommon.Content.LongText.Font = new Font("Inter", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartNow.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 20.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStartNow.StatePressed.Border.Color1 = Color.DarkGray;
            btnStartNow.StatePressed.Border.Color2 = Color.DarkGray;
            btnStartNow.TabIndex = 0;
            btnStartNow.TabStop = false;
            btnStartNow.Values.DropDownArrowColor = Color.Empty;
            btnStartNow.Values.ExtraText = "Start Now ->";
            btnStartNow.Values.Text = "";
            btnStartNow.Click += btnStartNow_Click;
            // 
            // kryptonWrapLabel1
            // 
            kryptonWrapLabel1.Anchor = AnchorStyles.None;
            kryptonWrapLabel1.AutoSize = false;
            kryptonWrapLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            kryptonWrapLabel1.Location = new Point(100, 294);
            kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            kryptonWrapLabel1.Size = new Size(332, 73);
            kryptonWrapLabel1.StateCommon.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonWrapLabel1.StateCommon.TextColor = Color.FromArgb(108, 124, 137);
            kryptonWrapLabel1.Text = "\"Less Time Counting, More Time Teaching\"";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.BackgroundImage = Properties.Resources.Logo_Name_only_removedBg;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(57, 132);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(425, 152);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // loggedInViewPanel
            // 
            loggedInViewPanel.Location = new Point(1, 1);
            loggedInViewPanel.Name = "loggedInViewPanel";
            loggedInViewPanel.Size = new Size(353, 233);
            loggedInViewPanel.StateCommon.Color1 = Color.White;
            loggedInViewPanel.StateCommon.Color2 = Color.White;
            loggedInViewPanel.TabIndex = 1;
            // 
            // borderPanel
            // 
            borderPanel.Anchor = AnchorStyles.None;
            borderPanel.Controls.Add(loggedInViewPanel);
            borderPanel.Location = new Point(580, 217);
            borderPanel.Name = "borderPanel";
            borderPanel.Size = new Size(355, 235);
            borderPanel.StateCommon.Color1 = Color.FromArgb(39, 165, 153);
            borderPanel.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources._531a8a2e_da7c_451a_871e_bfb845496f96_removalai_preview;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Dock = DockStyle.Right;
            pictureBox3.Location = new Point(589, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(595, 599);
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // kryptonWrapLabel2
            // 
            kryptonWrapLabel2.Anchor = AnchorStyles.None;
            kryptonWrapLabel2.AutoSize = false;
            kryptonWrapLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            kryptonWrapLabel2.Location = new Point(579, 146);
            kryptonWrapLabel2.Name = "kryptonWrapLabel2";
            kryptonWrapLabel2.Size = new Size(355, 51);
            kryptonWrapLabel2.StateCommon.Font = new Font("Inter Medium", 12F, FontStyle.Bold);
            kryptonWrapLabel2.StateCommon.TextColor = Color.FromArgb(108, 124, 137);
            kryptonWrapLabel2.Text = "Already logged in here? Select your account to quickly log in:";
            // 
            // UCInteractionPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(kryptonWrapLabel2);
            Controls.Add(borderPanel);
            Controls.Add(pictureBox2);
            Controls.Add(kryptonWrapLabel1);
            Controls.Add(btnStartNow);
            Controls.Add(pictureBox3);
            Name = "UCInteractionPage";
            Size = new Size(1184, 599);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)loggedInViewPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)borderPanel).EndInit();
            borderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonButton btnStartNow;
        private Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private PictureBox pictureBox2;
        private Krypton.Toolkit.KryptonPanel loggedInViewPanel;
        private Krypton.Toolkit.KryptonPanel borderPanel;
        private PictureBox pictureBox3;
        private Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel2;
    }
}
