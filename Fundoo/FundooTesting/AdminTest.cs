using Fundoo.Controllers;
using FundooManager.Interface;
using FundooModels.AdminModels;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FundooTesting
{
    public class AdminTest
    {
        [Fact]
        public void AddAdmin()
        {
            var services = new Mock<IAdminManager>();
            var controller = new AdminController(services.Object);
            var model = new AdminModel()
            {
                FirstName = "md",
                LastName = "ahsan",
                Email = "ahsan@gmail.com",
                Password = "ahsan"
            };

            var data = controller.AddAdmin(model);
            Assert.NotNull(data);
        }

        [Fact]
        public void LoginAdmin()
        {
            var services = new Mock<IAdminManager>();
            var controller = new AdminController(services.Object);
            var model = new AdminModel()
            {
                Email = "ahsan@gmail.com",
                Password = "ahsan"
            };

            var data = controller.AddAdmin(model);
            Assert.NotNull(data);
        }
    }
}
