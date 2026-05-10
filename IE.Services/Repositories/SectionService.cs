using System;
using System.Collections.Generic;
using System.Text;
using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;

namespace Brevi.Services.Repositories.IRepositories
{
    public class SectionService : Repository<Section>, ISectionService
    {
        public SectionService(AppDbContext context) : base(context)
        {

        }
    }
}
