using AutoMapper;
using DanielSchool.Core.Application.Enums;
using DanielSchool.Core.Application.Interfaces.Repositories;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.Calificacion;
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
        private readonly IMapper _mapper;
        public CalificacionService(ICalificacionRepository repo, IMapper mapper) : base(repo, mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }
        public async Task<List<CalificacionViewModel>> GetStudentQualification(string studentId)
        {
            var Qualification = await _repository.ObtenerEntidades();
            LoadCalificacionViewModel QualificationFiltred = new LoadCalificacionViewModel();
            var QualificationMapped = _mapper.Map<List<CalificacionViewModel>>(Qualification);


            return QualificationMapped;

            /*QualificationFiltred.Agosto = ArrayQualification.Where(x => x.Month == (int)EnumMonth.Agosto).ToList().FirstOrDefault();
            QualificationFiltred.Septiembre = ArrayQualification.Where(x=>x.Month == (int)EnumMonth.Septiembre).ToList().FirstOrDefault();
            QualificationFiltred.Octubre = ArrayQualification.Where(x=>x.Month == (int)EnumMonth.Octubre).ToList().FirstOrDefault();
            QualificationFiltred.Noviembre = ArrayQualification.Where(x=>x.Month == (int)EnumMonth.Noviembre).ToList().FirstOrDefault();
            QualificationFiltred.Diciembre = ArrayQualification.Where(x=>x.Month == (int)EnumMonth.Diciembre).ToList().FirstOrDefault();
            QualificationFiltred.Enero = ArrayQualification.Where(x=>x.Month == (int)EnumMonth.Enero).ToList().FirstOrDefault();
            QualificationFiltred.Frebero = ArrayQualification.Where(x=>x.Month == (int)EnumMonth.Frebrero).ToList().FirstOrDefault();
            QualificationFiltred.Marzo = ArrayQualification.Where(x=>x.Month == (int)EnumMonth.Marzo).ToList().FirstOrDefault();
            QualificationFiltred.Abril = ArrayQualification.Where(x=>x.Month == (int)EnumMonth.Abril).ToList().FirstOrDefault();
            QualificationFiltred.Mayo = ArrayQualification.Where(x=>x.Month == (int)EnumMonth.Marzo).ToList().FirstOrDefault();
            QualificationFiltred.Junio = ArrayQualification.Where(x=>x.Month == (int)EnumMonth.Junio).ToList().FirstOrDefault();
            QualificationFiltred.Julio = ArrayQualification.Where(x=>x.Month == (int)EnumMonth.Julio).ToList().FirstOrDefault();*/

        }

    }
}
