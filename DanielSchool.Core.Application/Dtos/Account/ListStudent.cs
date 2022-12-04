using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Dtos.Account
{
    public class ListStudent
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<string> Roles { get; set; }
        public int GradoId { get; set; }
        public string UserName { get; set; }
        public string Section { get; set; }



    }
}
