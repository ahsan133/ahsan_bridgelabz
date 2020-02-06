// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooManager.Manager
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using FundooModels.Models;
    using FundooRepository.Repository;

    /// <summary>
    /// This class is for access User repository
    /// </summary>
    /// <seealso cref="FundooManager.Manager.IUserManager" />
    public class UserManager : IUserManager
    {
        /// <summary>
        /// The repository
        /// </summary>
        private IUserRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManager"/> class.
        /// </summary>
        /// <param name="userRepository">The user repository.</param>
        public UserManager(IUserRepository userRepository)
        {
            this.repository = userRepository;
        }

        /// <summary>
        /// Register the specified register model.
        /// </summary>
        /// <param name="registerModel">The register model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<int> Regestration(RegisterModel registerModel)
        {
             var result = this.repository.Register(registerModel);
             return result;
        }

        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<RegisterModel> Login(LoginModel loginModel)
        {
            var result = this.repository.Login(loginModel);
            return result;
        }

        /// <summary>
        /// Googles the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<RegisterModel> GoogleLogin(LoginModel loginModel)
        {
            var result = this.repository.GoogleLogin(loginModel);
            return result;
        }

        /// <summary>
        /// Faces the book login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<RegisterModel> FaceBookLogin(LoginModel loginModel)
        {
            var result = this.repository.FaceBookLogin(loginModel);
            return result;
        }

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="reset">The reset.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> ResetPassword(ResetPasswordModel reset)
        {
             var result = this.repository.ResetPassword(reset);
             return result;
        }

        /// <summary>
        /// Forgot the password.
        /// </summary>
        /// <param name="forgot">The forgot.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> ForgotPassword(ForgotPasswordModel forgot)
        {
            var result = this.repository.ForgotPassword(forgot);
            return result;
        }

        /// <summary>
        /// Logouts the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> Logout(string email)
        {
            var result = this.repository.Logout(email);
            return result;
        }

        /// <summary>
        /// Profiles the picture.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> ProfilePicture(int id, string image)
        {
            return this.repository.ProfilePicture(id, image);
        }
    }
}