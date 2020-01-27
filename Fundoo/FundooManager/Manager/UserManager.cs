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

        public void Regestration(RegisterModel registerModel)
        {
             this.repository.Register(registerModel);
        }

        public void Login(LoginModel loginModel)
        {
             this.repository.Login(loginModel);
        }

        public void ResetPassword(ResetPasswordModel reset)
        {
             this.repository.ResetPassword(reset);         
        }

        public void ForgotPassword(ForgotPasswordModel forgot)
        {
             this.repository.ForgotPassword(forgot);
        }
    }
}