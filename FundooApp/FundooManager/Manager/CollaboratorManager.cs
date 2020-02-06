// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollaboratorManager.cs" company="Bridgelabz">
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
    using FundooModels.Models;
    using FundooRepository.Interfaces;

    /// <summary>
    /// This class is for access Collaborator repository
    /// </summary>
    /// <seealso cref="FundooManager.Interface.ICollaboratorManager" />
    public class CollaboratorManager : ICollaboratorManager
    {
        /// <summary>
        /// The repository
        /// </summary>
        private ICollaboratorRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorManager"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public CollaboratorManager(ICollaboratorRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adds the collaborator.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> AddCollaborator(CollaboratorModel model)
        {
            return this.repository.AddCollaborator(model);
        }

        /// <summary>
        /// Removes the collaborator.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> RemoveCollaborator(int id)
        {
            return this.repository.RemoveCollaborator(id);
        }

        /// <summary>
        /// Gets the specified notes identifier.
        /// </summary>
        /// <param name="notesId">The notes identifier.</param>
        /// <returns>
        /// list of user statistics
        /// </returns>
        public List<CollaboratorModel> Get(int notesId)
        {
            return this.repository.Get(notesId);
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns>
        /// list of user statistics
        /// </returns>
        public List<CollaboratorModel> GetList()
        {
            return this.repository.GetList();
        }
    }
}
