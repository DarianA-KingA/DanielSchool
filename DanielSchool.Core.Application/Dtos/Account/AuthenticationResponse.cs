using DanielSchool.Core.Application.Enums;
using DanielSchool.Core.Application.ViewModels.Grado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Dtos.Account
{
    public class AuthenticationResponse
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int GradoId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public bool IsVerified { get; set; }
        public bool HasError { get; set; }
        public string Error { get; set; }
        public string Action { get; set; } = EnumActionStudent.Index.ToString();
        public string GradosResponsable { get; set; }
        public char Genero { get; set; }
        public DateTime BirthDate { get; set; }

        public List<GradoViewModel>GradosList { get; set; }
    }
}
