// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesRepository.cs" company="Bridgelabz">
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
    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using FundooModels.NotesModel;
    using FundooRepository.Context;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// This class is for Notes.
    /// </summary>
    /// <seealso cref="FundooRepository.Repository.INotesRepository" />
    public class NotesRepository : INotesRepository
    {
        /// <summary>
        /// The context
        /// </summary>
        private UserContext context;

        /// <summary>
        /// The configuration
        /// </summary>
        private IConfiguration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotesRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="configuration">The configuration.</param>
        public NotesRepository(UserContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        /// <summary>
        /// Adds the notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <returns>
        /// add notes result
        /// </returns>
        public Task<int> AddNotes(NotesModel notes)
        {
            Random random = new Random();
            NotesModel model = new NotesModel()
            {
                Email = notes.Email,
                Title = notes.Title,
                Description = notes.Description,
                Archive = false,
                Pin = false,
                Trash = false,
                Color = 0.ToString(),
                Remainder = null,
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now
            };

            this.context.NotesModels.Add(model);
            var result = this.context.SaveChangesAsync();
            return result;
        }

        /// <summary>
        /// Updates the notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <returns>
        /// update notes result
        /// </returns>
        public async Task<string> UpdateNotes(NotesModel notes)
        {
            var model = this.context.NotesModels.Where(p => p.Email == notes.Email && p.Id == notes.Id).SingleOrDefault();
            if (model != null)
            {
                model.Title = notes.Title;
                model.Description = notes.Description;
                model.ModifiedTime = DateTime.Now;

                this.context.NotesModels.Update(model);
                await this.context.SaveChangesAsync();
                return "success";
            }
            else
            {
                return "invalid";
            }
        }

        /// <summary>
        /// Removes the notes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// remove notes result
        /// </returns>
        public async Task<string> RemoveNotes(int id)
        {
            var data = this.context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
            if (data != null)
            {
                this.context.NotesModels.Remove(data);
                await this.context.SaveChangesAsync();
                return "success";
            }

            return "no data or invalid id";
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
            List<NotesModel> list = new List<NotesModel>();
            var result = this.context.NotesModels.Where(p => p.Email == email && p.Archive == false && p.Trash == false).FirstOrDefault();
            if (result != null)
            {
                var data = from notes in this.context.NotesModels where notes.Email == email && notes.Archive == false && notes.Trash == false select notes;
                foreach (var items in data)
                {
                    list.Add(items);
                }

                return list;
            }

            return null;
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
            var data = this.context.NotesModels.Where(p => p.Id == id && p.Archive == false).SingleOrDefault();
            if (data != null)
            {
                data.Archive = true;
                return Task.Run(() => this.context.SaveChangesAsync());
            }

            return null;
        }

        /// <summary>
        /// remove the archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task UnArchive(int id)
        {
            var data = this.context.NotesModels.Where(p => p.Id == id && p.Archive == true).SingleOrDefault();
            if (data != null)
            {
                data.Archive = false;
                return Task.Run(() => this.context.SaveChangesAsync());
            }

            return null;
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
            var data = this.context.NotesModels.Where(p => p.Id == id && p.Pin == false).SingleOrDefault();
            if (data != null)
            {
                data.Archive = false;  
                data.Pin = true;
                return Task.Run(() => this.context.SaveChangesAsync());
            }

            return null;
        }

        /// <summary>
        /// remove the pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// result of task
        /// </returns>
        public Task UnPin(int id)
        {
            var data = this.context.NotesModels.Where(p => p.Id == id && p.Pin == true).SingleOrDefault();
            if (data != null)
            {
                data.Pin = true;
                return Task.Run(() => this.context.SaveChangesAsync());
            }

            return null;
        }

        /// <summary>
        /// Sets the remainder.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="remainder">The remainder.</param>
        /// <returns>
        /// set remainder result
        /// </returns>
        public async Task<string> SetRemainder(int id, string remainder)
        {
            var data = this.context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
            if (data != null)
            {
                data.Remainder = remainder;
                data.ModifiedTime = DateTime.Now;
                this.context.NotesModels.Update(data);
                await this.context.SaveChangesAsync();
                return "success";
            }

            return "invalid";
        }

        /// <summary>
        /// Removes the remainder.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="remainder">The remainder.</param>
        /// <returns>
        /// remove remainder result
        /// </returns>
        public async Task<string> RemoveRemainder(int id)
        {
            var data = this.context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
            if (data != null)
            {
                data.Remainder = null;
                data.ModifiedTime = DateTime.Now;
                this.context.NotesModels.Update(data);
                await this.context.SaveChangesAsync();
                return "success";
            }

            return "invalid";
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns>
        /// list of user statistics
        /// </returns>
        public IEnumerable<NotesModel> GetList()
        {
            return this.context.NotesModels.ToList();
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
            List<NotesModel> list = new List<NotesModel>();
            var result = this.context.NotesModels.Where(p => p.Email == email && p.Trash == true).FirstOrDefault();
            if (result != null)
            {
                var data = from user in this.context.NotesModels where user.Email == email && user.Trash == true select user;
                foreach (var item in data)
                {
                    list.Add(item);
                }

                return list;
            }

            return null;
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
            List<NotesModel> list = new List<NotesModel>();
            var result = this.context.NotesModels.Where(p => p.Email == email && p.Archive == true && p.Trash == false).FirstOrDefault();
            if (result != null)
            {
                var data = from user in this.context.NotesModels where user.Email == email && user.Archive == true && user.Trash == false select user;
                foreach (var item in data)
                {
                    list.Add(item);
                }

                return list;
            }

            return null;
        }

        /// <summary>
        /// Gets the remainder list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>list of user statistics</returns>
        public List<NotesModel> GetRemainderList(string email)
        {
            List<NotesModel> list = new List<NotesModel>();
            var result = this.context.NotesModels.Where(p => p.Email == email && p.Remainder != null && p.Trash == false).FirstOrDefault();
            if (result != null)
            {
                var data = from user in this.context.NotesModels where user.Email == email && user.Remainder != null && user.Trash == false select user;
                foreach (var item in data)
                {
                    list.Add(item);
                }

                return list;
            }

            return null;
        }

        /// <summary>
        /// Restores the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// restore result
        /// </returns>
        public async Task<string> Restore(int id)
        {
            var result = this.context.NotesModels.Where(p => p.Id == id && p.Trash == true).SingleOrDefault();
            if (result != null)
            {
                result.Trash = false;
                this.context.NotesModels.Update(result);
                await this.context.SaveChangesAsync();
                return "success";
            }

            return null;
        }

        /// <summary>
        /// Restores all.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// restore all result
        /// </returns>
        public async Task<string> RestoreAll(string email)
        {
            var result = this.context.NotesModels.Where(p => p.Email == email && p.Trash == true).FirstOrDefault();
            if (result != null)
            {
                var data = from user in this.context.NotesModels where user.Email == email && user.Trash == true select user;
                foreach (var item in data)
                {
                    item.Trash = false;
                }

                this.context.NotesModels.Update(result);
                await this.context.SaveChangesAsync();
                return "success";
            }

            return null;
        }

        /// <summary>
        /// Deletes all.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// delete all result
        /// </returns>
        public async Task<string> DeleteAll(string email)
        {
            var result = this.context.NotesModels.Where(p => p.Email == email && p.Trash == true).FirstOrDefault();
            if (result != null)
            {
                var data = from user in this.context.NotesModels where user.Email == email && user.Trash == true select user;
                foreach (var item in data)
                {
                    this.context.NotesModels.Remove(item);
                }

                await this.context.SaveChangesAsync();
                return "success";
            }

            return null;
        }

        /// <summary>
        /// Colors the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="color">The color.</param>
        /// <returns>
        /// color result
        /// </returns>
        public async Task<string> Color(int id, string color)
        {
            var result = this.context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
            if (result != null)
            {
                result.Color = color;
                this.context.NotesModels.Update(result);
                await this.context.SaveChangesAsync();
                return "success";
            }

            return null;
        }

        /// <summary>
        /// Images the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns>
        /// image result
        /// </returns>
        public string Image(int id, IFormFile image)
        {
            try
            {
                var result = image.OpenReadStream();
                var name = image.FileName;
                CloudinaryDotNet.Account account = new CloudinaryDotNet.Account(this.configuration["Cloudinary:Name"], this.configuration["Cloudinary:ApiKey"], this.configuration["Cloudinary:ApiSecret"]);
                CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);
                var uploadParms = new ImageUploadParams()
                {
                    File = new FileDescription(name, result)
                };
                var uploadResult = cloudinary.Upload(uploadParms);

                var data = this.context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
                data.Image = uploadResult.Uri.ToString();
                data.ModifiedTime = DateTime.Now;
                this.context.SaveChanges();
                return data.Image;
            }catch (Exception e)
            {
                return e.Message;
            }
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
            var user = this.context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
            if (user != null)
            {
                user.Trash = true;
                return Task.Run(() => this.context.SaveChangesAsync());
            }

            return null;
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
            var user = this.context.NotesModels.Where(p => p.Email == email).SingleOrDefault();
            if (user != null)
            {
                var data = from item in this.context.NotesModels where item.Email == email select item;
                foreach (var item in data)
                {
                    if (item.Index == dragIndex)
                    {
                        item.Index = dropIndex;
                    }
                    else if (dropIndex > dragIndex)
                    {
                        if (item.Index <= dragIndex && item.Index > dropIndex)
                        {
                            item.Index += 1;
                        }
                    }
                    else if (dropIndex < dragIndex)
                    {
                        if (item.Index < dragIndex && item.Index >= dropIndex)
                        {
                            item.Index -= 1;
                        }
                    }
                }
            }

            return Task.Run(() => this.context.SaveChanges());
        }
    }
}