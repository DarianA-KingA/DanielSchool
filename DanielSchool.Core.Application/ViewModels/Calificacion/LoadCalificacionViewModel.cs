using DanielSchool.Core.Application.Dtos.Qualification;
using DanielSchool.Core.Application.ViewModels.DescCalificacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.ViewModels.Calificacion
{
    public class LoadCalificacionViewModel
    {
        public DescCalificacionViewModel[,] Month { get; set; } = new DescCalificacionViewModel[4, 12];
        /*public DescCalificacionViewModel[] Agosto { get; set; }
        public DescCalificacionViewModel[] Septiembre { get; set; }
        public DescCalificacionViewModel[] Octubre { get; set; }
        public DescCalificacionViewModel[] Noviembre { get; set; }
        public DescCalificacionViewModel[] Diciembre { get; set; }
        public DescCalificacionViewModel[] Enero { get; set; }
        public DescCalificacionViewModel[] Frebrero { get; set; }
        public DescCalificacionViewModel[] Marzo { get; set; }
        public DescCalificacionViewModel[] Abril { get; set; }
        public DescCalificacionViewModel[] Mayo { get; set; }
        public DescCalificacionViewModel[] Junio { get; set; }
        public DescCalificacionViewModel[] Julio { get; set; }*/
        public string StudentId { get; set; }
        public char Condition { get; set; }

    }
}
