﻿using AutoMapper;
using DanielSchool.Core.Application.Dtos.Account;
using DanielSchool.Core.Application.Enums;
using DanielSchool.Core.Application.Interfaces.Services;
using DanielSchool.Core.Application.ViewModels.User;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;
        private readonly IGradoService _gradoService;

        public UserService(IAccountService accountService, IMapper mapper, IGradoService gradoService)
        {
            _accountService = accountService;
            _mapper = mapper;
            _gradoService = gradoService;
        }

        public async Task<AuthenticationResponse> LoginAsync(LoginViewModel vm)
        {
            AuthenticationRequest loginRequest = _mapper.Map<AuthenticationRequest>(vm);
            AuthenticationResponse userResponse = await _accountService.AuthenticateAsync(loginRequest);
            return userResponse;
        }
        public async Task SignOutAsync()
        {
            await _accountService.SignOutAsync();
        }

        public async Task<RegisterResponse> RegisterAsync(SaveUserViewModel vm)
        {
            RegisterRequest registerRequest = _mapper.Map<RegisterRequest>(vm);
            vm.Rol = EnumRoles.Estudiante.ToString();
            var grado = await _gradoService.ObtenerTodos();
            registerRequest.GradoId = grado.Where(G => G.Name == vm.GradoName && G.Section == vm.GradoSection).FirstOrDefault().Id;
            var dateSplit = vm.BirthDate.Split('/');
            registerRequest.BirthDate = dateSplit[1] + "/" + dateSplit[0] + "/" + dateSplit[2];
            return await _accountService.RegisterUserAsync(registerRequest, vm.Rol);
        }

        public async Task<string> ConfirmEmailAsync(string userId, string token)
        {
            return await _accountService.ConfirmAccountAsync(userId, token);
        }

        public async Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordViewModel vm, string origin)
        {
            ForgotPasswordRequest forgotRequest = _mapper.Map<ForgotPasswordRequest>(vm);
            return await _accountService.ForgotPasswordAsync(forgotRequest, origin);
        }

        public async Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordViewModel vm)
        {
            ResetPasswordRequest resetRequest = _mapper.Map<ResetPasswordRequest>(vm);
            return await _accountService.ResetPasswordAsync(resetRequest);
        }

        public async Task<List<ListStudent>> GetStudentByGradeIdAsync(int GradeId)
        {
            var student = await _accountService.GetStudentByGradeId(GradeId);
            return student;
        }
        public async Task<List<AuthenticationResponse>> GetUsersAsync()
        {
            var User = await _accountService.GetUsersAsync();
            return User;
        }
    }
}
