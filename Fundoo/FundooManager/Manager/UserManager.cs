using FundooModels.Models;
using FundooRepository.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public class UserManager : IUserManager
    {
        private IUserRepository repository;

        public UserManager(IUserRepository userRepository)
        {
            this.repository = userRepository;
        }

        public Task<int> Regestration(RegisterModel registerModel)
        {
             var result = this.repository.Register(registerModel);
             return result;
        }

        public Task<RegisterModel> Login(LoginModel loginModel)
        {
            var result = this.repository.Login(loginModel);
            return result;
        }

        public Task<RegisterModel> GoogleLogin(LoginModel loginModel)
        {
            var result = this.repository.GoogleLogin(loginModel);
            return result;
        }

        public Task<string> ResetPassword(ResetPasswordModel reset)
        {
             var result = this.repository.ResetPassword(reset);
             return result;
        }

        public Task<string> ForgotPassword(ForgotPasswordModel forgot)
        {
            var result = this.repository.ForgotPassword(forgot);
            return result;
        }

        public Task<string> Logout(string email)
        {
            var result = this.repository.Logout(email);
            return result;
        }
    }
}