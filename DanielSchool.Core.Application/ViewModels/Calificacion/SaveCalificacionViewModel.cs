using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.ViewModels.Calificacion
{
    public class SaveCalificacionViewModel
    {
        public int GradoId { get; set; }
        public int Week { get; set; }
        public int Month { get; set; }
        public int Notes { get; set; }
        public int ExtraPoints { get; set; }
        public string Comentaries { get; set; }
        public string StudentId { get; set; }
        public string ProfesorId { get; set; }
    }
}
