using DanielSchool.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Domain.Entities
{
    public class Grado : BaseEntity
    {
        public string Name { get; set; }

        public char Section { get; set; }
        //navigation properties
        public ICollection<Asignacion> NP_asignations { get; set; }

    }
}
