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
            /*services.AddTransient<IMejorasPropiedadService, MejorasPropiedadService>();
            services.AddTransient<IMejorasService, MejorasService>();
            services.AddTransient<IPropiedadesFavoritasService, PropiedadesFavoritasService>();
            services.AddTransient<IPropiedadService, PropiedadService>();
            services.AddTransient<ITipoPropiedadService, TipoPropiedadService>();
            services.AddTransient<ITipoVentaService, TipoVentaService>();
            services.AddTransient<IUserService, UserService>();*/
            #endregion
        }
    }
}
