using DanielSchool.Core.Application.Interfaces.Repositories;
using DanielSchool.Infrastructure.Persistence.Contexts;
using DanielSchool.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Infrastructure.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            #region Context
            services.AddDbContext<ApplicationContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
            m => m.MigrationsAssembly(typeof(ApplicationContext).Assembly.FullName)));
            #endregion

            #region Repositories
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<ICalificacionRepository, CalificacionRepository>();
            services.AddTransient<INoticiaRepository, NoticiaRepository>();
            services.AddTransient<IGradoRepository, GradoRepository>();
            services.AddTransient<IAsignacionRepository, AsignacionRepository>();
            services.AddTransient<IDescCalificacionRepository, DescCalificacionRepository>();

            #endregion
        }
    }
}
