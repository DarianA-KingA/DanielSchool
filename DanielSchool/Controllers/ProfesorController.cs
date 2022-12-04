using DanielSchool.Core.Application.Dtos.Account;
using DanielSchool.Core.Application.Enums;
using DanielSchool.Core.Application.Helpers;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.Calificacion;
using DanielSchool.Core.Application.ViewModels.Grado;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
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
            return View();
        }
        public async Task<IActionResult> ListStudent(int idGrade)
        {

            var vm = await _userService.GetStudentByGradeIdAsync(idGrade);

            return View(vm);
        }
        public async Task<IActionResult> EditarNota(string idStudent)
        {
            try
            {
                userViewModel.Action = EnumActionStudent.Qualification.ToString();
                HttpContext.Session.Set<AuthenticationResponse>("user", userViewModel);
                var vm = await _calificacionService.GetCalificationForEdit(idStudent);
                return View(vm);
            }
            catch (NullReferenceException)
            {
                return RedirectToRoute(new { controller = "User", action = "Index" });

            }


        }
        [HttpPost]
        public async Task<IActionResult> EditarNota(PreSaveCalificacionViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                var failedVm = await _calificacionService.GetCalificationForEdit(vm.StudentId);
                return View(failedVm);
            }
            await _calificacionService.EditCalificacion(vm.Calificacion.ToList());
            var response = await _calificacionService.GetCalificationForEdit(vm.StudentId);
            return View(response);
        }
        public IActionResult Test()
        {
            return View();

        }
    }
}
