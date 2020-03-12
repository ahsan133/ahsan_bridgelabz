// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdminController.cs" company="Bridgelabz">
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
    using FundooManager.Interface;
    using FundooModels.AdminModels;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Class with Admin controller API.
    /// </summary>
    public class AdminController : ControllerBase
    {
        /// <summary>
        /// Calls the IAdminManager class.
        /// </summary>
        private IAdminManager admin;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminController"/> class.
        /// </summary>
        /// <param name="admin">The admin.</param>
        public AdminController(IAdminManager admin)
        {
            this.admin = admin;
        }

        /// <summary>
        /// adds the admin.
        /// </summary>
        /// <param name="model">The admin.</param>
        /// <returns>result of action</returns>
        [HttpPost]
        [Route("api/addAdmin")]
        public async Task<ActionResult> AddAdmin([FromBody] AdminModel model)
        {
            var result = await this.admin.AddAdmin(model);
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
        /// log in the admin.
        /// </summary>
        /// <param name="model">The admin.</param>
        /// <returns>result of action</returns>
        [HttpPost]
        [Route("api/loginAdmin")]
        public ActionResult LoginAdmin([FromBody] AdminModel model)
        {
            var result = this.admin.LoginAdmin(model);
            if (result != "error")
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// gets the user list.
        /// </summary>
        /// <returns>list of user statistics</returns>
        [HttpGet]
        [Route("api/getUserList")]
        public IEnumerable<AdminUserList> GetUserList()
        {
            var result = this.admin.GetUserList();
            return result;
        }
    }
}