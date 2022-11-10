using DanielSchool.Core.Application.Enums;
using DanielSchool.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Infrastructure.Identity.Seeds
{
    public static class EstudiantePorDefecto
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultUser = new();
            defaultUser.UserName = "Estudiante_Usuario";
            defaultUser.Email = "darianking12@aoutlook.com";
            defaultUser.Apellido = "Estudiante apellido";
            defaultUser.Nombre = "Estudiante nombre";
            defaultUser.EmailConfirmed = true;
            defaultUser.PhoneNumberConfirmed = true;
            defaultUser.GradoId = 1;

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Contra$ena");
                    await userManager.AddToRoleAsync(defaultUser, EnumRoles.Estudiante.ToString());
                }
            }

        }
    }
    
}
