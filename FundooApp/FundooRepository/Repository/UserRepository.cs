// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Repository
{
    using System;
    using System.Collections.Generic;
    using System.IdentityModel.Tokens.Jwt;
    using System.Linq;
    using System.Net.Mail;
    using System.Security.Claims;
    using System.Text;
    using System.Threading.Tasks;
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using FundooModels.AdminModels;
    using FundooModels.Models;
    using FundooRepository.Context;
    using Microsoft.Extensions.Configuration;
    using Microsoft.IdentityModel.Tokens;
    using StackExchange.Redis;

    /// <summary>
    /// This class is for User.
    /// </summary>
    /// <seealso cref="FundooRepository.Repository.IUserRepository" />
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// The context
        /// </summary>
        private UserContext context;

        /// <summary>
        /// The configuration
        /// </summary>
        private readonly IConfiguration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="userContext">The user context.</param>
        /// <param name="configuration">The configuration.</param>
        public UserRepository(UserContext userContext, IConfiguration configuration)
        {
            this.context = userContext;
            this.configuration = configuration;
        }

        /// <summary>
        /// Creates new password.
        /// </summary>
        /// <returns>NewPassword result</returns>
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

        /// <summary>
        /// Registers the specified register model.
        /// </summary>
        /// <param name="registerModel">The register model.</param>
        /// <returns>
        /// register result
        /// </returns>
        public Task<int> Register(RegisterModel registerModel)
        { 
            this.context.RegisterModels.Add(registerModel);
            var result = this.context.SaveChangesAsync();
            return result;      
        }

        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        /// <exception cref="Exception"></exception>
        public Task<RegisterModel> Login(LoginModel loginModel)
        {
            var result = this.context.RegisterModels.Where(r => r.Email == loginModel.Email).SingleOrDefault();
            if (result != null && this.CheckPassword(loginModel.Email, loginModel.Password))
            {
                try
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim("Email", loginModel.Email.ToString())
                        }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["Jwt:SecureKey"])), SecurityAlgorithms.HmacSha256)
                    };

                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);

                    var cachekey = loginModel.Email;

                    ConnectionMultiplexer connectionMultiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase database = connectionMultiplexer.GetDatabase();
                    database.StringSet(key: cachekey, token);
                    database.StringGet(cachekey);

                    result.Status = true;
                    var data = new AdminUserList()
                    {
                        Email = loginModel.Email,
                        LoginTime = DateTime.Now
                    };

                    this.context.AdminUsers.Add(data);
                    this.context.SaveChangesAsync();
                    return Task.Run(() => result);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            return null;
        }

        /// <summary>
        /// Googles the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        /// <exception cref="Exception"></exception>
        public async Task<RegisterModel> GoogleLogin(LoginModel loginModel)
        {
            var result = this.context.RegisterModels.Where(r => r.Email == loginModel.Email).SingleOrDefault();
            if (result != null)
            {
                try
                {
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["Jwt:SecureKey"]));
                    var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        expires: DateTime.Now.AddDays(1),
                        signingCredentials: credential);

                    var cacheKey = loginModel.Email;

                    ConnectionMultiplexer connection = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase database = connection.GetDatabase();
                    database.StringSet(cacheKey, token.ToString());
                    database.StringGet(cacheKey);

                    result.Status = true;
                    await this.context.SaveChangesAsync();
                    return result;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            return null;
        }

        /// <summary>
        /// Faces the book login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        /// <exception cref="Exception"></exception>
        public async Task<RegisterModel> FaceBookLogin(LoginModel loginModel)
        {
            var result = this.context.RegisterModels.Where(r => r.Email == loginModel.Email).SingleOrDefault();
            if (result != null)
            {
                try
                {
                    var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.configuration["Jwt:SecureKey"]));
                    var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                    var token = new JwtSecurityToken(
                        expires: DateTime.Now.AddDays(1),
                        signingCredentials: credential);

                    var cacheKey = loginModel.Email;

                    ConnectionMultiplexer connection = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                    IDatabase database = connection.GetDatabase();
                    database.StringSet(cacheKey, token.ToString());
                    database.StringGet(cacheKey);

                    result.Status = true;
                    await this.context.SaveChangesAsync();
                    return result;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            return null;
        }

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="reset">The reset.</param>
        /// <returns>
        /// reset password result
        /// </returns>
        public async Task<string> ResetPassword(ResetPasswordModel reset)
        {
            var user = this.context.RegisterModels.Where(p => p.Email == reset.Email).SingleOrDefault();
            if (user != null)
            {
                if (reset.Password == reset.ConfirmPassword)
                {
                    user.Password = reset.Password;
                    this.context.Update(user);
                    await Task.Run(() => this.context.SaveChangesAsync());
                    return "success";
                }

                return "Passwords did not match";
            }

            return "user does not exist";
        }

        /// <summary>
        /// Forgets the password.
        /// </summary>
        /// <param name="forgot">The forgot.</param>
        /// <returns>
        /// forgot password result
        /// </returns>
        /// <exception cref="Exception"></exception>
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
                    {
                        try
                        {
                            smtp.Send(message);
                        }
                        catch (Exception e)
                        {
                            throw new Exception(e.Message);
                        }
                    }   
                     
                    user.Password = password;
                    this.context.Update(user);
                    await Task.Run(() => this.context.SaveChangesAsync());
                    return "success";
                }

                return null;
            }

            return null;
        }

        /// <summary>
        /// Checks the password.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>check password result</returns>
        public bool CheckPassword(string email, string password)
        {
            bool result = this.context.RegisterModels.Where(p => p.Password == password && p.Email == email).SingleOrDefault().Password != null ? true : false;
            return result;
        }
       
        /// <summary>
        /// Logouts the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// logout result
        /// </returns>
        public async Task<string> Logout(string email)
        {
            var result = this.context.RegisterModels.Where(r => r.Email == email).SingleOrDefault();
            if (result != null)
            {
                string cachekey = email;
                ConnectionMultiplexer connectionMultiplexer = ConnectionMultiplexer.Connect("127.0.0.1:6379");
                IDatabase database = connectionMultiplexer.GetDatabase();
                database.KeyDelete(cachekey);

                result.Status = false;
                await this.context.SaveChangesAsync();
                return "success";
            }

            return null;
        }

        /// <summary>
        /// Profiles the picture.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns>
        /// profile picture result
        /// </returns>
        public async Task<string> ProfilePicture(int id, string image)
        {
            CloudinaryDotNet.Account account = new CloudinaryDotNet.Account(this.configuration["Cloudinary:Name"], this.configuration["Cloudinarty:ApiKey"], this.configuration["Cloudinary:ApiSecret"]);
            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);
            var upload = new ImageUploadParams()
            {
                File = new FileDescription(image)
            };
            var uploadResult = cloudinary.Upload(upload);

            var data = this.context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
            data.Image = uploadResult.Uri.ToString();
            data.ModifiedTime = DateTime.Now;
            await this.context.SaveChangesAsync();
            return data.Image;
        }
    }
}