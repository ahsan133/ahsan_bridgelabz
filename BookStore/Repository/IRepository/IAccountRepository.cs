using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.IRepository
{
    public interface IAccountRepository
    {
        string Register(RegisterModel data);
        bool Login(LoginModel data);
    }
}
