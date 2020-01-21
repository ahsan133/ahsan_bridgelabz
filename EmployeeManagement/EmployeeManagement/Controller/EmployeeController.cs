// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagement.EmployeeManager;
    using EmployeeManagement.Model;
    using EmployeeManagement.Utility;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller class
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class EmployeeController : ControllerBase
    {
        /// <summary>
        /// The manager
        /// </summary>
        private IEmployeeManager manager = new EmployeeManagers();

        /// <summary>
        /// The object
        /// </summary>
        private IEmployeeManager @object;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeController"/> class.
        /// </summary>
        /// <param name="object">The object.</param>
        public EmployeeController(IEmployeeManager @object)
        {
            this.@object = @object;
        }

        /// <summary>
        /// Adds the employees.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <param name="address">The address.</param>
        /// <returns>
        /// Returns the result of addition.
        /// </returns>
        [HttpPost]
        [Route("api/add")]
        public ActionResult AddEmployees(string name, string email, string password, string address)
        {
            try
            {
                Employee employee = new Employee();

                employee.UserId = ConnectionString.Random();
                employee.Name = name;
                employee.Email = email;
                employee.Password = password;
                employee.Address = address;
                this.manager.Add(employee);
                return this.Ok(employee);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Deletes the employees.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>
        /// Returns the result of deletion.
        /// </returns>
        [HttpDelete]
        [Route("api/delete")]
        public ActionResult DeleteEmployees(int userId)
        {
            try
            {
                this.manager.Delete(userId);
                return this.Ok(userId);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }          
        }

        /// <summary>
        /// Updates the employees.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <param name="address">The address.</param>
        /// <returns>
        /// Returns the result of updates.
        /// </returns>
        [HttpPut]
        [Route("api/update")]
        public ActionResult UpdateEmployees(int userId, string name, string email, string password, string address)
        {
            try
            {
                Employee employee = new Employee()
                {
                    UserId = userId,
                    Name = name,
                    Email = email,
                    Password = password,
                    Address = address
                };

                this.manager.Update(employee);
                return this.Ok(employee);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Gets the employees.
        /// </summary>
        /// <returns>
        /// Returns list of all employees.
        /// </returns>
        [HttpGet]
        [Route("api/get")]
        public ActionResult GetEmployees()
        {
            try
            {
                IEnumerable<Employee> list = this.manager.Get();
                return this.Ok(list);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Logins the employees.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// Returns the result of logging info.
        /// </returns>
        [HttpPost]
        [Route("api/login")]
        public ActionResult LoginEmployees(string email, string password)
        {
            try
            {
                bool flag = this.manager.Login(email, password);
                    return this.Ok(flag);
            }
            catch (Exception e)
            {
                return this.BadRequest(e.Message);
            }
        }
    }
}