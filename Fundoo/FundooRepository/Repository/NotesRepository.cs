using FundooModels.NotesModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepository.Repository
{
    public class NotesRepository
    {
        public void AddNotes(NotesModel notes)
        {
            NotesModel model = new NotesModel()
            {
                Email = notes.Email,
                Title = notes.Title,
                Image = notes.Image,
                Archive = notes.Archive,
                Pin = notes.Pin,
                Trash = notes.Trash,
                Color = notes.Color,
                Remainder = notes.Remainder,
                CreatedTime = DateTime.Now,
                ModifiedTime = DateTime.Now
            };


        }
    }
}
