// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesManager.cs" company="Bridgelabz">
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
    using FundooModels.NotesModel;
    using FundooRepository.Repository;

    /// <summary>
    /// This class is for access Notes repository
    /// </summary>
    /// <seealso cref="FundooManager.Manager.INotesManager" />
    public class NotesManager : INotesManager
    {
        /// <summary>
        /// The repository
        /// </summary>
        private INotesRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotesManager"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        public NotesManager(INotesRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Adds the notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<int> AddNotes(NotesModel notes)
        {
            var result = this.repository.AddNotes(notes);
            return result;
        }

        /// <summary>
        /// Updates the notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> UpdateNotes(NotesModel notes)
        {
            var result = this.repository.UpdateNotes(notes);
            return result;
        }

        /// <summary>
        /// Removes the notes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> RemoveNotes(int id)
        {
            var result = this.repository.RemoveNotes(id);
            return result;
        }

        /// <summary>
        /// Gets the notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// list of user statistics
        /// </returns>
        public List<NotesModel> GetNotes(string email)
        {
            return this.repository.GetNotes(email);
        }

        /// <summary>
        /// Determines whether the specified identifier is archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task IsArchive(int id)
        {
            return this.repository.IsArchive(id);
        }

        /// <summary>
        /// Removes the archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task UnArchive(int id)
        {
            return this.repository.UnArchive(id);
        }

        /// <summary>
        /// Determines whether the specified identifier is pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task IsPin(int id)
        {
            return this.repository.IsPin(id);
        }

        /// <summary>
        /// Removes the pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task UnPin(int id)
        {
            return this.repository.UnPin(id);
        }

        /// <summary>
        /// Sets the remainder.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="remainder">The remainder.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> SetRemainder(int id, string remainder)
        {
            return this.repository.SetRemainder(id, remainder);
        }

        /// <summary>
        /// Removes the remainder.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="remainder">The remainder.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> RemoveRemainder(int id, string remainder)
        {
            return this.repository.RemoveRemainder(id, remainder);
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns>
        /// list of user statistics
        /// </returns>
        public List<NotesModel> GetList()
        {
            List<NotesModel> list = new List<NotesModel>();

            var getlist = this.repository.GetList();
            foreach (var i in getlist)
            {
                list.Add(i);
            }

            return list;
        }

        /// <summary>
        /// Gets the trash list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// list of user statistics
        /// </returns>
        public List<NotesModel> GetTrashList(string email)
        {
            return this.repository.GetTrashList(email);
        }

        /// <summary>
        /// Gets the archive list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// list of user statistics
        /// </returns>
        public List<NotesModel> GetArchiveList(string email)
        {
            return this.repository.GetArchiveList(email);
        }

        /// <summary>
        /// Restores the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> Restore(int id)
        {
            return this.repository.Restore(id);
        }

        /// <summary>
        /// Restores all.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> RestoreAll(string email)
        {
            return this.repository.RestoreAll(email);
        }

        /// <summary>
        /// Deletes all.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> DeleteAll(string email)
        {
            return this.repository.DeleteAll(email);
        }

        /// <summary>
        /// Colors the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="color">The color.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> Color(int id, string color)
        {
            return this.repository.Color(id, color);
        }

        /// <summary>
        /// Images the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task<string> Image(int id, string image)
        {
            return this.repository.Image(id, image);
        }

        /// <summary>
        /// Determines whether the specified identifier is trash.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task IsTrash(int id)
        {
            return this.repository.IsTrash(id);
        }

        /// <summary>
        /// Drags the and drop.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="dragIndex">Index of the drag.</param>
        /// <param name="dropIndex">Index of the drop.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task DragAndDrop(string email, int dragIndex, int dropIndex)
        {
            return this.repository.DragAndDrop(email, dragIndex, dropIndex);
        }
    }
}
