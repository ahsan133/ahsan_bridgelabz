using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FundooModels.NotesModel;
using FundooRepository.Repository;

namespace FundooManager.Manager
{
    public class NotesManager : INotesManager
    {
        private INotesRepository repository;
        public NotesManager(INotesRepository repository)
        {
            this.repository = repository;
        }


        public Task<int> AddNotes(NotesModel notes)
        {
            var result = this.repository.AddNotes(notes);
            return result;
        }

        public Task<string> UpdateNotes(NotesModel notes)
        {
            var result = this.repository.UpdateNotes(notes);
            return result;
        }

        public Task<string> RemoveNotes(int id)
        {
            var result = this.repository.RemoveNotes(id);
            return result;
        }

        public List<NotesModel> GetNotes(string email)
        {
            return this.repository.GetNotes(email);
        }

        public Task IsArchive(int id)
        {
            return this.repository.IsArchive(id);
        }

        public Task UnArchive(int id)
        {
            return this.repository.UnArchive(id);
        }

        public Task IsPin(int id)
        {
            return this.repository.IsPin(id);
        }
        public Task UnPin(int id)
        {
            return this.repository.UnPin(id);
        }

        public Task<string> SetRemainder(int id, string remainder)
        {
            return this.repository.SetRemainder(id, remainder);
        }
        public Task<string> RemoveRemainder(int id, string remainder)
        {
            return this.repository.RemoveRemainder(id, remainder);
        }
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

        public List<NotesModel> GetTrashList(string email)
        {
            return this.repository.GetTrashList(email);
        }

        public List<NotesModel> GetArchiveList(string email)
        {
            return this.repository.GetArchiveList(email);
        }

        public Task<string> Restore(int id)
        {
            return this.repository.Restore(id);
        }

        public Task<string> RestoreAll(string email)
        {
            return this.repository.RestoreAll(email);
        }

        public Task<string> DeleteAll(string email)
        {
            return this.repository.DeleteAll(email);
        }

        public Task<string> Color(int id, string color)
        {
            return this.repository.Color(id, color);
        }

        public Task<string> ProfilePicture(int id, string image)
        {
            return this.repository.ProfilePicture(id, image);
        }
    }
}
