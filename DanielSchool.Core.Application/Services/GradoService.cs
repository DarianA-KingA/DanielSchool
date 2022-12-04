using AutoMapper;
using DanielSchool.Core.Application.Dtos.Account;
using DanielSchool.Core.Application.Helpers;
using DanielSchool.Core.Application.Interfaces.Repositories;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.Grado;
using DanielSchool.Core.Domain.Entities;
using Microsoft.AspNetCore.Http;
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
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationResponse profesor;
        public GradoService(IGradoRepository repo, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(repo, mapper)
        {
            _repository = repo;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            profesor = _httpContextAccessor.HttpContext.Session.Get<AuthenticationResponse>("user");
        }
        public async Task<List<GradoViewModel>> ObtenerGradoProfesor(AuthenticationResponse teacher)
        {
            var Grades = await base.ObtenerTodos();
            if (teacher.GradosResponsable != string.Empty)
            {
                List<string> ListaGrados = teacher.GradosResponsable.Split(',').ToList();
                List<GradoViewModel> FiltredList = new List<GradoViewModel>();
                foreach (string grado in ListaGrados)
                {
                    var comparador = Grades.Where(g => g.Name == grado);
                    if (comparador.Count() > 0)
                    {
                        foreach (var x in comparador)
                        {
                            FiltredList.Add(x);
                        }
                    }
                }
                return FiltredList;
            }
            return new List<GradoViewModel>();
        }

    }
}
