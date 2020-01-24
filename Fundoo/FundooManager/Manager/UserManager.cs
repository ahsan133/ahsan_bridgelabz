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
        private readonly IUserRepository repository;

        public UserManager(IUserRepository repository)
        {
            this.repository = repository;
        }

        public bool Regestration(RegisterModel registerModel)
        {
            this.repository.Register(registerModel);
            return true;
        }

        public async Task<bool> Login(LoginModel loginModel)
        {
            await this.repository.Login(loginModel);
            return true;
        }

        public async Task<bool> ResetPassword(ResetPasswordModel reset)
        {
            await this.repository.ResetPassword(reset);
            return true;
        }

        public async Task<bool> ForgotPassword(ForgotPasswordModel forgot)
        {
            await this.repository.ForgotPassword(forgot);
            return true;
        }
    }
}