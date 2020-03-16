// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILabelRepository.cs" company="Bridgelabz">
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
    using FundooModels.NotesModels;

    /// <summary>
    /// This interface is for Label repository.
    /// </summary>
    public interface ILabelRepository
    {
        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns>add label result</returns>
        Task<int> AddLabel(LabelModel labelModel);

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns>update label result</returns>
        Task<string> UpdateLabel(LabelModel labelModel);

        /// <summary>
        /// Removes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>remove label result</returns>
        Task<string> RemoveLabel(int id);

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>delete label result</returns>
        Task<string> DeleteLabel(int id);

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>list of user statistics</returns>
        List<LabelModel> GetLabel(string email);
    }
}
