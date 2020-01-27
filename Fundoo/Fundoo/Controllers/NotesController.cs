using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FundooManager.Manager;
using FundooModels.NotesModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fundoo.Controllers
{
    public class NotesController : ControllerBase
    {
        private INotesManager note;

        public NotesController(INotesManager notes)
        {
            this.note = notes;
        }
        public ActionResult AddNotes(NotesModel notes)
        {
            try
            {
                this.note.AddNotes(notes);
                return Ok(notes);
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

       
    }
}