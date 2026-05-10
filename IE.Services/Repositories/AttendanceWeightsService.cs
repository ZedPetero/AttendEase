using System;
using System.Collections.Generic;
using System.Text;
using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories.IRepositories;
namespace Brevi.Services.Repositories
{
    public class AttendanceWeightsService : Repository<AttendanceWeights>, IAttendanceWeightsService
    {
      public AttendanceWeightsService(AppDbContext context) : base(context)
        {

        }
    }
}
