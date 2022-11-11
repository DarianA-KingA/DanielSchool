using AutoMapper;
using DanielSchool.Core.Application.Interfaces.Repositories;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.Grado;
using DanielSchool.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Services
{
    public class GradoService : GenericService<SaveGradoViewModel, GradoViewModel, Grado>, IGradoService
    {
        private readonly IGradoRepository _repository;
        private readonly IMapper _mapper;
        public GradoService(IGradoRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }
    }
}
