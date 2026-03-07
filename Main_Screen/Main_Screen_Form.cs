
using Krypton.Toolkit;
using System.Drawing.Drawing2D;
namespace AE.Application
{
    public partial class Main_Screen_Form : KryptonForm
    {
        bool sidebarExpand = false;
        private Form backgroundOverlay;

        public Main_Screen_Form()
        {
            InitializeComponent();
            UC_Home myHome = new UC_Home();
            loadForm(myHome);
            btnHome.Checked = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home myHome = new UC_Home();
            loadForm(myHome);
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            int minWidth = 55;
            int maxWidth = 200;
            if (sidebarExpand == false)
            {
                sidebar.Width += 10;
                btnHome.Width += 10;
                btnClasses.Width += 10;
                btnRecords.Width += 10;
                btnTeacher.Width += 10;
                btnSettings.Width += 10;
                if (sidebar.Width >= maxWidth)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width -= 10;
                btnHome.Width -= 10;
                btnClasses.Width -= 10;
                btnRecords.Width -= 10;
                btnTeacher.Width -= 10;
                btnSettings.Width -= 10;
                if (sidebar.Width <= minWidth)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        public void loadForm(UserControl customizedControl)
        {
            pnlMainContent.Controls.Clear();

            customizedControl.Dock = DockStyle.Fill;

            pnlMainContent.Controls.Add(customizedControl);

            pnlMainContent.SendToBack();
            customizedControl.Focus();
        }

        public void btnClasses_Click(object sender, EventArgs e)
        {
            UC_Classes myClasses = new UC_Classes();
            loadForm(myClasses);
        }

        public void btnRecords_Click(object sender, EventArgs e)
        {
            UC_Records myRecords = new UC_Records();
            loadForm(myRecords);
        }

        public void btnTeacher_Click(object sender, EventArgs e)
        {
            UC_Teacher myTeacher = new UC_Teacher();
            loadForm(myTeacher);
        }

        public void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnSettings_Click(object sender, EventArgs e)
        {
            UC_Settings mySettings = new UC_Settings();
            loadForm(mySettings);
        }

        public void ShowOverlay()
        {
            backgroundOverlay = new Form();
            backgroundOverlay.FormBorderStyle = FormBorderStyle.None;
            backgroundOverlay.BackColor = Color.Black;
            backgroundOverlay.Opacity = 0.50;
            backgroundOverlay.StartPosition = FormStartPosition.Manual;
            backgroundOverlay.ShowInTaskbar = false;

            backgroundOverlay.Location = this.PointToScreen(Point.Empty);
            backgroundOverlay.Size = this.ClientSize;

            backgroundOverlay.Show(this);
        }

        public void HideOverlay()
        {
            if (backgroundOverlay != null)
            {
                backgroundOverlay.Close();
                backgroundOverlay.Dispose();
                backgroundOverlay = null;
            }
        }
        public void NavigateToClasses()
        {
            btnClasses.Checked = true;
            loadForm(new UC_Classes());
        }
    }
}
