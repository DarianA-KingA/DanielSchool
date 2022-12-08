
using DanielSchool.Core.Application.Dtos.Account;
using DanielSchool.Core.Application.ViewModels.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DanielSchool.Core.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<string> ConfirmEmailAsync(string userId, string token);
        Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordViewModel vm, string origin);
        Task<AuthenticationResponse> LoginAsync(LoginViewModel vm);
        Task<RegisterResponse> RegisterAsync(SaveUserViewModel vm);
        Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordViewModel vm);
        Task SignOutAsync();
        Task<List<ListStudent>> GetStudentByGradeIdAsync(int GradeId);

        Task<List<AuthenticationResponse>> GetUsersAsync();
    }
}