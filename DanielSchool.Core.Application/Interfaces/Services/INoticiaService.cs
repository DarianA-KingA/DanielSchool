﻿
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.Noticia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Interfaces.Services
{
    public interface INoticiaService : IGenericService<SaveNoticiaViewModel, NoticiaViewModel>
    {
    }
}
