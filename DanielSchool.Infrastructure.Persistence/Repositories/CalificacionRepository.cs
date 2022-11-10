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
    public class CalificacionRepository : GenericRepository<Calificacion>, ICalificacionRepository
    {
        private readonly ApplicationContext _dbContext;

        public CalificacionRepository(ApplicationContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


    }
}
