using DanielSchool.Core.Application.ViewModels.Common;
using DanielSchool.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.ViewModels.DescCalificacion
{
    public class SaveDescCalificacionViewModel:BaseViewModel
    {
        [DataType(DataType.Currency)]
        public int Nota { get; set; }
        [DataType(DataType.Currency)]
        public int PuntosExtras { get; set; }
        [DataType(DataType.Text)]

        public string Comentarios { get; set; }
        public int IdCalification { get; set; }
    }
}
