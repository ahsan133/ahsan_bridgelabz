using System;
using System.Collections.Generic;
using System.Text;
using FundooModels.NotesModel;
using FundooRepository.Repository;

namespace FundooManager.Manager
{
    public class NotesManager : INotesManager
    {
        private INotesRepository notes;
        public NotesManager(INotesRepository note)
        {
            this.notes = note;
        }

        public void AddNotes(NotesModel notes)
        {
          
        }

        public void RemoveNotes()
        {
           
        }

        public void Updatenotes()
        {
            
        }
    }
}
