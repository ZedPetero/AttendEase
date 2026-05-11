using Brevi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Services.Repositories.IRepositories
{
    public interface ITeacherService : IRepository<Teacher>
    {
        Task<Teacher?> GetTeacherByIdAsync(int teacherId);
        Task<List<Subject>> GetAllSubjectsAsync();
        Task<Subject?> GetSubjectByNameAsync(string subjectName);
        Task<bool> UpdateTeacherProfileAsync(Teacher teacher);
        Task<Subject> CreateSubjectAsync(string subjectName);
    }
}
