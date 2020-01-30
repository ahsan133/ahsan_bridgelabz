using FundooModels.Models;
using FundooRepository.Context;
using Microsoft.IdentityModel.Tokens;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
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


        public Task<int> Register(RegisterModel registerModel)
        {            
            this.context.RegisterModels.Add(registerModel);
            var result=this.context.SaveChangesAsync();
            return result;      
        }

        public Task<RegisterModel> Login(LoginModel loginModel)
        {
            var result = this.context.RegisterModels.Where(r => r.Email == loginModel.Email).SingleOrDefault();
            if (result != null && this.CheckPassword(loginModel.Email, loginModel.Password))
            {
                try
                {
                    //var tokenDescriptor = new SecurityTokenDescriptor
                    //{
                    //    Subject = new ClaimsIdentity(new Claim[]
                    //    {
                    //        new Claim("Email", loginModel.Email.ToString())
                    //    }),
                    //    Expires = DateTime.UtcNow.AddDays(1),
                    //    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes("12345678987654")), SecurityAlgorithms.HmacSha256)
                    //};

                    //var tokenHandler = new JwtSecurityTokenHandler();
                    //var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    //var token = tokenHandler.WriteToken(securityToken);

                    var cachekey = loginModel.Email;

                    ConnectionMultiplexer connectionMultiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase database = connectionMultiplexer.GetDatabase();
                    database.StringSet(key: cachekey, loginModel.Password);
                    database.StringGet(cachekey);

                    context.SaveChangesAsync();
                    return Task.Run(()=>result);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
            return null;
        }

        public async Task<string> ResetPassword(ResetPasswordModel reset)
        {
            var user = context.RegisterModels.Where(p => p.Email == reset.Email).SingleOrDefault();
            if (user != null)
            {
                if(reset.Password == reset.ConfirmPassword)
                {
                    user.Password = reset.Password;
                    context.Update(user);
                    await Task.Run(() => context.SaveChangesAsync());
                    return "success";
                }
                return "Passwords did not match";
            }
            return "user does not exist";
        }

        public void ForgotPassword(ForgotPasswordModel forgot)
        {
            var user = context.RegisterModels.Where(p => p.Email == forgot.Email).SingleOrDefault();
            if(user != null)
            {
               
            }
        }

        public bool CheckPassword(string email, string password)
        {
            bool result = context.RegisterModels.Where(p => p.Password == password && p.Email == email).SingleOrDefault().Password != null ? true : false;
            return result;
        }
    }
}