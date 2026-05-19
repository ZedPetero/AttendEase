namespace Brevi.Application;

using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories; // Added this
using Brevi.Services.Repositories.IRepositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.Windows.Forms;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }

    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
        if (!IsFontInstalled("Inter") || !IsFontInstalled("Material Symbols Outlined"))
        {
            try
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;

         
                string interVar = "Inter-VariableFont_opsz,wght.ttf";
                string iconVar = "MaterialSymbolsOutlined[FILL,GRAD,opsz,wght].ttf";

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "cmd.exe";

                psi.Arguments = $"/c copy /y \"{Path.Combine(baseDir, interVar)}\" \"%WINDIR%\\Fonts\" & " +
                                $"copy /y \"{Path.Combine(baseDir, iconVar)}\" \"%WINDIR%\\Fonts\" & " +
                                $"reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Fonts\" /v \"Inter (TrueType)\" /t REG_SZ /d \"{interVar}\" /f & " +
                                $"reg add \"HKLM\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Fonts\" /v \"Material Symbols Outlined (TrueType)\" /t REG_SZ /d \"{iconVar}\" /f";

                psi.Verb = "runas";
                psi.UseShellExecute = true;
                psi.WindowStyle = ProcessWindowStyle.Normal; 

                Process p = Process.Start(psi);

                MessageBox.Show("Font setup initiated. Please wait for the black window to finish, then the app will close.", "Setup");

                p.WaitForExit();

                Environment.Exit(0);
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
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
        services.AddTransient<ITeacherService, TeacherService>();
        services.AddTransient<IStudentService, StudentService>();
        services.AddTransient<IAttendanceService, AttendanceService>();
        services.AddTransient<IGradeService, GradeService>();
        services.AddTransient<IAttendanceWeightsService, AttendanceWeightsService>();
        services.AddTransient<IRepository<Subject>, Repository<Subject>>();
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

            using (var mainForm = (MainScreenForm)ServiceProvider.GetService(typeof(MainScreenForm)))
            {
                mainForm.ExitClicked += (sender, e) => exitClicked = true;
                mainForm.ShowDialog();
            }
        }
    }
    static bool IsFontInstalled(string name)
    {
        using (var fonts = new System.Drawing.Text.InstalledFontCollection())
        {
            return fonts.Families.Any(f => f.Name.Contains(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}