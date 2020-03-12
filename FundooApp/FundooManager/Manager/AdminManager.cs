// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdminManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooManager.Manager
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using FundooManager.Interface;
    using FundooModels.AdminModels;
    using FundooRepository.Interfaces;

    /// <summary>
    /// This class is for access Admin repository
    /// </summary>
    /// <seealso cref="FundooManager.Interface.IAdminManager" />
    public class AdminManager : IAdminManager
    {
        /// <summary>
        /// The repository
        /// </summary>
        private IAdminRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminManager"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public AdminManager(IAdminRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adds the admin.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<int> AddAdmin(AdminModel model)
        {
            return this.repository.AddAdmin(model);
        }

        /// <summary>
        /// Logins the admin.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public string LoginAdmin(AdminModel model)
        {
            return this.repository.LoginAdmin(model);
        }

        /// <summary>
        /// Gets the user list.
        /// </summary>
        /// <returns>
        /// list of user statistics
        /// </returns>
        public List<AdminUserList> GetUserList()
        {
            return this.repository.GetUserList();
        }
    }
}
