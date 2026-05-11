using Brevi.Domain.DTO;
using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Services.Repositories.IRepositories
{
    public class SectionService : Repository<Section>, ISectionService
    {
        private readonly AppDbContext _context;
        public SectionService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<List<SectionDto>> GetTeacherSectionsAsync(int teacherId, bool includeArchived = false)
        {
            var query = _context.Sections
                .Where(s => s.TeacherId == teacherId);
            if (!includeArchived)
            {
                query = query.Where(s => !s.IsArchived);
            }
            return await query
                .Include(s => s.Subject)
                .Include(s => s.Students)
                .Select(s => new SectionDto
                {
                    Id = s.Id,
                    SectionName = s.SectionName,
                    SubjectName = s.Subject != null ? s.Subject.Name : "No Subject",
                    StudentCount = s.Students.Count,
                    StartTime = s.StartTimeSchedule,
                    EndTime = s.EndTimeSchedule,
                    IsArchived = s.IsArchived
                })
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<Section?> GetSectionByIdAsync(int sectionId)
        {
            return await _context.Sections
                .Include(s => s.Students)
                .Include(s => s.Subject)
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == sectionId);
        }
        public async Task<AttendanceStats> GetStudentAttendanceStatsAsync(int studentId, int sectionId)
        {
            var statusCounts = await _context.AttendanceRecords
                .Where(ar => ar.StudentId == studentId && ar.SectionId == sectionId)
                .GroupBy(ar => ar.Status)
                .Select(g => new
                {
                    Status = g.Key,
                    Count = g.Count()
                })
                .ToListAsync();
            var stats = new AttendanceStats();

            foreach (var item in statusCounts)
            {
                switch (item.Status)
                {
                    case AttendanceStatus.Present:
                        stats.PresentCount = item.Count;
                        break;
                    case AttendanceStatus.Late:
                        stats.LateCount = item.Count;
                        break;
                    case AttendanceStatus.Absent:
                        stats.AbsentCount = item.Count;
                        break;
                    case AttendanceStatus.Excused:
                        stats.ExcusedCount = item.Count;
                        break;
                }
            }
            return stats;
        }
        public async Task<List<Student>> GetStudentsInSectionAsync(int sectionId)
        {
            return await _context.Students
                .Where(st => st.SectionId == sectionId)
                .OrderBy(s => s.LastName)
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<bool> ToggleArchiveStatusAsync(int sectionId)
        {
            var section = await _context.Sections.FindAsync(sectionId);
            if (section == null) return false;
            section.IsArchived = !section.IsArchived;
            _context.Sections.Update(section);
            await _context.SaveChangesAsync();
            return section.IsArchived;
        }
    }
}
