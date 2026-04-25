namespace Brevi.Application;

using Brevi.Domain.Models;
using Brevi.Domain.Repositories;
using Brevi.Domain.Repositories.IRepositories;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories.IRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
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

        services.AddScoped<IUserService, UserService>();

        var serviceProvider = services.BuildServiceProvider();

        using (var scope = serviceProvider.CreateScope())
        {
            var dbContext = scope.ServiceProvider.GetService(typeof(AppDbContext)) as AppDbContext;
            dbContext.Database.Migrate();
        }

        using (var splash = new SplashScreenForm())
        {
            splash.ShowDialog();
        }

        // ====================================== For the old login form ======================================

        //while (true)
        //{
        //    var userManager = (UserManager<Teacher>)serviceProvider.GetService(typeof(UserManager<Teacher>));
        //    using (var login = new LoginScreenForm(userManager))
        //    {
        //        if (login.ShowDialog() != DialogResult.OK)
        //            return;
        //    }

        //    var mainForm = new MainScreenForm();
        //    Application.Run(mainForm);
        //}

        // ====================================== For the new login form ======================================

        var userManager = (UserManager<Teacher>)serviceProvider.GetService(typeof(UserManager<Teacher>));
        var userService = (IUserService)serviceProvider.GetService(typeof(IUserService));

        bool exitClicked = false;

        while (!exitClicked)
        {
            using (var userLogin = new LoginFormUser(userManager, userService))
            {
                if (userLogin.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }

            using (var mainForm = new MainScreenForm())
            {
                mainForm.ExitClicked += (sender, e) => exitClicked = true;
                mainForm.ShowDialog();
            }
        }

        //using (var userLogin = new UserLoginForm())
        //{
        //    userLogin.ShowDialog();
        //}
    }
}
