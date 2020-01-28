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
    }
}
