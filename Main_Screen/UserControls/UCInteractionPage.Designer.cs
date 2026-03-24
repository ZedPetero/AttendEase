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
            pictureBox1 = new PictureBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            btnStartNow = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = Properties.Resources.homepageimg;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(508, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(569, 420);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.None;
            kryptonLabel3.Location = new Point(113, 299);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(286, 35);
            kryptonLabel3.StateCommon.ShortText.Color1 = Color.FromArgb(108, 124, 137);
            kryptonLabel3.StateCommon.ShortText.Color2 = Color.FromArgb(108, 124, 137);
            kryptonLabel3.StateCommon.ShortText.Font = new Font("Inter Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel3.TabIndex = 7;
            kryptonLabel3.Values.Text = "Your Presence Matters";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.None;
            kryptonLabel2.Location = new Point(107, 206);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(204, 74);
            kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(29, 37, 48);
            kryptonLabel2.StateCommon.ShortText.Color2 = Color.FromArgb(29, 37, 48);
            kryptonLabel2.StateCommon.ShortText.Font = new Font("Inter", 40F, FontStyle.Bold);
            kryptonLabel2.TabIndex = 6;
            kryptonLabel2.Values.Text = "Korum";
            // 
            // btnStartNow
            // 
            btnStartNow.Anchor = AnchorStyles.None;
            btnStartNow.Location = new Point(124, 353);
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
            btnStartNow.TabIndex = 10;
            btnStartNow.Values.DropDownArrowColor = Color.Empty;
            btnStartNow.Values.ExtraText = "Start Now ->";
            btnStartNow.Values.Text = "";
            btnStartNow.Click += btnStartNow_Click;
            // 
            // UCInteractionPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnStartNow);
            Controls.Add(pictureBox1);
            Controls.Add(kryptonLabel3);
            Controls.Add(kryptonLabel2);
            Name = "UCInteractionPage";
            Size = new Size(1184, 599);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnStartNow;
    }
}
