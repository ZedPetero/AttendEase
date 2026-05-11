using Brevi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Brevi.Services.Repositories.IRepositories;
using Brevi.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
namespace Brevi.Services.Repositories
{
    public class TeacherService : Repository<Teacher>, ITeacherService
    {
        private readonly AppDbContext _context;
        public TeacherService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Teacher?> GetTeacherByIdAsync(int teacherId)
        {
            return await _context.Teachers
                .Include(s => s.Subject)
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.Id == teacherId);
        }
        public async Task<List<Subject>> GetAllSubjectsAsync()
        {
            return await _context.Subjects
                .OrderBy(s => s.Name)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Subject?> GetSubjectByNameAsync(string name)
        {
            return await _context.Subjects
                .FirstOrDefaultAsync(s => s.Name.ToLower() == name.ToLower());
        }

        public async Task<bool> UpdateTeacherProfileAsync(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Subject> CreateSubjectAsync(string subjectName)
        {
            var subject = new Subject { Name = subjectName };
            _context.Subjects.Add(subject);
            await _context.SaveChangesAsync();
            return subject;
        }
    }
}