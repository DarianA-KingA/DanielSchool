using DanielSchool.Core.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Infrastructure.Identity.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FotoUrl { get; set; }
        public int GradoId { get; set; }
        public string GradosACargo { get; set; }
        public string Seccion { get; set; }
        public char Genero { get; set; }
        public DateTime BirthDate { get; set; }


    }
}
