using Brevi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
namespace Brevi.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var baseDir = AppContext.BaseDirectory;
                var dbPath = Path.Combine(baseDir, "AttendEase.db");
                optionsBuilder.UseSqlite($"Data Source={dbPath}");
            }
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Section> Sections { get; set; } 
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Attendance> AttendanceRecords { get; set; }
        public DbSet<AttendanceWeights> AttendanceWeights { get; set; } 
    }
}
