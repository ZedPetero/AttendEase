namespace AE.Application
{
    partial class UC_Teacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Teacher));
            imageList1 = new ImageList(components);
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            SuspendLayout();
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
            // kryptonButton1
            // 
            kryptonButton1.AutoSize = true;
            kryptonButton1.Location = new Point(792, 105);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(117, 68);
            kryptonButton1.TabIndex = 0;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Image = Properties.Resources.editbtn;
            kryptonButton1.Values.Text = "Edit";
            // 
            // UC_Teacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(kryptonButton1);
            Name = "UC_Teacher";
            Size = new Size(1150, 640);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.AirButton airButton1;
        private ReaLTaiizor.Controls.AloneButton aloneButton1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.ChatButtonLeft chatButtonLeft1;
        private ReaLTaiizor.Controls.ChatButtonRight chatButtonRight1;
        private ReaLTaiizor.Controls.CrownButton crownButton1;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.DreamButton dreamButton1;
        private ReaLTaiizor.Controls.DungeonButtonLeft dungeonButtonLeft1;
        private ReaLTaiizor.Controls.ForeverButton foreverButton1;
        private ReaLTaiizor.Controls.ForeverButtonSticky foreverButtonSticky1;
        private ReaLTaiizor.Controls.FoxButton foxButton1;
        private ReaLTaiizor.Controls.HopeButton hopeButton1;
        private ReaLTaiizor.Controls.LostButton lostButton1;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MetroButton metroButton1;
        private ReaLTaiizor.Controls.MoonButton moonButton1;
        private ReaLTaiizor.Controls.NightButton nightButton1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton1;
        private ReaLTaiizor.Controls.PoisonButton poisonButton1;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.RibbonButtonCenter ribbonButtonCenter1;
        private ReaLTaiizor.Controls.RoyalButton royalButton1;
        private ReaLTaiizor.Controls.SkyButton skyButton1;
        private ReaLTaiizor.Controls.SocialButton socialButton1;
        private ReaLTaiizor.Controls.SpaceButton spaceButton1;
        private ReaLTaiizor.Controls.ThunderButton thunderButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
    }
}
