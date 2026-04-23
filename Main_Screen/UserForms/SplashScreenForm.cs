using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Brevi.Application
{
    public partial class SplashScreenForm : Form
    {
        private Panel loadingPanel;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.Timer fadeTimer;
        private Stopwatch stopwatch;
        private readonly int animationDurationMs = 3000;

        public SplashScreenForm()
        {
            InitializeComponent();

            // ensure no border and centered
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;

            // create loading panel placed relative to pictureBox1 (from designer)
            loadingPanel = new DoubleBufferedPanel();
            loadingPanel.Size = new Size(120, 36);
            loadingPanel.BackColor = Color.Transparent;
            loadingPanel.Paint += LoadingPanel_Paint;

            // timers
            stopwatch = new Stopwatch();
            animationTimer = new System.Windows.Forms.Timer { Interval = 16 };
            animationTimer.Tick += AnimationTimer_Tick;
            fadeTimer = new System.Windows.Forms.Timer { Interval = 30 };
            fadeTimer.Tick += FadeTimer_Tick;

            Shown += SplashScreenForm_Shown;
            FormClosed += SplashScreenForm_FormClosed;
            Resize += SplashScreenForm_Resize;
        }

        private void SplashScreenForm_Shown(object? sender, EventArgs e)
        {
            // add loadingPanel after designer created pictureBox1
            if (!Controls.Contains(loadingPanel))
                Controls.Add(loadingPanel);

            PositionLoadingPanel();
            stopwatch.Restart();
            animationTimer.Start();
        }

        private void SplashScreenForm_Resize(object? sender, EventArgs e)
        {
            PositionLoadingPanel();
        }

        private void PositionLoadingPanel()
        {
            if (pictureBox1 != null && loadingPanel != null)
            {
                loadingPanel.Location = new Point(
                    pictureBox1.Location.X + (pictureBox1.Width - loadingPanel.Width) / 2,
                    pictureBox1.Location.Y + pictureBox1.Height - loadingPanel.Height - 12);
                loadingPanel.BringToFront();
            }
        }

        private void AnimationTimer_Tick(object? sender, EventArgs e)
        {
            loadingPanel.Invalidate();
            if (stopwatch.ElapsedMilliseconds >= animationDurationMs)
            {
                animationTimer.Stop();
                fadeTimer.Start();
            }
        }

        private void FadeTimer_Tick(object? sender, EventArgs e)
        {
            Opacity -= 0.12;
            if (Opacity <= 0)
            {
                fadeTimer.Stop();
                Close();
            }
        }

        private void SplashScreenForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            animationTimer?.Stop();
            fadeTimer?.Stop();
            stopwatch?.Stop();
            animationTimer?.Dispose();
            fadeTimer?.Dispose();
        }

        private void LoadingPanel_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            long t = stopwatch.ElapsedMilliseconds;
            float baseX = loadingPanel.Width / 2f;
            float baseY = loadingPanel.Height / 2f;

            int dots = 3;
            float maxRadius = 8f;
            float spacing = 22f;
            float totalWidth = (dots - 1) * spacing;
            float startX = baseX - totalWidth / 2f;

            for (int i = 0; i < dots; i++)
            {
                double phase = (t / 200.0) + i * 0.6;
                float dy = (float)(Math.Sin(phase) * 6.0);
                float scale = 0.6f + (float)((Math.Sin(phase) + 1.0) * 0.4f);

                float radius = maxRadius * scale * 0.7f;
                float cx = startX + i * spacing;
                float cy = baseY - dy;

                int alpha = (int)(180 + (Math.Abs(dy) / 6.0) * 75);
                alpha = Math.Max(100, Math.Min(255, alpha));

                using var brush = new SolidBrush(Color.FromArgb(alpha, Color.White));
                g.FillEllipse(brush, cx - radius / 2f, cy - radius / 2f, radius, radius);
            }
        }

        private class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel()
            {
                DoubleBuffered = true;
                SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            }
        }

        // Empty handlers to satisfy designer event hookups from the original designer file.
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void timer1_Tick(object sender, EventArgs e) { }
        private void timer2_Tick(object sender, EventArgs e) { }
        private void timer3_Tick(object sender, EventArgs e) { }
        private void timer4_Tick(object sender, EventArgs e) { }
        private void timer5_Tick(object sender, EventArgs e) { }
        private void timer6_Tick(object sender, EventArgs e) { }
        private void timer7_Tick(object sender, EventArgs e) { }
        private void timer8_Tick(object sender, EventArgs e) { }
        private void Splash_Screen_Form_Load(object sender, EventArgs e) { }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
