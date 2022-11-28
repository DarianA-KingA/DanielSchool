using DanielSchool.Core.Application.ViewModels.Common;
using DanielSchool.Core.Application.ViewModels.DescCalificacion;
using DanielSchool.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DanielSchool.Core.Application.ViewModels.Calificacion
{
    public class CalificacionViewModel : BaseViewModel
    {
        public int Week { get; set; }
        public int Month { get; set; }
        public int Nota { get; set; }
        public int PuntosExtras { get; set; }
        public string Comentarios { get; set; }
        public string StudentId { get; set; }

    }

}
