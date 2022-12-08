using AutoMapper;
using DanielSchool.Core.Application.Dtos.Account;
using DanielSchool.Core.Application.ViewModels.Asignacion;
using DanielSchool.Core.Application.ViewModels.Calificacion;
using DanielSchool.Core.Application.ViewModels.DescCalificacion;
using DanielSchool.Core.Application.ViewModels.Grado;
using DanielSchool.Core.Application.ViewModels.Noticia;
using DanielSchool.Core.Application.ViewModels.User;
using DanielSchool.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<CalificacionViewModel, Calificacion>()
                .ReverseMap();
            CreateMap<PreSaveCalificacionViewModel, SaveCalificacionViewModel>()
                .ReverseMap();

            CreateMap<SaveCalificacionViewModel, Calificacion>()
                .ReverseMap();
            CreateMap<SaveCalificacionViewModel, CalificacionViewModel>()
                .ReverseMap();

            CreateMap<AsignacionViewModel, Asignacion>()
                .ReverseMap();
            CreateMap<SaveAsignacionViewModel, Asignacion>()
                .ReverseMap();

            CreateMap<GradoViewModel, Grado>()
                .ReverseMap();
            CreateMap<SaveGradoViewModel, Grado>()
                .ReverseMap();

            CreateMap<NoticiaViewModel, Noticia>()
                .ReverseMap();
            CreateMap<SaveNoticiaViewModel, Calificacion>()
                .ReverseMap();

            CreateMap<AuthenticationRequest, LoginViewModel>()
               .ForMember(x => x.HasError, opt => opt.Ignore())
               .ForMember(x => x.Error, opt => opt.Ignore())
               .ReverseMap();

            CreateMap<RegisterRequest, SaveUserViewModel>()
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ForMember(x => x.GradoName, opt => opt.Ignore())
                .ForMember(x => x.GradoSection, opt => opt.Ignore())
                .ForMember(x => x.ConfirmPassword, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ForgotPasswordRequest, ForgotPasswordViewModel>()
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ResetPasswordRequest, ResetPasswordViewModel>()
                .ForMember(x => x.HasError, opt => opt.Ignore())
                .ForMember(x => x.Error, opt => opt.Ignore())
                .ReverseMap();

        }
    }
}
