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
    public static class ProfesorPorDefecto
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultUser = new();
            defaultUser.UserName = "Profesor_Usuario";
            defaultUser.Email = "profesor@gmail.com";
            defaultUser.Apellido = "Profesor apellido";
            defaultUser.Nombre = "Profesor nombre";
            defaultUser.EmailConfirmed = true;
            defaultUser.PhoneNumberConfirmed = true;
            defaultUser.GradosACargo = "4to,5to,6to,7mo,8vo,9no,10mo,11vo,12vo";

            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Contra$ena");
                    await userManager.AddToRoleAsync(defaultUser, EnumRoles.Profesor.ToString());
                }
            }

        }
    }
}
