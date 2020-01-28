using FundooModels.NotesModel;
using FundooRepository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class NotesRepository : INotesRepository
    {
        private UserContext context;

        public NotesRepository(UserContext context)
        {
            this.context = context;
        }


        public Task<int> AddNotes(NotesModel notes)
        {
            NotesModel model = new NotesModel()
            {
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

                var result = await this.context.SaveChangesAsync();
                return "success";
            }
            else
            {
                return "invalid";
            }
            
        }
    }
}