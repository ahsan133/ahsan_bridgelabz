// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollaboratorRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FundooModels.Models;
    using FundooRepository.Context;
    using FundooRepository.Interfaces;

    /// <summary>
    ///  This class is for Collaborators.
    /// </summary>
    /// <seealso cref="FundooRepository.Interfaces.ICollaboratorRepository" />
    public class CollaboratorRepository : ICollaboratorRepository
    {
        /// <summary>
        /// The context
        /// </summary>
        private UserContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public CollaboratorRepository(UserContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adds the collaborator.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// add Collaborator result
        /// </returns>
        public async Task<string> AddCollaborator(CollaboratorModel model)
        {
            this.context.CollaboratorModels.Add(model);
            await this.context.SaveChangesAsync();
            return "success";
        }

        /// <summary>
        /// Removes the collaborator.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// Remove Collaborator result
        /// </returns>
        public async Task<string> RemoveCollaborator(int id)
        {
            var data = this.context.CollaboratorModels.Where(p => p.Id == id).SingleOrDefault();
            if (data != null)
            {
                this.context.CollaboratorModels.Remove(data);
                await this.context.SaveChangesAsync();
                return "success";
            }

            return null;
        }

        /// <summary>
        /// Gets the specified notes identifier.
        /// </summary>
        /// <param name="notesId">The notes identifier.</param>
        /// <returns>
        /// list of user statistics
        /// </returns>
        /// <exception cref="Exception"></exception>
        public List<CollaboratorModel> Get(int notesId)
        {
            try
            {
                List<CollaboratorModel> list = new List<CollaboratorModel>();
                var result = this.context.CollaboratorModels.Where(p => p.NotesId == notesId).FirstOrDefault();
                if (result != null)
                {
                    var data = from user in this.context.CollaboratorModels where user.NotesId == notesId select user;
                    foreach (var item in data)
                    {
                        list.Add(item);
                    }

                    return list;
                }

                return null;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns>
        /// list of user statistics
        /// </returns>
        /// <exception cref="Exception"></exception>
        public List<CollaboratorModel> GetList()
        {
            try
            {
                return this.context.CollaboratorModels.ToList<CollaboratorModel>();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
