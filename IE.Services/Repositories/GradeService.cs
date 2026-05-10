using System;
using System.Collections.Generic;
using System.Text;
using Brevi.Domain.Models;
using Brevi.Infrastructure.Data;
using Brevi.Services.Repositories.IRepositories;
namespace Brevi.Services.Repositories.IRepositories
{
    public class GradeService : Repository<Grade>, IGradeService
    {
      public GradeService(AppDbContext context) : base(context)
        {

        }
    }
}
