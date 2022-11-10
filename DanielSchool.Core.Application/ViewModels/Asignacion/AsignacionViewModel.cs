using DanielSchool.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.ViewModels.Asignacion
{
    public class AsignacionViewModel: BaseViewModel
    {
        public int GradoId { get; set; }

        public string Ttle { get; set; }

        public DateTime PublicationDate { get; set; }

        public string Content { get; set; }
    }
}
