// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmployeeManagers.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.EmployeeManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagement.Model;
    using EmployeeManagement.Repository;

    /// <summary>
    /// EmployeeManager class implements IEmployeeManager
    /// </summary>
    /// <seealso cref="EmployeeManagement.EmployeeManager.IEmployeeManager" />
    public class EmployeeManagers : IEmployeeManager
    {
        /// <summary>
        /// The repository
        /// </summary>
        private IRepository repository = new EmployeeData();

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>
        /// Returns a list of all employees.
        /// </returns>
        public IEnumerable<Employee> Get()
        {           
            return this.repository.GetAllEmployee();
        }

        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void Add(Employee employee)
        {
            this.repository.AddEmployee(employee);
        }

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void Update(Employee employee)
        {          
            this.repository.UpdateEmployee(employee);
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Delete(int id)
        {
            this.repository.DeleteEmployee(id);
        }

        /// <summary>
        /// Logins the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// Returns true if email and password exist else false.
        /// </returns>
        public bool Login(string email, string password)
        {
            return this.repository.LoginEmployee(email, password);
        }
    }
}
