using DanielSchool.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Domain.Entities
{
    public class Noticia : BaseEntity
    {
        public string Title { get; set; }

        public string ImageUrl { get; set; }

        public string Body { get; set; }

        public DateTime Publish { get; set; }

    }
}
