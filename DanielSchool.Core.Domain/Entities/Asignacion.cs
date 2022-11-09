using DanielSchool.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Domain.Entities
{
    public class Asignacion : BaseEntity
    {
        public int GradoId { get; set; }

        public string Ttle { get; set; }

        public DateTime PublicationDate { get; set; }

        public string Content { get; set; }

        //navigation properties
        public Grado NP_grado { get; set; }


    }
}
