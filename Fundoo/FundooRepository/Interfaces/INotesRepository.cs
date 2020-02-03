using FundooModels.NotesModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public interface INotesRepository
    {
        Task<int> AddNotes(NotesModel notes);
        Task<string> UpdateNotes(NotesModel notes);
        Task<string> RemoveNotes(int id);
        List<NotesModel> GetNotes(string email);
        Task IsArchive(int id);
        Task UnArchive(int id);
        Task IsPin(int id);
        Task UnPin(int id);
        Task<string> SetRemainder(int id, string remainder);
        Task<string> RemoveRemainder(int id, string remainder);
        IEnumerable<NotesModel> GetList();
        List<NotesModel> GetTrashList(string email);
        List<NotesModel> GetArchiveList(string email);
        Task<string> Restore(int id);
        Task<string> RestoreAll(string email);
        Task<string> DeleteAll(string email);
        Task<string> Color(int id, string color);
        Task<string> Image(int id, string image);
        Task IsTrash(int id);
    }
}
