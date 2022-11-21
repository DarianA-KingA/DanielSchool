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
        /*   public int Week { get; set; }
           public int Month { get; set; }
           public int Notes { get; set; }*/
        public string Agosto { get; set; }
        public string Septiembre { get; set; }
        public string Octubre { get; set; }
        public string Noviembre { get; set; }
        public string Diciembre { get; set; }
        public string Enero { get; set; }
        public string Frebrero { get; set; }
        public string Marzo { get; set; }
        public string Abril { get; set; }
        public string Mayo { get; set; }
        public string Junio { get; set; }
        public string Julio { get; set; }

        /*public int ExtraPoints { get; set; }
        public string Comentaries { get; set; }*/
        public string StudentId { get; set; }
        //navitagion property

    }
}
