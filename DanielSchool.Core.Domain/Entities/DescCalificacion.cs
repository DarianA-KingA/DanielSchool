using DanielSchool.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Domain.Entities
{
                 //Descripcion calificacion
    public class DescCalificacion:BaseEntity
    {
        public int Nota { get; set; }
        public int PuntosExtras { get; set; }
        public string Comentarios { get; set; }
        public int IdCalification { get; set; }

        //navigation property

    }
}
