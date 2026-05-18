using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Collections.Specialized.BitVector32;
namespace Brevi.Services.Repositories
{
    public class GradeService : Repository<Grade>, IGradeService
    {
        private readonly AppDbContext _context;
        private readonly IAttendanceWeightsService _weightsService; 
        public GradeService(AppDbContext context, IAttendanceWeightsService weightsService) : base(context)
        {
            _context = context;
            _weightsService = weightsService;
        }
        public async Task RecalculateGradeAsync(int studentId, int sectionId)
        {
            var records = await _context.AttendanceRecords
                .Where(a => a.StudentId == studentId && a.SectionId == sectionId)
                .ToListAsync();

            if (!records.Any()) return;

            var weights = await _weightsService.GetWeightsAsync() ?? new AttendanceWeights
            {
                PresentWeight = 1.0,
                LateWeight = 0.5,
                ExcusedWeight = 1.0,
                AbsentWeight = 0.0
            };

            double points = records.Sum(r => r.Status switch {
                AttendanceStatus.Present => weights.PresentWeight,
                AttendanceStatus.Late => weights.LateWeight,  
                AttendanceStatus.Excused => weights.ExcusedWeight,
                AttendanceStatus.Absent => weights.AbsentWeight,
                _ => 0.0
            });

            double percentage = records.Count > 0 ? (points / records.Count) * 100.0 : 0;

            var grade = await _context.Grades
                .FirstOrDefaultAsync(g => g.StudentId == studentId && g.SectionId == sectionId);
            if (grade == null)
            {
                var section = await _context.Sections
                    .Include(s => s.Subject) 
                    .FirstOrDefaultAsync(s => s.Id == sectionId);

                if (section == null) return;

                _context.Grades.Add(new Grade
                {
                    StudentId = studentId,
                    SectionId = sectionId,
                    Percentage = percentage,
                    Subject = section.Subject?.Name ?? "Unknown Subject"
                });
            }
            else
            {
                grade.Percentage = percentage;
            }

            await _context.SaveChangesAsync();
        }
    }
}
