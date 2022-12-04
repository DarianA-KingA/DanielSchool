using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.ViewModels.Calificacion
{
    public class PostCalificationViewModel
    {
        public List<CalificacionViewModel> Calificacion { get; set; }
        public bool[] limite { get; set; } = new bool[12];
    }
}
