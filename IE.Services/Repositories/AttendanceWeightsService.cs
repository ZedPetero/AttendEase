using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; 
using System.Threading.Tasks; 
using Microsoft.EntityFrameworkCore;
using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories.IRepositories;
namespace Brevi.Services.Repositories
{
    public class AttendanceWeightsService : Repository<AttendanceWeights>, IAttendanceWeightsService
    {
      public AttendanceWeightsService(AppDbContext context) : base(context)
        {
           _context = context;
        }
        private readonly AppDbContext _context;

        public async Task<AttendanceWeights> GetWeightsAsync()
        {
            var weights = await _context.AttendanceWeights.FirstOrDefaultAsync();
            if (weights == null)
            {
                weights = new AttendanceWeights { PresentWeight = 1.0, LateWeight = 0.8, AbsentWeight = 0, ExcusedWeight = 1.0 };
            }
            return weights;
        }

        public async Task<bool> SaveWeightsAsync(AttendanceWeights weights)
        {
            var existing = await _context.AttendanceWeights.FirstOrDefaultAsync();
            if (existing == null) _context.AttendanceWeights.Add(weights);
            else
            {
                existing.PresentWeight = weights.PresentWeight;
                existing.LateWeight = weights.LateWeight;
                existing.AbsentWeight = weights.AbsentWeight;
                existing.ExcusedWeight = weights.ExcusedWeight;
            }
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
