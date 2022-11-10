using DanielSchool.Core.Application.Interfaces.Repositories;
using DanielSchool.Core.Domain.Entities;
using DanielSchool.Infrastructure.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Infrastructure.Persistence.Repositories
{
    public class GradoRepository : GenericRepository<Grado>, IGradoRepository
    {
        private readonly ApplicationContext _dbContext;

        public GradoRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
