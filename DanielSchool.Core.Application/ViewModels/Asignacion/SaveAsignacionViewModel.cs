using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.ViewModels.Asignacion
{
    public class SaveAsignacionViewModel
    {
        public int GradoId { get; set; }

        public string Ttle { get; set; }

        public DateTime PublicationDate { get; set; }

        public string Content { get; set; }
    }
}
