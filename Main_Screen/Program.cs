namespace AE.Application;
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Register Syncfusion license before creating any Syncfusion controls (Login uses Syncfusion).
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JGaF1cXmhLYVJ0WmFZfVhgdVVMZV5bRnZPIiBoS35RcEVhWXpccnFXRGBYVUB0VEFf");

            // show the splash screen first; when it closes, show the login dialog
            using (var splash = new Splash_Screen_Form())
            {
                splash.ShowDialog();
            }

            while (true)
            {
                // Show login
                using (var login = new Login_Screen_Form())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                        return; // exit app if cancelled
                }

                // Show main screen
                var mainForm = new Main_Screen_Form();
                Application.Run(mainForm);

                // If we reach here, user clicked Logout
                // Loop back to login
            }
    }
}
