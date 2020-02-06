// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdminUserTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooTesting
{
    using FundooApp.Controllers;
    using FundooManager.Manager;
    using FundooModels.Models;
    using Moq;
    using Xunit;

    /// <summary>
    /// This class is for test cases of adminUser controller.
    /// </summary>
    public class AdminUserTest
    {
        /// <summary>
        /// Registrations this instance.
        /// </summary>
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

        /// <summary>
        /// Logins this instance.
        /// </summary>
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

        /// <summary>
        /// Resets the password.
        /// </summary>
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

        /// <summary>
        /// Forgets the password.
        /// </summary>
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

        /// <summary>
        /// Googles the login.
        /// </summary>
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

        /// <summary>
        /// FB the login.
        /// </summary>
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

        /// <summary>
        /// Logouts this instance.
        /// </summary>
        [Fact]
        public void Logout()
        {
            var services = new Mock<IUserManager>();
            var controller = new UserController(services.Object);
            var data = controller.Logout("ahsan@gmail.com");
            Assert.NotNull(data);
        }
    }
}