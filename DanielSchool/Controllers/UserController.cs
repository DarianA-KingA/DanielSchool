using DanielSchool.Core.Application.Dtos.Account;
using DanielSchool.Core.Application.Enums;
using DanielSchool.Core.Application.Helpers;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanielSchool.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly IGradoService _gradoService;

        public UserController(IUserService userService, IGradoService gradoService)
        {
            _userService = userService;
            _gradoService = gradoService;
        }
        public IActionResult Index()
        {
            return View("Login", new LoginViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                if (vm.Password != null) { vm.Password.Remove(vm.Password.Length); }
                return View("Login", vm);
            }
            AuthenticationResponse response = await _userService.LoginAsync(vm);
            if (!response.HasError || response != null)
            {
                if (response.Roles.Contains(EnumRoles.Admin.ToString()))
                {
                    HttpContext.Session.Set<AuthenticationResponse>("user", response);
                    return RedirectToRoute(new { controller = "Admin", action = "Index" });
                }
                if (response.Roles.Contains(EnumRoles.Profesor.ToString()))
                {
                    response.GradosList = await _gradoService.ObtenerGradoProfesor(response);
                    HttpContext.Session.Set<AuthenticationResponse>("user", response);
                    return RedirectToRoute(new { controller = "Profesor", action = "Index" });
                }
                if (response.Roles.Contains(EnumRoles.Estudiante.ToString()))
                {
                    HttpContext.Session.Set<AuthenticationResponse>("user", response);
                    return RedirectToRoute(new { controller = "Estudiante", action = "Index" });
                }

                vm.HasError = true;
                vm.Error = "Some how your roles list is out of the registered roles, comunicate with support assistance";
                return View(vm);
            }
            vm.HasError = response.HasError;
            vm.Error = response.Error;
            if (vm.Password != null) { vm.Password.Remove(vm.Password.Length - 1); }
            return View("Login", vm);
        }
        public async Task<IActionResult> LogOut()
        {
            await _userService.SignOutAsync();
            HttpContext.Session.Remove("user");
            return RedirectToRoute(new { controller = "User", action = "Index" });
        }
    }
}
