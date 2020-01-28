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
    }
}
