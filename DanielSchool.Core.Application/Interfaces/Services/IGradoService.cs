using DanielSchool.Core.Application.ViewModels.Grado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Interfaces.Services
{
    public interface IGradoService : IGenericService<SaveGradoViewModel, GradoViewModel>
    {
    }
}
