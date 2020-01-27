using FundooModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public interface IUserManager
    {
        void Regestration(RegisterModel registerModel);
        void Login(LoginModel loginModel);
        void ResetPassword(ResetPasswordModel reset);
        void ForgotPassword(ForgotPasswordModel forgot);
    }
}
