// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IEmployeeManager.cs" company="Bridgelabz">
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

    /// <summary>
    /// Interface class IEmployeeManager
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>
        /// Returns list of all employees
        /// </returns>
        IEnumerable<Employee> Get();

        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void Add(Employee employee);

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void Update(Employee employee);

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        void Delete(int id);

        /// <summary>
        /// Logins the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// Returns true if email and password exist else false.
        /// </returns>
        bool Login(string email, string password);
    }
}
