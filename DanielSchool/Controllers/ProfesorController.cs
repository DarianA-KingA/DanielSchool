using DanielSchool.Core.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DanielSchool.Controllers
{
    public class ProfesorController : Controller
    {
        private readonly IGradoService _gradoService;
        public ProfesorController(IGradoService gradoService)
        {
            _gradoService = gradoService; 
        }

        public async Task<IActionResult> Index()
        {
            var vm = await _gradoService.ObtenerGradoProfesor();
            return View(vm);
        }
    }
}
