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
        Task<RegisterModel> GoogleLogin(LoginModel loginModel);
        Task<RegisterModel> FaceBookLogin(LoginModel loginModel);
        Task<string> ResetPassword(ResetPasswordModel reset);
        Task<string> ForgotPassword(ForgotPasswordModel forgot);
        Task<string> Logout(string email);
        Task<string> ProfilePicture(int id, string image);
    }
}
