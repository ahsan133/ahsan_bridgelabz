using FundooModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public interface IUserManager
    {
        bool Regestration(RegisterModel registerModel);
        Task<bool> Login(LoginModel loginModel);
        Task<bool> ResetPassword(ResetPasswordModel reset);
        Task<bool> ForgotPassword(ForgotPasswordModel forgot);
    }
}
