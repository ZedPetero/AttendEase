using AE.Domain.DTO;
using AE.Infrastructure.Data;
using AE.Domain.DTO;
using AE.Domain.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            .Where(s => s.TeacherId == teacherId && !s.IsArchived)
            .Select(s => new SectionDto
            {
                Id = s.Id,
                SectionName = s.SectionName,
                SubjectName = s.Subject.ToString(),
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