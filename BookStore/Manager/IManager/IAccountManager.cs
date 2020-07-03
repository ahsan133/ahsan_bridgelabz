using Manager.Managers;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Manager.IManager
{
    public interface IAccountManager 
    {
        string Register(RegisterModel data);
        bool Login(LoginModel data);
    }
}
