using FundooModels.Models;
using FundooRepository.Context;
using Microsoft.IdentityModel.Tokens;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Mail;
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

                    result.Status = true;
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

        public async Task<string> ForgotPassword(ForgotPasswordModel forgot)
        {
            string email = forgot.Email;
            if (email != null)
            {
                RegisterModel user = this.context.RegisterModels.Where<RegisterModel>(selectedItem => selectedItem.Email == email).FirstOrDefault();
                if (user != null)
                {
                    string password = UserRepository.NewPassword();
                    var fromAddress = new MailAddress("mahsanullah512@gmail.com");
                    var fromPassword = "mohammedahsanullah";
                    var toAddress = new MailAddress(forgot.Email);
                    string subject = "New Password";
                    string body = "Your new password is" + " " + password;
                    SmtpClient smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                    };

                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                        try
                        {
                            smtp.Send(message);
                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }

                    user.Password = password;
                    context.Update(user);
                    await Task.Run(() => context.SaveChangesAsync());
                    return "success";
                }
                return null;
            }
            return null;
        }


        public bool CheckPassword(string email, string password)
        {
            bool result = context.RegisterModels.Where(p => p.Password == password && p.Email == email).SingleOrDefault().Password != null ? true : false;
            return result;
        }

        public static string NewPassword()
        {
            Random random = new Random();
            var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
            int max = 100000000;
            int number = random.Next(0, max);
            StringBuilder s = new StringBuilder();
            while (number > 0)
            {
                ////take random characters and add to the string
                s.Append(chars[number % chars.Length]);
                number /= 10;
            }

            return s.ToString();
        }

        public async Task<string> Logout(string email)
        {
            var result = this.context.RegisterModels.Where(r => r.Email == email).SingleOrDefault();
            if(result != null)
            {
                string cachekey = email;
                ConnectionMultiplexer connectionMultiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                IDatabase database = connectionMultiplexer.GetDatabase();
                database.KeyDelete(cachekey);

                result.Status = false;
                await context.SaveChangesAsync();
                return "success";
            }
            return null;
        }


    }
}