using Brevi.Infrastructure.Data;
using Brevi.Domain.DTO;
using Brevi.Domain.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brevi.Services.Repositories
{
    public class SectionService : ISectionService
    {
        private readonly AppDbContext _context;

        public SectionService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<SectionDto>> GetTeacherSectionsAsync(int teacherId)
        {
            var sections = await _context.Sections
                .Include(s => s.Subject)
                .Where(s => s.TeacherId == teacherId && !s.IsArchived)
                .Select(s => new SectionDto
                {
                    Id = s.Id,
                    SectionName = s.SectionName,
                    SubjectName = s.Subject != null ? s.Subject.Name : "No Subject",
                    StudentCount = s.Students.Count,
                    StartTime = s.StartTimeSchedule,
                    EndTime = s.EndTimeSchedule
                })
                .ToListAsync();

            return sections
                .OrderBy(s => s.StartTime)
                .ToList();
        }
    }
}
