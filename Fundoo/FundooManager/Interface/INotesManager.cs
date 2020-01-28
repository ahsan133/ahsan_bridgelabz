using FundooModels.NotesModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public interface INotesManager
    {
        Task<int> AddNotes(NotesModel notes);
        Task<string> UpdateNotes(NotesModel notes);

    }
}
