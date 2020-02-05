using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FundooManager.Interface;
using FundooModels.AdminModels;
using Microsoft.AspNetCore.Mvc;

namespace Fundoo.Controllers
{
    public class AdminController : ControllerBase
    {
        private IAdminManager admin;
        public AdminController(IAdminManager admin)
        {
            this.admin = admin;
        }

        [HttpPost]
        [Route("api/addAdmin")]
        public ActionResult AddAdmin(AdminModel model)
        {
            var result = this.admin.AddAdmin(model);
            return Ok(result);
        }

        [HttpPost]
        [Route("api/loginAdmin")]
        public ActionResult LoginAdmin(AdminModel model)
        {
            var result = this.admin.LoginAdmin(model);
            if(result != "error")
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/getUserList")]
        public IEnumerable<AdminModel> GetUserList()
        {
            var result = this.admin.GetUserList();
            return result;
        }
    }
}