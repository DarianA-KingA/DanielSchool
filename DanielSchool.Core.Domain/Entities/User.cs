using DanielSchool.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Domain.Entities
{
    public class User: BaseEntity
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Usuario { get; set; }

        public string UrlFoto { get; set; }

        public int Password { get; set; }

        public string IdRol { get; set; }

        public string GradoId { get; set; }

        //Navigation property

        public Roles Roles { get; set; }
        public Grado Grado { get; set; }


    }
}
