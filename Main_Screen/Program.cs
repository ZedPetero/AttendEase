namespace Brevi.Application;

using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories; // Added this
using Brevi.Services.Repositories.IRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }

    [STAThread]
    static void Main()
    {
        FontEngine.LoadFonts();
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JGaF1cXmhIfEx1RHxQdld5ZFRHallYTnNWUj0eQnxTdENjW35acHJRRWNbVkR0VkleYQ==");

        var services = new ServiceCollection();

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite("Data Source=AttendEase.db"));

        services.AddIdentityCore<Teacher>()
            .AddEntityFrameworkStores<AppDbContext>();

        // Register your forms here so DI can build them!
        services.AddTransient<LoginFormUser>();
        services.AddTransient<MainScreenForm>();
        services.AddTransient<ISectionService, SectionService>();
        ServiceProvider = services.BuildServiceProvider();

        // Run Migrations safely
        using (var scope = ServiceProvider.CreateScope())
        {
            var dbContext = (AppDbContext)scope.ServiceProvider.GetService(typeof(AppDbContext));
            dbContext.Database.Migrate();
        }

        using (var splash = new SplashScreenForm())
        {
            splash.ShowDialog();
        }

        bool exitClicked = false;

        while (!exitClicked)
        {
            // Ask the DI container to give us the Login form (it will inject UserManager automatically)
            using (var userLogin = (LoginFormUser)ServiceProvider.GetService(typeof(LoginFormUser)))
            {
                if (userLogin.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            // Ask the DI container for the Main form
            try
            {
                using (var mainForm = (MainScreenForm)ServiceProvider.GetService(typeof(MainScreenForm)))
                {
                    mainForm.ExitClicked += (sender, e) => exitClicked = true;
                    mainForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                // If DI fails to build the form, it will throw an exception here.
                // This will pop up a box telling us exactly what is missing!
                MessageBox.Show($"Crash while loading MainScreenForm:\n{ex.Message}");
                return;
            }
        }
    }
}