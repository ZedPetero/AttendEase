
using System.Drawing.Drawing2D;
namespace AE.Application
{
    public partial class Main_Screen_Form : Form
    {
        public Main_Screen_Form()
        {
            InitializeComponent();
            UC_Home myHome = new UC_Home();
            loadForm(myHome);
        }
        bool sidebarExpand = false;
        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home myHome = new UC_Home();
            loadForm(myHome);
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            int minWidth = 50;
            int maxWidth = 200;

            if (sidebarExpand == false)
            {
                sidebar.Width += 10;

                if (sidebar.Width >= maxWidth)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width -= 10;

                if (sidebar.Width <= minWidth)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        public void loadForm(UserControl customizedControl)
        {
            pnlMainContent.Controls.Clear();

            customizedControl.Dock = DockStyle.Fill;

            pnlMainContent.Controls.Add(customizedControl);

            pnlMainContent.SendToBack();
        }

        private void btnClasses_Click(object sender, EventArgs e)
        {
            UC_Classes myClasses = new UC_Classes();
            loadForm(myClasses);
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            UC_Records myRecords = new UC_Records();
            loadForm(myRecords);
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            UC_Teacher myTeacher = new UC_Teacher();
            loadForm(myTeacher);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
