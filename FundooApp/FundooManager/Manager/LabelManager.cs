// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelManager.cs" company="Bridgelabz">
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
    using FundooModels.NotesModels;
    using FundooRepository.Interfaces;

    /// <summary>
    /// This class is for access Label repository
    /// </summary>
    /// <seealso cref="FundooManager.Interface.ILabelManager" />
    public class LabelManager : ILabelManager
    {
        /// <summary>
        /// The repository
        /// </summary>
        private ILabelRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelManager"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public LabelManager(ILabelRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<int> AddLabel(LabelModel labelModel)
        {
            var result = this.repository.AddLabel(labelModel);
            return result;
        }

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> UpdateLabel(LabelModel labelModel)
        {
            var result = this.repository.UpdateLabel(labelModel);
            return result;
        }

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> DeleteLabel(int id)
        {
            var result = this.repository.DeleteLabel(id);
            return result;
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// list of user statistics
        /// </returns>
        public List<LabelModel> GetLabel(string email)
        {
            return this.repository.GetLabel(email);
        }
    }
}
