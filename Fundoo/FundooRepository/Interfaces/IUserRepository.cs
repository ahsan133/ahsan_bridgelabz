﻿using FundooModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public interface IUserRepository
    {
        Task<int> Register(RegisterModel registerModel);

        Task<RegisterModel> Login(LoginModel loginModel);

        Task<string> ResetPassword(ResetPasswordModel reset);

        void ForgotPassword(ForgotPasswordModel forgot);
    }
}
