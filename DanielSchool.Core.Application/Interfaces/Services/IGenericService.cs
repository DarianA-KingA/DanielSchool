using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Interfaces.Services
{
    public interface IGenericService<SaveViewModel, ViewModel>
        where SaveViewModel : class
        where ViewModel : class
    {
        Task<SaveViewModel> Agregar(SaveViewModel vm);
        Task Editar(SaveViewModel vm, int id);
        Task Eliminar(int id);
        Task<SaveViewModel> ObtenerPorIdSaveViewModel(int id);
        Task<ViewModel> ObtenerPorIdViewModel(int id);
        Task<List<ViewModel>> ObtenerTodos();
    }
}
