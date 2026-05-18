using Brevi.Domain.DTO;
using Brevi.Domain.Models;
using Brevi.Services.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Services.Repositories.IRepositories
{
    public interface ISectionService : IRepository<Section>
    {
        Task<List<SectionDto>> GetTeacherSectionsAsync(int teacherId, bool includeArchived = false);
        Task<Section?> GetSectionByIdAsync(int sectionId);
        Task<List<Student>> GetStudentsInSectionAsync(int sectionId);
        Task<AttendanceStats> GetStudentAttendanceStatsAsync(int studentId, int sectionId);
        Task<bool> ToggleArchiveStatusAsync(int sectionId);
        Task<bool> DeleteSectionAsync(int sectionId);
    }
}
