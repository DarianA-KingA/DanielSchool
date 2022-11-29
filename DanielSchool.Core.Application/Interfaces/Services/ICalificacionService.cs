
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
        Task<List<CalificacionViewModel>> GetStudentQualification(string studentId);
        Task<PreSaveCalificacionViewModel> GetCalificationForEdit(string studentId);
        Task EditCalificacion(List<SaveCalificacionViewModel> vm);

    }
}
