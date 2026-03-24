namespace Brevi.Application
{
    partial class UserLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            formClose = new Krypton.Toolkit.ButtonSpecAny();
            formCollapse = new Krypton.Toolkit.ButtonSpecAny();
            formMaximize = new Krypton.Toolkit.ButtonSpecAny();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonButton6 = new Krypton.Toolkit.KryptonButton();
            kryptonButton5 = new Krypton.Toolkit.KryptonButton();
            kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // formClose
            // 
            formClose.Enabled = Krypton.Toolkit.ButtonEnabled.True;
            formClose.Image = (Image)resources.GetObject("formClose.Image");
            formClose.Type = Krypton.Toolkit.PaletteButtonSpecStyle.FormClose;
            formClose.UniqueName = "formClose";
            // 
            // formCollapse
            // 
            formCollapse.Enabled = Krypton.Toolkit.ButtonEnabled.True;
            formCollapse.Image = (Image)resources.GetObject("formCollapse.Image");
            formCollapse.Type = Krypton.Toolkit.PaletteButtonSpecStyle.FormMin;
            formCollapse.UniqueName = "formCollapse";
            // 
            // formMaximize
            // 
            formMaximize.Enabled = Krypton.Toolkit.ButtonEnabled.True;
            formMaximize.Image = (Image)resources.GetObject("formMaximize.Image");
            formMaximize.Type = Krypton.Toolkit.PaletteButtonSpecStyle.FormMax;
            formMaximize.UniqueName = "formMaximize";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonLabel1);
            kryptonPanel2.Controls.Add(kryptonButton6);
            kryptonPanel2.Controls.Add(kryptonButton5);
            kryptonPanel2.Controls.Add(kryptonButton4);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(0, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1184, 50);
            kryptonPanel2.StateCommon.Color1 = Color.White;
            kryptonPanel2.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(38, 13);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(174, 25);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Inter", 9.75F);
            kryptonLabel1.TabIndex = 3;
            kryptonLabel1.Values.Text = "(Korum label here) Korum";
            // 
            // kryptonButton6
            // 
            kryptonButton6.Location = new Point(811, 9);
            kryptonButton6.Name = "kryptonButton6";
            kryptonButton6.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton6.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton6.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton6.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton6.Size = new Size(110, 32);
            kryptonButton6.StateCommon.Content.LongText.Font = new Font("Inter", 9.75F);
            kryptonButton6.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 15.7499981F);
            kryptonButton6.TabIndex = 2;
            kryptonButton6.Values.DropDownArrowColor = Color.Empty;
            kryptonButton6.Values.ExtraText = "About Us";
            kryptonButton6.Values.Text = "";
            // 
            // kryptonButton5
            // 
            kryptonButton5.Location = new Point(943, 9);
            kryptonButton5.Name = "kryptonButton5";
            kryptonButton5.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton5.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton5.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton5.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton5.Size = new Size(75, 32);
            kryptonButton5.StateCommon.Content.LongText.Font = new Font("Inter", 9.75F);
            kryptonButton5.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 15.7499981F);
            kryptonButton5.TabIndex = 1;
            kryptonButton5.Values.DropDownArrowColor = Color.Empty;
            kryptonButton5.Values.ExtraText = "Login";
            kryptonButton5.Values.Text = "";
            // 
            // kryptonButton4
            // 
            kryptonButton4.Location = new Point(1040, 9);
            kryptonButton4.Name = "kryptonButton4";
            kryptonButton4.OverrideDefault.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton4.OverrideDefault.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton4.OverrideFocus.Back.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton4.OverrideFocus.Border.Draw = Krypton.Toolkit.InheritBool.False;
            kryptonButton4.Size = new Size(75, 32);
            kryptonButton4.StateCommon.Back.Color1 = Color.FromArgb(39, 165, 153);
            kryptonButton4.StateCommon.Back.Color2 = Color.FromArgb(39, 165, 153);
            kryptonButton4.StateCommon.Border.Color1 = Color.Transparent;
            kryptonButton4.StateCommon.Border.Color2 = Color.Transparent;
            kryptonButton4.StateCommon.Border.Rounding = 5F;
            kryptonButton4.StateCommon.Content.LongText.Color1 = Color.White;
            kryptonButton4.StateCommon.Content.LongText.Color2 = Color.White;
            kryptonButton4.StateCommon.Content.LongText.Font = new Font("Inter", 9F, FontStyle.Bold);
            kryptonButton4.StateCommon.Content.ShortText.Font = new Font("Material Symbols Outlined", 15.7499981F);
            kryptonButton4.TabIndex = 0;
            kryptonButton4.Values.DropDownArrowColor = Color.Empty;
            kryptonButton4.Values.ExtraText = "Sign Up";
            kryptonButton4.Values.Text = "";
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ButtonSpecs.Add(formCollapse);
            ButtonSpecs.Add(formMaximize);
            ButtonSpecs.Add(formClose);
            ClientSize = new Size(1184, 681);
            CloseBox = false;
            Controls.Add(kryptonPanel2);
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserLoginForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.ButtonSpecAny formClose;
        private Krypton.Toolkit.ButtonSpecAny formCollapse;
        private Krypton.Toolkit.ButtonSpecAny formMaximize;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton6;
        private Krypton.Toolkit.KryptonButton kryptonButton5;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
    }
}