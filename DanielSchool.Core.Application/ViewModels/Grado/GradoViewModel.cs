using DanielSchool.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.ViewModels.Grado
{
    public class GradoViewModel: BaseViewModel
    {
        public string Name { get; set; }

        public char Section { get; set; }
        public int CountStudent { get; set; }

    }
}
