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
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        // Register Syncfusion license before creating any Syncfusion controls (Login uses Syncfusion).
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1JGaF1cXmhIfEx1RHxQdld5ZFRHallYTnNWUj0eQnxTdENjW35acHJRRWNbVkR0VkleYQ==");

        var services = new ServiceCollection();

        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite("Data Source=AttendEase.db"));

        services.AddIdentityCore<Teacher>()
            .AddEntityFrameworkStores<AppDbContext>();

        var serviceProvider = services.BuildServiceProvider();

        using (var splash = new Splash_Screen_Form())
        {
            splash.ShowDialog();
        }

        while (true)
        {
            using (var login = new Login_Screen_Form(
                ServiceProviderServiceExtensions.GetRequiredService<UserManager<Teacher>>(serviceProvider)))
            {
                    
                if (login.ShowDialog() != DialogResult.OK)
                    return;
            }

            var mainForm = new Main_Screen_Form();
            Application.Run(mainForm);
        }
    }
}
