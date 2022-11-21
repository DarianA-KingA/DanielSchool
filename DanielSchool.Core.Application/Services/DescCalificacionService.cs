using AutoMapper;
using DanielSchool.Core.Application.Interfaces.Repositories;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.DescCalificacion;
using DanielSchool.Core.Application.ViewModels.Noticia;
using DanielSchool.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Services
{
    public class DescCalificacionService : GenericService<SaveDescCalificacionViewModel, DescCalificacionViewModel, DescCalificacion>, IDescCalificacionService
    {
        private readonly IDescCalificacionRepository _repository;
        private readonly IMapper _mapper;
        public DescCalificacionService(IDescCalificacionRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }
        public async Task<List<DescCalificacionViewModel>> GetDescCalificationByCalificacionIdAsync(int idCalificacion)
        {
            var Calification = await base.ObtenerTodos();
            return Calification.Where(c => c.IdCalification == idCalificacion).ToList();
        }
    }
}
