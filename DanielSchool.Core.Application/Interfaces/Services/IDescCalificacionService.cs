
using DanielSchool.Core.Application.ViewModels.Asignacion;
using DanielSchool.Core.Application.ViewModels.Calificacion;
using DanielSchool.Core.Application.ViewModels.DescCalificacion;
using DanielSchool.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Interfaces.Services
{
    public interface IDescCalificacionService : IGenericService<SaveDescCalificacionViewModel, DescCalificacionViewModel>
    {
        Task<List<DescCalificacionViewModel>> GetDescCalificationByCalificacionIdAsync(int idCalificacion);
    }
}
