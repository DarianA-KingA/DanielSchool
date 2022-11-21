using AutoMapper;
using DanielSchool.Core.Application.Enums;
using DanielSchool.Core.Application.Interfaces.Repositories;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.Calificacion;
using DanielSchool.Core.Application.ViewModels.DescCalificacion;
using DanielSchool.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Services
{
    public class CalificacionService : GenericService<SaveCalificacionViewModel, CalificacionViewModel, Calificacion>, ICalificacionService
    {
        private readonly ICalificacionRepository _repository;
        private readonly IDescCalificacionService _descCalificacionService;
        private readonly IMapper _mapper;
        public CalificacionService(ICalificacionRepository repo, IMapper mapper, IDescCalificacionService descCalificacionService) : base(repo, mapper)
        {
            _repository = repo;
            _mapper = mapper;
            _descCalificacionService = descCalificacionService;
        }
        public async Task<LoadCalificacionViewModel> GetStudentQualification(string studentId)
        {
            LoadCalificacionViewModel result = new() { StudentId = studentId};
            var ListQualification = await base.ObtenerTodos();
            
            var Qualification = ListQualification.Where(q => q.StudentId == studentId).FirstOrDefault();

            var DescCalificacion = await _descCalificacionService.GetDescCalificationByCalificacionIdAsync(Qualification.Id);
           

            var enero = Qualification.Enero.Split(',').ToArray();
            var febrero = Qualification.Frebrero.Split(',').ToArray();
            var marzo = Qualification.Marzo.Split(',').ToArray();
            var abril = Qualification.Abril.Split(',').ToArray();
            var mayo = Qualification.Mayo.Split(',').ToArray();
            var junio = Qualification.Junio.Split(',').ToArray();
            var julio = Qualification.Julio.Split(',').ToArray();
            var agosto = Qualification.Agosto.Split(',').ToArray();
            var septiembre = Qualification.Septiembre.Split(',').ToArray();
            var octubre = Qualification.Octubre.Split(',').ToArray();
            var noviembre = Qualification.Noviembre.Split(',').ToArray();
            var diciembre = Qualification.Diciembre.Split(',').ToArray();
            string[,] orden = new string[4,12];
            for (int i = 0; i < 4; i++)
            {
                orden[i, 0] = agosto[i];
                orden[i, 1] = septiembre[i];
                orden[i, 2] = octubre[i];
                orden[i, 3] = noviembre[i];
                orden[i, 4] = diciembre[i];
                orden[i, 5] = enero[i];
                orden[i, 6] = febrero[i];
                orden[i, 7] = marzo[i];
                orden[i, 8] = abril[i];
                orden[i, 9] = mayo[i];
                orden[i, 10] = junio[i];
                orden[i, 11] = julio[i];

            }
            for (int m = 0; m < 12; m++)
            {
                for (int s = 0; s < 4; s++)
                {
                    


                    result.Month[s, m]= DescCalificacion.Where(q => q.Id.ToString() == orden[s, m]).FirstOrDefault();

                }
            }
            return result;
        }

        public async Task<SaveCalificacionViewModel> GetCalificationForEdit(string studentId)
        {
            var result = await GetStudentQualification(studentId);
            SaveCalificacionViewModel vm = _mapper.Map<SaveCalificacionViewModel>(result);
            return vm;

        }

    }
}
