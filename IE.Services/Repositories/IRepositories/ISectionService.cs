using AE.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AE.Domain.Repositories.IRepositories
{
    public interface ISectionService
    {
        Task<List<SectionDto>> GetTeacherSectionsAsync(int teacherId);
    }
}
