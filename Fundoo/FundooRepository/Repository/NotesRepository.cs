using FundooModels.NotesModel;
using FundooRepository.Context;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;

namespace FundooRepository.Repository
{
    public class NotesRepository : INotesRepository
    {
        private UserContext context;
        private IConfiguration configuration;

        public NotesRepository(UserContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

      
        public Task<int> AddNotes(NotesModel notes)
        {
            Random random = new Random();
            NotesModel model = new NotesModel()
            {
                Id = random.Next(9999),
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

        public async Task<string> UpdateNotes(NotesModel notes)
        {
            var model = context.NotesModels.Where(p => p.Email == notes.Email).SingleOrDefault();
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

        public async Task<string> RemoveNotes(int id)
        {
            var data = context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
            if(data != null)
            {
                context.NotesModels.Remove(data);
                await this.context.SaveChangesAsync();
                return "success";
            }
            return "no data or invalid id";
        }

        public List<NotesModel> GetNotes(string email)
        {
            List<NotesModel> list = new List<NotesModel>();
            var result = context.NotesModels.Where(p => p.Email == email && p.Archive == false && p.Trash == false).FirstOrDefault();
            if(result != null)
            {
                var data = from notes in this.context.NotesModels where notes.Email == email && notes.Archive == false && notes.Trash == false select notes;
                foreach(var items in data)
                {
                    list.Add(items);
                }
                return list;
            }
            return null;
        }

        public Task IsArchive(int id)
        {
            var data = context.NotesModels.Where(p => p.Id == id && p.Archive == false).SingleOrDefault();
            if (data != null)
            {
                data.Archive = true;
                return Task.Run(() => context.SaveChangesAsync());
            }

            return null;
        }

        public Task UnArchive(int id)
        {
            var data = context.NotesModels.Where(p => p.Id == id && p.Archive == true).SingleOrDefault();
            if (data != null)
            {
                data.Archive = false;
                return Task.Run(() => context.SaveChangesAsync());
            }

            return null;
        }

        public Task IsPin(int id)
        {
            var data = context.NotesModels.Where(p => p.Id == id && p.Pin == false).SingleOrDefault();
            if (data != null)
            {
                data.Pin = true;
                return Task.Run(() => context.SaveChangesAsync());
            }

            return null;
        }

        public Task UnPin(int id)
        {
            var data = context.NotesModels.Where(p => p.Id == id && p.Pin == false).SingleOrDefault();
            if (data != null)
            {
                data.Pin = true;
                return Task.Run(() => context.SaveChangesAsync());
            }

            return null;
        }

        public async Task<string> SetRemainder(int id, string remainder)
        {
            var data = context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
            if (data != null)
            {
                data.Remainder = remainder;
                data.ModifiedTime = DateTime.Now;
                context.NotesModels.Update(data);
                await this.context.SaveChangesAsync();
                return "success";
            }
            return "invalid";
        }

        public async Task<string> RemoveRemainder(int id, string remainder)
        {
            var data = context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
            if (data != null)
            {
                data.Remainder = null;
                data.ModifiedTime = DateTime.Now;
                context.NotesModels.Update(data);
                await this.context.SaveChangesAsync();
                return "success";
            }
            return "invalid";
        }

        public IEnumerable<NotesModel> GetList()
        {
            return context.NotesModels.ToList();
        }

        public List<NotesModel> GetTrashList(string email)
        {
            List<NotesModel> list = new List<NotesModel>();
            var result = context.NotesModels.Where(p => p.Email == email && p.Trash == true).FirstOrDefault();
            if(result != null)
            {
                var data = from user in context.NotesModels where user.Email == email && user.Trash == true select user;
                foreach(var item in data)
                {
                    list.Add(item);
                }
                return list;
            }

            return null;
        }

        public List<NotesModel> GetArchiveList(string email)
        {
            List<NotesModel> list = new List<NotesModel>();
            var result = context.NotesModels.Where(p => p.Email == email && p.Archive == true).FirstOrDefault();
            if (result != null)
            {
                var data = from user in context.NotesModels where user.Email == email && user.Archive == true select user;
                foreach (var item in data)
                {
                    list.Add(item);
                }
                return list;
            }

            return null;
        }

        public async Task<string> Restore(int id)
        {
            var result = context.NotesModels.Where(p => p.Id == id && p.Trash == true).SingleOrDefault();
            if(result != null)
            {
                result.Trash = false;
                context.NotesModels.Update(result);
                await this.context.SaveChangesAsync();
                return "success";
            }
            return null;
        }

        public async Task<string> RestoreAll(string email)
        {
            var result = context.NotesModels.Where(p => p.Email == email && p.Trash == true).FirstOrDefault();
            if(result != null)
            {
                var data = from user in context.NotesModels where user.Email == email && user.Trash == true select user;
                foreach(var item in data)
                {
                    item.Trash = false;
                }
                context.NotesModels.Update(result);
                await this.context.SaveChangesAsync();
                return "success";
            }
            return null;
        }

        public async Task<string> DeleteAll(string email)
        {
            var result = context.NotesModels.Where(p => p.Email == email && p.Trash == true).FirstOrDefault();
            if (result != null)
            {
                var data = from user in context.NotesModels where user.Email == email && user.Trash == true select user;
                foreach (var item in data)
                {
                    context.NotesModels.Remove(item);
                }
                await this.context.SaveChangesAsync();
                return "success";
            }
            return null;
        }

        public async Task<string> Color(int id, string color)
        {
            var result = context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
            if(result != null)
            {
                result.Color = color;
                context.NotesModels.Update(result);
                await this.context.SaveChangesAsync();
                return "success";
            }
            return null;
        }

        public async Task<string> Image(int id, string image)
        {
            CloudinaryDotNet.Account account = new CloudinaryDotNet.Account(configuration["Cloudinary:Name"], configuration["Cloudinary:ApiKey"], configuration["Cloudinary:ApiSecret"]);
            CloudinaryDotNet.Cloudinary cloudinary = new CloudinaryDotNet.Cloudinary(account);
            var uploadParms = new ImageUploadParams()
            {
                File = new FileDescription(image)
            };
            var uploadResult = cloudinary.Upload(uploadParms);

            var data = this.context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
            data.Image = uploadResult.Uri.ToString();
            data.ModifiedTime = DateTime.Now;
            await this.context.SaveChangesAsync();
            return data.Image;
        }

        public Task Istrash(int id)
        {
            var user = this.context.NotesModels.Where(p => p.Id == id).SingleOrDefault();
            if (user != null)
            {
                user.Trash = true;
                return Task.Run(() => context.SaveChangesAsync());
            }

            return null;
        }
    }
}