using FundooModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public interface IUserRepository
    {
        Task Register(RegisterModel registerModel);

        Task Login(LoginModel loginModel);

        Task ResetPassword(ResetPasswordModel reset);

        Task ForgotPassword(ForgotPasswordModel forgot);
    }

}
