// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICollaboratorManager.cs" company="Bridgelabz">
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
    using FundooModels.Models;

    /// <summary>
    /// Interface class of collaborator manager.
    /// </summary>
    public interface ICollaboratorManager
    {
        /// <summary>
        /// Adds the collaborator.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>result of task</returns>
        Task<string> AddCollaborator(CollaboratorModel model);

        /// <summary>
        /// Removes the collaborator.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of task</returns>
        Task<string> RemoveCollaborator(int id);

        /// <summary>
        /// Gets the specified notes identifier.
        /// </summary>
        /// <param name="notesId">The notes identifier.</param>
        /// <returns>list of user statistics</returns>
        List<CollaboratorModel> Get(int notesId);

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns>list of user statistics</returns>
        List<CollaboratorModel> GetList();
    }
}
