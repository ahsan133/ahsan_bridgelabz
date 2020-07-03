using Manager.IManager;
using Models;
using Repository.IRepository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.Managers
{
    public class AccountManager : IAccountManager
    {
        private IAccountRepository repository = new AccountRepository();


        public string Register(RegisterModel data)
        {
            var result = this.repository.Register(data);
            return result;
        }

        public bool Login(LoginModel data)
        {
            var result = this.repository.Login(data);
            return result;
        }
    }
}
