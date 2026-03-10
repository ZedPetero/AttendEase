namespace AE.Application
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
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ButtonSpecs.Add(formCollapse);
            ButtonSpecs.Add(formMaximize);
            ButtonSpecs.Add(formClose);
            ClientSize = new Size(1184, 681);
            CloseBox = false;
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserLoginForm";
            PaletteMode = Krypton.Toolkit.PaletteMode.Microsoft365White;
            StartPosition = FormStartPosition.CenterScreen;
            StateCommon.Header.Content.ShortText.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.ButtonSpecAny formClose;
        private Krypton.Toolkit.ButtonSpecAny formCollapse;
        private Krypton.Toolkit.ButtonSpecAny formMaximize;
    }
}