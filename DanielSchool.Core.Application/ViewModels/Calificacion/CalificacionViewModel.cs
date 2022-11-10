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
        public int GradoId { get; set; }
        public int Week { get; set; }
        public int Month { get; set; }
        public string Notes { get; set; }
        public string StudentId { get; set; }
    }
}
