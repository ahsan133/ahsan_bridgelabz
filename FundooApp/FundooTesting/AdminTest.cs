// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdminTest.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooTesting
{
    using FundooApp.Controllers;
    using FundooManager.Interface;
    using FundooModels.AdminModels;
    using Moq;
    using Xunit;

    /// <summary>
    /// This class is for test cases of admin controller.
    /// </summary>
    public class AdminTest
    {
        /// <summary>
        /// Adds the admin.
        /// </summary>
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

        /// <summary>
        /// Logins the admin.
        /// </summary>
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
