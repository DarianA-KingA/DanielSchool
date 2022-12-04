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
        public string Meta { get; set; }
        public int Week { get; set; }
        public int Month { get; set; }
        public string Nota { get; set; }
        public string Comentarios { get; set; }
        public string StudentUserName { get; set; }
        public bool Limite { get; set; }

    }

}
