using FundooManager.Manager;
using FundooModels.Models;
using FundooRepository.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundoo.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUserManager user;

        public UserController(IUserManager userManager)
        {
            this.user = userManager;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public ActionResult Register(RegisterModel model)
        {
            try
            {
                user.Regestration(model);
                return Ok(model);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("login")]
        public ActionResult Login(LoginModel loginModel)
        {
            try
            {
                user.Login(loginModel);
                return Ok(loginModel);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("reset")]
        public ActionResult Resetpassword(ResetPasswordModel reset)
        {
            try
            {
                user.ResetPassword(reset);
                return Ok(reset);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("forgot")]
        public ActionResult Forgotpassword(ForgotPasswordModel forgot)
        {
            try
            {
                user.ForgotPassword(forgot);
                return Ok(forgot);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}