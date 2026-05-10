using Brevi.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Brevi.Services.Repositories.IRepositories;
using Brevi.Infrastructure.Data;
namespace Brevi.Services.Repositories
{
    public class TeacherService : Repository<Teacher>, ITeacherService
    {
        public TeacherService(AppDbContext context) : base(context)
        {

        }
    }
}
