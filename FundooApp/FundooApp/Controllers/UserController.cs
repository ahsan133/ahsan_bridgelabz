// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using FundooManager.Manager;
    using FundooModels.Models;
    using FundooRepository.Repository;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Class with User controller API.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class UserController : ControllerBase
    {
        /// <summary>
        /// The user
        /// </summary>
        private readonly IUserManager user;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserController"/> class.
        /// </summary>
        /// <param name="userManager">The user manager.</param>
        public UserController(IUserManager userManager)
        {
            this.user = userManager;
        }

        /// <summary>
        /// Registers the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>result of action</returns>
        [HttpPost]
        [Route("api/register")]
        public async Task<ActionResult> Register([FromBody] RegisterModel model)
        {
            var result = await this.user.Regestration(model);
            if (result == 1)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Logins the specified login model.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>result of action</returns>
        [HttpPost]
        [Route("api/login")]
        public async Task<ActionResult> Login([FromBody] LoginModel loginModel)
        {
            var result = await this.user.Login(loginModel);
            if (result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Googles the login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>result of action</returns>
        [HttpPost]
        [Route("api/googleLogin")]
        public async Task<ActionResult> GoogleLogin([FromBody] LoginModel loginModel)
        {
            var result = await this.user.GoogleLogin(loginModel);
            if (result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Faces the book login.
        /// </summary>
        /// <param name="loginModel">The login model.</param>
        /// <returns>result of action</returns>
        [HttpPost]
        [Route("api/fbLogin")]
        public async Task<ActionResult> FaceBookLogin([FromBody] LoginModel loginModel)
        {
            var result = await this.user.FaceBookLogin(loginModel);
            if (result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Reset passwords the specified reset.
        /// </summary>
        /// <param name="reset">The reset.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/reset")]
        public async Task<ActionResult> Resetpassword([FromBody] ResetPasswordModel reset)
        {
            var result = await this.user.ResetPassword(reset);
            if (result == "success")
            {
                return this.Ok(reset);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Forgot passwords the specified forgot.
        /// </summary>
        /// <param name="forgot">The forgot.</param>
        /// <returns>result of action</returns>
        [HttpPost]
        [Route("api/forgot")]
        public async Task<ActionResult> Forgotpassword([FromBody] ForgotPasswordModel forgot)
        {
            var result = await this.user.ForgotPassword(forgot);
            if (result == "success")
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Logouts the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/logout")]
        public async Task<ActionResult> Logout(string email)
        {
            var result = await this.user.Logout(email);
            if (result == "success")
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Profiles the picture.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="image">The image.</param>
        /// <returns>result of action</returns>
        [HttpPost]
        [Route("api/profilePic")]
        public ActionResult ProfilePicture(string email, IFormFile image)
        {
            var result = this.user.ProfilePicture(email, image);
            if (result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Gets the picture
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>result of action</returns>
        [HttpGet]
        [Route("api/getPicture")]
        public ActionResult GetPicture(string email)
        {
            var result = this.user.GetPicture(email);
            if (result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }
    }
}