using FundooModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public interface IUserRepository
    {
        void Register(RegisterModel registerModel);

        Task<RegisterModel> Login(LoginModel loginModel);

        void ResetPassword(ResetPasswordModel reset);

        void ForgotPassword(ForgotPasswordModel forgot);
    }
}
