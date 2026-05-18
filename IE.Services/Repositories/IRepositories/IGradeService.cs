using Brevi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Services.Repositories.IRepositories
{
    public interface IGradeService : IRepository<Grade>
    {
        Task RecalculateGradeAsync(int studentId, int sectionId);
    }
}
