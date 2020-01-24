using FundooManager.Manager;
using FundooModels.Models;
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

        public UserController(IUserManager user)
        {
            this.user = user;
        }


        [HttpPost]
        [Route("api/register")]
        public ActionResult Register(RegisterModel register)
        {
            try
            {
                var result =  user.Regestration(register);
                return Ok(result );
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public ActionResult Login(LoginModel loginModel)
        {
            try
            {
                var result = user.Login(loginModel);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public ActionResult Resetpassword(ResetPasswordModel reset)
        {
            try
            {
                var result = user.ResetPassword(reset);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public ActionResult Forgotpassword(ForgotPasswordModel forgot)
        {
            try
            {
                var result = user.ForgotPassword(forgot);
                return Ok(result);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}