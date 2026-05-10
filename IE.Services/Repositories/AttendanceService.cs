using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Services.Repositories
{
    public class AttendanceService : Repository<Attendance>, IAttendanceService
    {
        public AttendanceService(AppDbContext context) : base(context)
        {
        }
    }
}
