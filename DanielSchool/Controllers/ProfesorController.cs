using DanielSchool.Core.Application.Dtos.Account;
using DanielSchool.Core.Application.Enums;
using DanielSchool.Core.Application.Helpers;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.Calificacion;
using DanielSchool.Core.Application.ViewModels.Grado;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanielSchool.Controllers
{
    public class ProfesorController : Controller
    {
        private readonly IGradoService _gradoService;
        private readonly IUserService _userService;
        private readonly ICalificacionService _calificacionService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationResponse userViewModel;

        public ProfesorController(IGradoService gradoService, IUserService userService, IHttpContextAccessor httpContextAccessor, ICalificacionService calificacionService)
        {
            _gradoService = gradoService;
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
            _calificacionService = calificacionService;
        }

        public async Task<IActionResult> Index()
        {
            var vm = await _gradoService.ObtenerGradoProfesor();
            var Users = await _userService.GetUsersAsync();
            List<GradoViewModel> NewList = new();
            foreach (var x in vm)
            {
                x.CountStudent = Users.Where(u => u.GradoId == x.Id).Count();
                NewList.Add(x);
            }
            return View(NewList);
        }
        public async Task<IActionResult> ListStudent(int idGrade)
        {
            var vm = await _userService.GetStudentByGradeIdAsync(idGrade);

            return View(vm);
        }
        public async Task<IActionResult> EditarNota(string idStudent)
        {
            userViewModel.Action = EnumActionStudent.Qualification.ToString();
            HttpContext.Session.Set<AuthenticationResponse>("user", userViewModel);
            var vm = await _calificacionService.GetCalificationForEdit(idStudent);
            return View(vm);

        }
        [HttpPost]
        public async Task<IActionResult> EditarNota(PreSaveCalificacionViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                var failedVm = await _calificacionService.GetCalificationForEdit(vm.StudentId);
                failedVm.HasError = true;
                failedVm.Error = "No se aceptan campos vacios, si no va a cambiar algo no lo borre";
                return View(new PreSaveCalificacionViewModel() { });
            }
            for (int m = 0; m < 12; m++)
            {
                for (int s = 0; s < 12; s++)
                {
                    await _calificacionService.Editar(vm.Calificacion[s, m], vm.Calificacion[s, m].Id);
                }
            }
            var response = await _calificacionService.GetCalificationForEdit(vm.StudentId);
            return View(vm);
        }
        public async Task<IActionResult> Test()
        {
            var vm = await _gradoService.ObtenerPorIdViewModel(1);
            return View(vm);

        }
        [HttpPost]
        public async Task<IActionResult> Test(GradoViewModel vm)
        {
            
            return View(vm);
        }
    }
}
