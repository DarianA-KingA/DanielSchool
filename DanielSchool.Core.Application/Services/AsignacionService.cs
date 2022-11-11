using AutoMapper;
using DanielSchool.Core.Application.Interfaces.Repositories;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.Asignacion;
using DanielSchool.Core.Application.ViewModels.Calificacion;
using DanielSchool.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Services
{
    public class AsignacionService : GenericService<SaveAsignacionViewModel, AsignacionViewModel, Asignacion>, IAsignacionService
    {
        private readonly IAsignacionRepository _repository;
        private readonly IMapper _mapper;
        public AsignacionService(IAsignacionRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }

    }
}