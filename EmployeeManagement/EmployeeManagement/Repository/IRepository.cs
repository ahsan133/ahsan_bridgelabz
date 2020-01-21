// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace EmployeeManagement.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using EmployeeManagement.Model;

    /// <summary>
    /// Interface IRepository.
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns>
        /// Returns a list of all employees.
        /// </returns>
        IEnumerable<Employee> GetAllEmployee();

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void AddEmployee(Employee employee);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void UpdateEmployee(Employee employee);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        void DeleteEmployee(int? userId);

        /// <summary>
        /// Logins the employee.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>
        /// Returns true if email and password exist else false.
        /// </returns>
        bool LoginEmployee(string email, string password);
    }
}