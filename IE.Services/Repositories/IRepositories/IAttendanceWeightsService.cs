using Brevi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Services.Repositories.IRepositories
{
    public interface IAttendanceWeightsService : IRepository<AttendanceWeights>
    {
        Task<AttendanceWeights> GetWeightsAsync();
        Task<bool> SaveWeightsAsync(AttendanceWeights weights);
    }
}
