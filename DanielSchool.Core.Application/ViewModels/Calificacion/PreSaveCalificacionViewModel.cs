using DanielSchool.Core.Application.Dtos.Qualification;
using DanielSchool.Core.Application.ViewModels.DescCalificacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.ViewModels.Calificacion
{
    public class PreSaveCalificacionViewModel
    {
        public SaveCalificacionViewModel[] Calificacion { get; set; }
        public string StudentId { get; set; }
        public char Condition { get; set; }
        public bool HasError { get; set; }
        public string Error { get; set; }
        public int[,] testing { get; set; }


    }
}
