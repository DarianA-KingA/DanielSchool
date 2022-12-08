using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.ViewModels.User
{
    public class SaveUserViewModel
    {   
        [Required(ErrorMessage = "Debe colocar el nombre del usuario")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Debe colocar el apellido del usuario")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Debe colocar un nombre de usuario")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Debe colocar una contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Las contraseñas no coiciden")]
        [Required(ErrorMessage = "Debe colocar una contraseña")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }       

        [Required(ErrorMessage = "Debe colocar un correo")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Phone { get; set; }

        [DataType(DataType.Text)]
        public string Rol { get; set; }

        [Required(ErrorMessage = "Debe colocar un genero")]
        [DataType(DataType.Text)]
        public char Genero { get; set; }
        [Required(ErrorMessage = "Debe colocar su fecha de nacimiento")]
        [DataType(DataType.Text)]
        public string BirthDate { get; set; }

        public string GradoName { get; set; }
        public char GradoSection { get; set; }
        public int GradoId { get; set; }
        public bool HasError { get; set; }
        public string Error { get; set; }
    }
}
