using FundooModels.NotesModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepository.Repository
{
    public interface INotesRepository
    {
        void AddNotes(NotesModel notes);
    }
}
