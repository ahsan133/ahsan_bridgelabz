using Manager.IManager;
using Manager.Managers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class AccountController : Controller
    {
        private IAccountManager manager = new AccountManager();

        [HttpPost]
        [Route("Account/Register")]
        public ActionResult Register(RegisterModel data)
        {   
            this.manager.Register(data);
            return Json(HttpStatusCode.OK);
        }

        [HttpGet]
        public ActionResult Login(LoginModel data)
        {
            this.manager.Login(data);
            return Json(HttpStatusCode.OK);
        }
    }
}