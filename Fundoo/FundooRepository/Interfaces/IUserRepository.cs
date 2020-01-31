using FundooModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public interface IUserRepository
    {
        Task<int> Register(RegisterModel registerModel);

        Task<RegisterModel> Login(LoginModel loginModel);
        Task<RegisterModel> GoogleLogin(LoginModel loginModel);

        Task<string> ResetPassword(ResetPasswordModel reset);

        Task<string> ForgotPassword(ForgotPasswordModel forgot);

        Task<string> Logout(string email);
    }
}
