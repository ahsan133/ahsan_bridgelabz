// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Testing.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace TestCases
{
    using System;
    using EmployeeManagement.Controller;
    using EmployeeManagement.EmployeeManager;
    using Moq;
    using NUnit.Framework;
    using Xunit;

    /// <summary>
    /// Testing class.
    /// </summary>
    public class Testing
    {
        /// <summary>
        /// Adds the test.
        /// </summary>
        [Test]
        public void AddTest()
        {
            var service = new Mock<IEmployeeManager>();
            var controller = new EmployeeController(service.Object);

            string name = "ahsan";
            string email = "ahsan@gmail.com";
            string password = "asddf";
            string address = "qwasd";

            var data = controller.AddEmployees(name, email, password, address);
            NUnit.Framework.Assert.NotNull(data);
            NUnit.Framework.Assert.Pass("Added!!");
        }

        /// <summary>
        /// Updates the test.
        /// </summary>
        [Test]
        public void UpdateTest()
        {
            var service = new Mock<IEmployeeManager>();
            var controller = new EmployeeController(service.Object);

            int userId = 234; 
            string name = "ahsan";
            string email = "ahsan@gmail.com";
            string password = "asddf";
            string address = "qwasd";

            var data = controller.UpdateEmployees(userId, name, email, password, address);
            NUnit.Framework.Assert.NotNull(data);
            NUnit.Framework.Assert.Pass("Updated!!");
        }

        /// <summary>
        /// Deletes the test.
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            var service = new Mock<IEmployeeManager>();
            var controller = new EmployeeController(service.Object);

            int userId = 234;
            var data = controller.DeleteEmployees(userId);
            NUnit.Framework.Assert.NotNull(data);
            NUnit.Framework.Assert.Pass("Deleted!!");
        }

        /// <summary>
        /// Logins the test.
        /// </summary>
        [Test]
        public void LoginTest()
        {
            var service = new Mock<IEmployeeManager>();
            var controller = new EmployeeController(service.Object);

            string email = "assd";
            string password = "ahsan";
            var data = controller.LoginEmployees(email, password);
            NUnit.Framework.Assert.NotNull(data);
            NUnit.Framework.Assert.Pass("Logged In!!");
        }
    }
}
