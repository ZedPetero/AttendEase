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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            btnStartNow = new Krypton.Toolkit.KryptonButton();
            kryptonWrapLabel1 = new Krypton.Toolkit.KryptonWrapLabel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            loggedInViewPanel = new Krypton.Toolkit.KryptonPanel();
            borderPanel = new Krypton.Toolkit.KryptonPanel();
            label2 = new Label();
            timerSlide = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loggedInViewPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borderPanel).BeginInit();
            borderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackgroundImage = Properties.Resources.homepageimg;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(508, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(569, 420);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.Top;
            btnStartNow.Cursor = Cursors.Hand;
            btnStartNow.Location = new Point(124, 373);
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
            btnStartNow.TabIndex = 25;
            btnStartNow.TabStop = false;
            btnStartNow.Values.DropDownArrowColor = Color.Empty;
            btnStartNow.Values.ExtraText = "Start Now ->";
            btnStartNow.Values.Text = "";
            btnStartNow.Click += btnStartNow_Click;
            // 
            // kryptonWrapLabel1
            // 
            kryptonWrapLabel1.Anchor = AnchorStyles.Top;
            kryptonWrapLabel1.AutoSize = false;
            kryptonWrapLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.AlternateControl;
            kryptonWrapLabel1.Location = new Point(116, 274);
            kryptonWrapLabel1.Name = "kryptonWrapLabel1";
            kryptonWrapLabel1.Size = new Size(332, 73);
            kryptonWrapLabel1.StateCommon.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonWrapLabel1.StateCommon.TextColor = Color.FromArgb(108, 124, 137);
            kryptonWrapLabel1.Text = "\"Less Time Counting, More Time Teaching\"";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackgroundImage = Properties.Resources.Logo_Name_only_removedBg;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(113, 136);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(256, 119);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Inter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(29, 37, 48);
            label1.Location = new Point(124, 562);
            label1.Name = "label1";
            label1.Size = new Size(476, 23);
            label1.TabIndex = 15;
            label1.Text = "Already logged in here? Select your account to quickly log in:";
            // 
            // loggedInViewPanel
            // 
            loggedInViewPanel.Location = new Point(1, 1);
            loggedInViewPanel.Name = "loggedInViewPanel";
            loggedInViewPanel.Size = new Size(350, 150);
            loggedInViewPanel.StateCommon.Color1 = Color.White;
            loggedInViewPanel.StateCommon.Color2 = Color.White;
            loggedInViewPanel.TabIndex = 18;
            // 
            // borderPanel
            // 
            borderPanel.Anchor = AnchorStyles.Top;
            borderPanel.Controls.Add(loggedInViewPanel);
            borderPanel.Location = new Point(124, 613);
            borderPanel.Name = "borderPanel";
            borderPanel.Size = new Size(352, 152);
            borderPanel.StateCommon.Color1 = Color.Black;
            borderPanel.TabIndex = 19;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Inter", 4F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(29, 37, 48);
            label2.Location = new Point(125, 835);
            label2.Name = "label2";
            label2.Size = new Size(7, 9);
            label2.TabIndex = 21;
            label2.Text = ".";
            // 
            // timerSlide
            // 
            timerSlide.Interval = 50;
            timerSlide.Tick += timerSlide_Tick;
            // 
            // UCInteractionPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(label2);
            Controls.Add(borderPanel);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(kryptonWrapLabel1);
            Controls.Add(btnStartNow);
            Controls.Add(pictureBox1);
            Name = "UCInteractionPage";
            Size = new Size(1184, 869);
            Load += UCInteractionPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)loggedInViewPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)borderPanel).EndInit();
            borderPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton btnStartNow;
        private Krypton.Toolkit.KryptonWrapLabel kryptonWrapLabel1;
        private PictureBox pictureBox2;
        private Label label1;
        private Krypton.Toolkit.KryptonPanel loggedInViewPanel;
        private Krypton.Toolkit.KryptonPanel borderPanel;
        private Label label2;
        private System.Windows.Forms.Timer timerSlide;
    }
}
