
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.Calificacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Interfaces.Services
{
    public interface ICalificacionService : IGenericService<SaveCalificacionViewModel, CalificacionViewModel>
    {
        Task<LoadCalificacionViewModel> GetStudentQualification(string studentId);
        Task<SaveCalificacionViewModel> GetCalificationForEdit(string studentId);

    }
}
