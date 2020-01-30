﻿using FundooManager.Manager;
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

        [HttpPost]
        [Route("api/register")]
        public async Task<ActionResult> Register([FromBody] RegisterModel model)
        {
          var result= await this.user.Regestration(model);
            if (result == 1)
            {
                return this.Ok(model);
            }
            else
            {
                return this.BadRequest();
            }
        }

        [HttpPost]
        [Route("api/login")]
        public async Task<ActionResult> Login([FromBody] LoginModel loginModel)
        {
            var result = await this.user.Login(loginModel);
            if(result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return BadRequest();
            }
           
            //try
            //{
            //    await user.Login(loginModel);
            //    return Ok(loginModel);
            //}
            //catch (Exception e)
            //{
            //    return BadRequest(e.Message);
            //}
        }

        [HttpPut]
        [Route("api/reset")]
        public async Task<ActionResult> Resetpassword([FromBody] ResetPasswordModel reset)
        {
            var result = await user.ResetPassword(reset);
            if (result == "success")
            {
                return this.Ok(reset);
            }
            else
            {
                return this.BadRequest();
            }
        }

        //[HttpPost]
        //[Route("api/forgot")]
        //public async Task<ActionResult> Forgotpassword(ForgotPasswordModel forgot)
        //{
        //    var result =await user.ForgotPassword(forgot);
        //    return Ok(result);
          
        //}
    }
}