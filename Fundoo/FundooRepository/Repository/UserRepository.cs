using FundooModels.Models;
using FundooRepository.Context;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;

namespace FundooRepository.Repository
{
    public class UserRepository : IUserRepository
    {
        private UserContext context;

        public UserRepository(UserContext userContext)
        {
            this.context = userContext;
        }


        public void Register(RegisterModel registerModel)
        {
            
            this.context.RegisterModels.Add(registerModel);
            //return Task.Run(() => context.SaveChangesAsync());          
        }

        public Task<RegisterModel> Login(LoginModel loginModel)
        {
            var result = this.FindByEmail(loginModel.Email);
            if (result != null && this.CheckPassword(loginModel.Email, loginModel.Password))
            {
                try
                {
                    var tokenDescription = new SecurityTokenDescriptor
                    {

                    }
                }
                catch(Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
        }

        public void ResetPassword(ResetPasswordModel reset)
        {

        }

        public void ForgotPassword(ForgotPasswordModel forgot)
        {

        }



        public Task<RegisterModel> FindByEmail(string email)
        {
            var user = this.context.RegisterModels.Where(r => r.Email == email).SingleOrDefault();
            return Task.Run(() => user);
        }

        public Task<bool> CheckPassword(string email, string password)
        {
            bool result = context.RegisterModels.Where(p => p.Password == password && p.Email == email).SingleOrDefault().Password != null ? true : false;
            return Task.Run(() => result);
        }
    }
}