using FundooModels.Models;
using FundooRepository.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace FundooRepository.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext context;

        public UserRepository(UserContext context)
        {
            this.context = context;
        }

        public Task Register(RegisterModel registerModel)
        {
            RegisterModel user = new RegisterModel()
            {
                FirstName = registerModel.FirstName,
                LastName = registerModel.LastName,
                Email = registerModel.Email,
                Password = registerModel.Password
            };
            this.context.RegisterModels.Add(user);
            return Task.Run(() => context.SaveChangesAsync());          
        }

        public Task Login(LoginModel loginModel)
        {
            return null;
        }

        public Task ResetPassword(ResetPasswordModel reset)
        {
            return null;
        }

        public Task ForgotPassword(ForgotPasswordModel reset)
        {
            return null;
        }
    }
}