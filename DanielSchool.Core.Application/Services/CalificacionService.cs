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
        public async Task<LoadCalificacionViewModel> GetStudentQualification(string studentId)
        {
            var Qualification = await _repository.ObtenerEntidades();
            LoadCalificacionViewModel QualificationFiltred = new LoadCalificacionViewModel();
            var QualificationMapped = _mapper.Map<List<CalificacionViewModel>>(Qualification);
            var ArrayQualification = QualificationMapped.ToList().Where(x=>x.StudentId == studentId);
            if (ArrayQualification.Count() > 0)
            {
                for (int x = 0; x < 12; x++)
                {
                    for (int y = 0; y < 12; y++)
                    {
                        QualificationFiltred.Month[x, y] = ArrayQualification.Where(Q => Q.Month == x + 1 && Q.Week == y + 1).ToArray().FirstOrDefault();
                    }
                }
                return QualificationFiltred;

            }
            return  new LoadCalificacionViewModel();

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
