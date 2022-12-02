using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationLayer(this IServiceCollection services, IConfiguration config)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            //services.AddMediatR(Assembly.GetExecutingAssembly());

            #region Services
            services.AddTransient(typeof(IGenericService<,>), typeof(GenericService<,,>));
            services.AddTransient<INoticiaService,NoticiaService>();
            services.AddTransient<IAsignacionService, AsignacionService>();
            services.AddTransient<ICalificacionService, CalificacionService>();
            services.AddTransient<IGradoService, GradoService>();
            services.AddTransient<IUserService, UserService>();

            #endregion
        }
    }
}
