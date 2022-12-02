using DanielSchool.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Domain.Entities
{
    public class Calificacion : BaseEntity
    {
        public string Meta { get; set; }
        public int Week { get; set; }
        public int Month { get; set; }
        public string Nota { get; set; }
        public string Comentarios { get; set; }
        public string StudentUserName { get; set; }
        //navitagion property

    }
}
