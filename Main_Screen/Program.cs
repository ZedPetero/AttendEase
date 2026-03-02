namespace AE.Application;

using AE.Domain.Models;
using AE.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;


internal static class Program
{
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

        var serviceProvider = services.BuildServiceProvider();

        using (var scope = serviceProvider.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetService(typeof(AppDbContext)) as AppDbContext;
            dbContext.Database.Migrate();
        }

        using (var splash = new Splash_Screen_Form())
        {
            splash.ShowDialog();
        }

        while (true)
        {
            var userManager = (UserManager<Teacher>)serviceProvider.GetService(typeof(UserManager<Teacher>));
            using (var login = new Login_Screen_Form(userManager))
            {
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }

            var mainForm = new Main_Screen_Form();
            Application.Run(mainForm);
        }
    }
}
