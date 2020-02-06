// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAdminRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using FundooModels.AdminModels;

    /// <summary>
    /// This interface is for Admin repository.
    /// </summary>
    public interface IAdminRepository
    {
        /// <summary>
        /// Adds the admin.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>result of task</returns>
        Task AddAdmin(AdminModel model);

        /// <summary>
        /// Logins the admin.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>login result</returns>
        string LoginAdmin(AdminModel model);

        /// <summary>
        /// Gets the user list.
        /// </summary>
        /// <returns>list of user statistics</returns>
        List<AdminUserList> GetUserList();
    }
}
