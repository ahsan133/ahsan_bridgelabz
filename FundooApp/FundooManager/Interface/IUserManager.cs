// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUserManager.cs" company="Bridgelabz">
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
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// Interface class of User manager.
    /// </summary>
    public interface IUserManager
    {
        /// <summary>
        /// Register the specified register model.
        /// </summary>
        /// <param name="registerModel">The register model.</param>
        /// <returns>result of task</returns>
        Task<int> Regestration(RegisterModel registerModel);

        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>result of task</returns>
        Task<RegisterModel> Login(LoginModel loginModel);

        /// <summary>
        /// Googles the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>result of task</returns>
        Task<RegisterModel> GoogleLogin(LoginModel loginModel);

        /// <summary>
        /// Faces the book login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>result of task</returns>
        Task<RegisterModel> FaceBookLogin(LoginModel loginModel);

        /// <summary>
        /// Resets the password.
        /// </summary>
        /// <param name="reset">The reset.</param>
        /// <returns>result of task</returns>
        Task<string> ResetPassword(ResetPasswordModel reset);

        /// <summary>
        /// Forgot the password.
        /// </summary>
        /// <param name="forgot">The forgot.</param>
        /// <returns>result of task</returns>
        Task<string> ForgotPassword(ForgotPasswordModel forgot);

        /// <summary>
        /// Logouts the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>result of task</returns>
        Task<string> Logout(string email);

        /// <summary>
        /// Profiles the picture.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns>result of task</returns>
        string ProfilePicture(string email, IFormFile image);

        /// <summary>
        /// Gets the picture.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>result of task</returns>
        string GetPicture(string email);

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns>
        /// list of user statistics
        /// </returns>
        List<RegisterModel> GetUsers();
    }
}
