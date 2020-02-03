using Fundoo.Controllers;
using FundooManager.Manager;
using FundooModels.Models;
using Moq;
using System;
using Xunit;

namespace FundooTesting
{
    public class UserTest
    {
        [Fact]
        public void Registration()
        {
            var services = new Mock<IUserManager>();
            var controller = new UserController(services.Object);
            var input = new RegisterModel()
            {
                FirstName = "md",
                LastName = "ahsan",
                Email = "ahsan@gmail.com",
                Password = "ahsan"
            };
            var data = controller.Register(input);
            Assert.NotNull(data);
        }

        [Fact]
        public void Login()
        {
            var services = new Mock<IUserManager>();
            var controller = new UserController(services.Object);
            var input = new LoginModel()
            {              
                Email = "ahsan@gmail.com",
                Password = "ahsan"
            };
            var data = controller.Login(input);
            Assert.NotNull(data);
        }

        [Fact]
        public void ResetPassword()
        {
            var services = new Mock<IUserManager>();
            var controller = new UserController(services.Object);
            var input = new ResetPasswordModel()
            {
                Email = "ahsan@gmail.com",
                Password = "ahsanmd",
                ConfirmPassword = "ahsanmd"
            };
            var data = controller.Resetpassword(input);
            Assert.NotNull(data);
        }

        [Fact]
        public void ForgotPassword()
        {
            var services = new Mock<IUserManager>();
            var controller = new UserController(services.Object);
            var input = new ForgotPasswordModel()
            {
                Email = "ahsan@gmail.com"
            };
            var data = controller.Forgotpassword(input);
            Assert.NotNull(data);
        }

        [Fact]
        public void GoogleLogin()
        {
            var services = new Mock<IUserManager>();
            var controller = new UserController(services.Object);
            var input = new LoginModel()
            {
                Email = "ahsan@gmail.com",
                Password = "ahsan"
            };
            var data = controller.GoogleLogin(input);
            Assert.NotNull(data);
        }

        [Fact]
        public void FbLogin()
        {
            var services = new Mock<IUserManager>();
            var controller = new UserController(services.Object);
            var input = new LoginModel()
            {
                Email = "ahsan@gmail.com",
                Password = "ahsan"
            };
            var data = controller.FaceBookLogin(input);
            Assert.NotNull(data);
        }
    }
}