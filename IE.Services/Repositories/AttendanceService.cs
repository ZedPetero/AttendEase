using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Services.Repositories
{
    public class AttendanceService : Repository<Attendance>, IAttendanceService
    {
        private readonly AppDbContext _context;
        public AttendanceService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Attendance> GetSpecificRecordAsync(int studentId, int sectionId, DateTime date)
        {
            var dayStart = date.Date;
            var dayEnd = dayStart.AddDays(1);
            return await _context.AttendanceRecords.
                FirstOrDefaultAsync(a => a.StudentId == studentId &&
                                         a.SectionId == sectionId &&
                                         a.Date >= dayStart && a.Date < dayEnd);
        }

        public async Task SaveAttendanceAsync(Attendance record)
        {
            var existing = await GetSpecificRecordAsync(record.StudentId, record.SectionId, record.Date);
            if (existing == null) _context.AttendanceRecords.Add(record);
            else existing.Status = record.Status;

            await _context.SaveChangesAsync();
        }
        public async Task MarkAllPresentAsync(int sectionId, DateTime date)
        {
            var students = await _context.Students.Where(s => s.SectionId == sectionId).ToListAsync();
            var dayStart = date.Date;
            var dayEnd = dayStart.AddDays(1);

            foreach (var student in students)
            {
                var existing = await _context.AttendanceRecords
                    .FirstOrDefaultAsync(a => a.StudentId == student.Id && a.SectionId == sectionId && a.Date >= dayStart && a.Date < dayEnd);

                if (existing == null)
                {
                    _context.AttendanceRecords.Add(new Attendance
                    {
                        StudentId = student.Id,
                        SectionId = sectionId,
                        Date = dayStart,
                        Status = AttendanceStatus.Present,
                        Remarks = string.Empty
                    });
                }
                else { existing.Status = AttendanceStatus.Present; }
            }
            await _context.SaveChangesAsync();
        }
        public async Task ResetAttendanceAsync(int sectionId, DateTime date)
        {
            var dayStart = date.Date;
            var dayEnd = dayStart.AddDays(1);
            var recordsToRemove = await _context.AttendanceRecords
                .Where(a => a.SectionId == sectionId && a.Date >= dayStart && a.Date < dayEnd)
                .ToListAsync();
            _context.AttendanceRecords.RemoveRange(recordsToRemove);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Attendance>> GetAllRecordsForSectionAsync(int sectionId)
        {
            return await _context.AttendanceRecords
                .Where(a => a.SectionId == sectionId)
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task<List<Attendance>> GetRecordsForSectionAndDateAsync(int sectionId, DateTime date)
        {
            var dayStart = date.Date;
            var dayEnd = dayStart.AddDays(1);

            return await _context.AttendanceRecords
                .Where(a => a.SectionId == sectionId && a.Date >= dayStart && a.Date < dayEnd)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
