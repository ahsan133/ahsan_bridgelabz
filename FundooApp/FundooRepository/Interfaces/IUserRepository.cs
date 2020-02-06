// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUserRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using FundooModels.Models;

    /// <summary>
    /// This interface is for User repository.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Registers the specified register model.
        /// </summary>
        /// <param name="registerModel">The register model.</param>
        /// <returns>register result</returns>
        Task<int> Register(RegisterModel registerModel);

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
        /// <returns>reset password result</returns>
        Task<string> ResetPassword(ResetPasswordModel reset);

        /// <summary>
        /// Forgets the password.
        /// </summary>
        /// <param name="forgot">The forgot.</param>
        /// <returns>forgot password result</returns>
        Task<string> ForgotPassword(ForgotPasswordModel forgot);

        /// <summary>
        /// Logouts the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>logout result</returns>
        Task<string> Logout(string email);

        /// <summary>
        /// Profiles the picture.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns>profile picture result</returns>
        Task<string> ProfilePicture(int id, string image);
    }
}
