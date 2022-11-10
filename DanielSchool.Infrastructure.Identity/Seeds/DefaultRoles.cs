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
    public static class DefaultRoles
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            await roleManager.CreateAsync(new IdentityRole(EnumRoles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(EnumRoles.Profesor.ToString()));
            await roleManager.CreateAsync(new IdentityRole(EnumRoles.Estudiante.ToString()));
        }
    }
}
