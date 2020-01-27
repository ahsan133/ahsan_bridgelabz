using FundooModels.NotesModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooManager.Manager
{
    public interface INotesManager
    {
        void AddNotes(NotesModel notes);
        void RemoveNotes();
        void Updatenotes();

    }
}
