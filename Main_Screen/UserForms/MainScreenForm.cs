using Brevi.Domain.Repositories.IRepositories;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories;
using System.Drawing.Drawing2D;
namespace Brevi.Application
{
    public partial class MainScreenForm : Form
    {
        bool sidebarExpand = false;
        private Form backgroundOverlay;
        private readonly ISectionService _sectionService;
        public event EventHandler? ExitClicked;

        public MainScreenForm()
        {
            InitializeComponent();
            //this.Resize += MainScreenForm_Resize;
            UpdateMainContentBounds();
            var db = new AppDbContext();
            _sectionService = new SectionService(db);

            UCHome myHome = new UCHome();
            LoadForm(myHome);
            btnHome.Checked = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UCHome myHome = new UCHome();
            LoadForm(myHome);
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
            //UpdateMainContentBounds();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void MainScreenForm_Resize(object? sender, EventArgs e)
        {
            UpdateMainContentBounds();
        }

        private void UpdateMainContentBounds()
        {
            int left = sidebar.Right;
            int top = kryptonPanel1.Bottom;
            int width = this.ClientSize.Width - left;
            int height = this.ClientSize.Height - top;

            if (width < 0) width = 0;
            if (height < 0) height = 0;

            pnlMainContent.Location = new Point(left, top);
            pnlMainContent.Size = new Size(width, height);
        }
        public void LoadForm(UserControl customizedControl)
        {
            pnlMainContent.Controls.Clear();

            customizedControl.Dock = DockStyle.Fill;

            pnlMainContent.Controls.Add(customizedControl);

            //pnlMainContent.SendToBack();
            customizedControl.Focus();
        }

        public void btnClasses_Click(object sender, EventArgs e)
        {
            UCClasses myClasses = new UCClasses(_sectionService);
            LoadForm(myClasses);
        }

        public void btnRecords_Click(object sender, EventArgs e)
        {
            UC_Records_New myRecords = new UC_Records_New();
            LoadForm(myRecords);
        }

        public void btnTeacher_Click(object sender, EventArgs e)
        {
            UCTeacher myTeacher = new UCTeacher();
            LoadForm(myTeacher);
        }

        public void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnSettings_Click(object sender, EventArgs e)
        {
            UCSettings mySettings = new UCSettings();
            LoadForm(mySettings);
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
            LoadForm(new UCClasses(_sectionService));
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.MaximumSize = Screen.FromControl(this).WorkingArea.Size;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.MaximumSize = new Size(0, 0);
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ExitClicked.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void pnlMainContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
