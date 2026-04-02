using Brevi.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brevi.Domain.Repositories.IRepositories
{
    public interface ISectionService
    {
        Task<List<SectionDto>> GetTeacherSectionsAsync(int teacherId);
    }
}
