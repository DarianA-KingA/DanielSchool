using DanielSchool.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Domain.Entities
{
    public class Roles:BaseEntity
    {
        public string Descripcion { get; set; }

        //Navigation Property
        public ICollection<User> Users { get; set; }
    }
}
