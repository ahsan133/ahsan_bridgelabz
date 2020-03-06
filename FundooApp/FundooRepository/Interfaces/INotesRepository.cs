// --------------------------------------------------------------------------------------------------------------------
// <copyright file="INotesRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using FundooModels.NotesModel;
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// This interface is for Notes repository.
    /// </summary>
    public interface INotesRepository
    {
        /// <summary>
        /// Adds the notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <returns>add notes result</returns>
        Task<int> AddNotes(NotesModel notes);

        /// <summary>
        /// Updates the notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <returns>update notes result</returns>
        Task<string> UpdateNotes(NotesModel notes);

        /// <summary>
        /// Removes the notes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>remove notes result</returns>
        Task<string> RemoveNotes(int id);

        /// <summary>
        /// Gets the notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>list of user statistics</returns>
        List<NotesModel> GetNotes(string email);

        /// <summary>
        /// Determines whether the specified identifier is archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of task</returns>
        Task IsArchive(int id);

        /// <summary>
        /// remove the archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of task</returns>
        Task UnArchive(int id);

        /// <summary>
        /// Determines whether the specified identifier is pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of task</returns>
        Task IsPin(int id);

        /// <summary>
        /// remove the pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of task</returns>
        Task UnPin(int id);

        /// <summary>
        /// Sets the remainder.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="remainder">The remainder.</param>
        /// <returns>set remainder result</returns>
        Task<string> SetRemainder(int id, string remainder);

        /// <summary>
        /// Removes the remainder.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="remainder">The remainder.</param>
        /// <returns>remove remainder result</returns>
        Task<string> RemoveRemainder(int id);

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns>list of user statistics</returns>
        IEnumerable<NotesModel> GetList();

        /// <summary>
        /// Gets the trash list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>list of user statistics</returns>
        List<NotesModel> GetTrashList(string email);

        /// <summary>
        /// Gets the archive list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>list of user statistics</returns>
        List<NotesModel> GetArchiveList(string email);

        /// <summary>
        /// Gets the remainder list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>list of user statistics</returns>
        List<NotesModel> GetRemainderList(string email);

        /// <summary>
        /// Restores the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>restore result</returns>
        Task<string> Restore(int id);

        /// <summary>
        /// Restores all.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>restore all result</returns>
        Task<string> RestoreAll(string email);

        /// <summary>
        /// Deletes all.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>delete all result</returns>
        Task<string> DeleteAll(string email);

        /// <summary>
        /// Colors the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="color">The color.</param>
        /// <returns>color result</returns>
        Task<string> Color(int id, string color);

        /// <summary>
        /// Images the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns>image result</returns>
        Task<string> Image(int id, IFormFile image);

        /// <summary>
        /// Determines whether the specified identifier is trash.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of task</returns>
        Task IsTrash(int id);

        /// <summary>
        /// Drags the and drop.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="dragIndex">Index of the drag.</param>
        /// <param name="dropIndex">Index of the drop.</param>
        /// <returns>result of task</returns>
        Task DragAndDrop(string email, int dragIndex, int dropIndex);
    }
}