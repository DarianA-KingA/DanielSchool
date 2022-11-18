using DanielSchool.Core.Application.Enums;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.Grado;
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
        public ProfesorController(IGradoService gradoService, IUserService userService)
        {
            _gradoService = gradoService;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            var vm = await _gradoService.ObtenerGradoProfesor();
            var Users = await _userService.GetUsersAsync();
            List <GradoViewModel> NewList = new(); 
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
    }
}
