using DanielSchool.Core.Application.ViewModels.DescCalificacion;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.ViewModels.Calificacion
{
    public class SaveCalificacionViewModel
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public int Month { get; set; }
        [Required(ErrorMessage = "No se aceptan campos vacios, coloque almenos un 0")]
        [DataType(DataType.Currency)]
        public int Nota { get; set; }
        [Required(ErrorMessage = "No se aceptan campos vacios, coloque almenos un 0")]
        [DataType(DataType.Currency)]
        public int PuntosExtras { get; set; }
        [Required(ErrorMessage = "No se aceptan campos vacios, coloque almenos un N/A")]
        [DataType(DataType.Text)]
        public string Comentarios { get; set; }
        public string StudentId { get; set; }
        public char Condition { get; set; }
    }
}
