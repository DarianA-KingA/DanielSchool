using DanielSchool.Core.Application.Dtos.Account;
using DanielSchool.Core.Application.Enums;
using DanielSchool.Core.Application.Helpers;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.Calificacion;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DanielSchool.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationResponse userViewModel;
        private readonly ICalificacionService _calificacionService;
        public EstudianteController(IHttpContextAccessor httpContextAccessor, ICalificacionService calificacionService)
        {
            _httpContextAccessor = httpContextAccessor;
            userViewModel = _httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
            _calificacionService = calificacionService;
        }
        public IActionResult Index()
        {
            //var user = _httpContextAccessor.HttpContext.User;
            userViewModel.Action = EnumActionStudent.Index.ToString();
            HttpContext.Session.Set<AuthenticationResponse>("user", userViewModel);
            return View();
        }
        public async Task<IActionResult> Qualification()
        {
            userViewModel.Action = EnumActionStudent.Qualification.ToString();
            HttpContext.Session.Set<AuthenticationResponse>("user", userViewModel);
            var vm = await _calificacionService.GetStudentQualification(userViewModel.UserName);
            return View(vm);
        }
        public IActionResult Content()
        {
            userViewModel.Action = EnumActionStudent.Content.ToString();
            HttpContext.Session.Set<AuthenticationResponse>("user", userViewModel);
            return View();
        }
        public IActionResult Asignature()
        {
            userViewModel.Action = EnumActionStudent.Asignature.ToString();
            HttpContext.Session.Set<AuthenticationResponse>("user", userViewModel);
            return View();
        }
        public IActionResult Practice()
        {
            userViewModel.Action = EnumActionStudent.Practices.ToString();
            HttpContext.Session.Set<AuthenticationResponse>("user", userViewModel);
            return View();
        }
        public IActionResult Exam()
        {
            userViewModel.Action = EnumActionStudent.Examns.ToString();
            HttpContext.Session.Set<AuthenticationResponse>("user", userViewModel);
            return View();
        }

    }
}
