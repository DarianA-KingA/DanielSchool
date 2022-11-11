using AutoMapper;
using DanielSchool.Core.Application.Interfaces.Repositories;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.Noticia;
using DanielSchool.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Services
{
    public class NoticiaService : GenericService<SaveNoticiaViewModel, NoticiaViewModel, Noticia>, INoticiaService
    {
        private readonly INoticiaRepository _repository;
        private readonly IMapper _mapper;
        public NoticiaService(INoticiaRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }
    }
}
