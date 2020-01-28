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

        [HttpPost]
        [Route("api/addNotes")]
        public async Task<ActionResult> AddNotes([FromBody] NotesModel notes)
        {
            var result = await this.note.AddNotes(notes);
            if (result == 1)
            {
                return this.Ok(notes);
            }
            else
            {
                return BadRequest();
            }       
        }

        [HttpPut]
        [Route("api/updateNotes")]
        public async Task<ActionResult> UpdateNotes([FromBody] NotesModel notes)
        {
            var result = await this.note.UpdateNotes(notes);
            if (result == "success")
            {
                return this.Ok(notes);
            }
            else
            {
                return BadRequest();
            }
        }

        public Task<ActionResult> IsArchive() 
    }
}