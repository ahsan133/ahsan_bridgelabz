using FundooModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public interface IUserManager
    {
        Task<int> Regestration(RegisterModel registerModel);
        Task<RegisterModel> Login(LoginModel loginModel);
        Task<string> ResetPassword(ResetPasswordModel reset);
        //void ForgotPassword(ForgotPasswordModel forgot);
    }
}
