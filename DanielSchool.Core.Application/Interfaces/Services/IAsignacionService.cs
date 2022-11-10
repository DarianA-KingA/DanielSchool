
using DanielSchool.Core.Application.ViewModels.Asignacion;
using DanielSchool.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Interfaces.Services
{
    public interface IAsignacionService : IGenericService<SaveAsignacionViewModel, AsignacionViewModel>
    {
    }
}
