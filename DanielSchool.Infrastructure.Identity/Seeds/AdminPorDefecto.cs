﻿using DanielSchool.Core.Application.Enums;
using DanielSchool.Infrastructure.Identity.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Infrastructure.Identity.Seeds
{
    public static class AdminPorDefecto
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            ApplicationUser defaultUser = new();

            defaultUser.Nombre = "Admin Name";
            defaultUser.Apellido = "Admin LastName";
            defaultUser.UserName = "Administrator";
            defaultUser.Email = "admin@gmail.com";
            defaultUser.EmailConfirmed = true;
            defaultUser.PhoneNumberConfirmed = true;


            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "123Contra$ena");
                    await userManager.AddToRoleAsync(defaultUser, EnumRoles.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, EnumRoles.Profesor.ToString());
                    await userManager.AddToRoleAsync(defaultUser, EnumRoles.Estudiante.ToString());

                }
            }
        }
    }
}