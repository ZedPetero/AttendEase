using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Services.Repositories
{
    public class StudentService : Repository<Student>, IStudentService
    {
        private readonly AppDbContext _context;
        public StudentService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<bool> DeleteStudentAsync(int studentId)
        {
            var student = await _context.Students
                .FirstOrDefaultAsync(s => s.Id == studentId);

            if (student == null) return false;

            _context.Students.Remove(student);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
