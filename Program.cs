using System;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using AE.Infrastructure.Data;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        // Ensure relative DB name resolves to the app folder.
        AppDomain.CurrentDomain.SetData("DataDirectory", AppContext.BaseDirectory);
        Environment.CurrentDirectory = AppContext.BaseDirectory;

        // Create / migrate the database before the UI starts so tables exist.
        try
        {
            // For diagnostics: compute the resolved path so you can confirm where the file will be created.
            string dataDir = (AppDomain.CurrentDomain.GetData("DataDirectory") as string) ?? AppContext.BaseDirectory;
            string dbPath = Path.Combine(dataDir, "AttendEase.db");

            // Optional: show path for quick debugging (remove in production)
            // MessageBox.Show($"Database path: {dbPath}", "DB Path", MessageBoxButtons.OK, MessageBoxIcon.Information);

            using var db = new AppDbContext();
            db.Database.Migrate();   // apply migrations (creates tables)
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to create or migrate database: {ex.Message}", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        ApplicationConfiguration.Initialize();
        Application.Run(new MainForm());
    }
}