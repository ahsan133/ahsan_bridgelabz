// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAdminManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooManager.Interface
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using FundooModels.AdminModels;

    /// <summary>
    /// Interface class of admin manager.
    /// </summary>
    public interface IAdminManager
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
        /// <returns>result of task</returns>
        string LoginAdmin(AdminModel model);

        /// <summary>
        /// Gets the user list.
        /// </summary>
        /// <returns>list of user statistics</returns>
        List<AdminUserList> GetUserList();
    }
}
