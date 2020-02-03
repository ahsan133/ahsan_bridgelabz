using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FundooManager.Manager;
using FundooModels.NotesModel;
using FundooRepository.Context;
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

        [HttpDelete]
        [Route("api/removeNotes")]
        public async Task<ActionResult> RemoveNotes(int id)
        {
            var result = await this.note.RemoveNotes(id);
            if (result == "success")
            {
                return Ok(new { result });
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/getNotes")]
        public ActionResult GetNotes(string email)
        {
            var result = this.note.GetNotes(email);
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut]
        [Route("api/isArchive")]
        public ActionResult IsArchive(int id)
        {
            var result = this.note.IsArchive(id);
            if(result != null)
            {
                return Ok(new { result });
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("api/unArchive")]
        public ActionResult UnArchive(int id)
        {
            var result = this.note.UnArchive(id);
            if (result != null)
            {
                return Ok(new { result });
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("api/IsPin")]
        public ActionResult IsPin(int id)
        {
            var result = this.note.IsPin(id);
            if (result != null)
            {
                return Ok(new { result });
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("api/UnPin")]
        public ActionResult UnPin(int id)
        {
            var result = this.note.UnPin(id);
            if (result != null)
            {
                return Ok(new { result });
            }
            return BadRequest();
        }

        [HttpPut]
        [Route("api/setRemainder")]
        public async Task<ActionResult> SetRemainder(int id, string remainder)
        {
            var result =await this.note.SetRemainder(id, remainder);
            if(result == "success")
            {
                return Ok(new { result });
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("api/removeRemainder")]
        public async Task<ActionResult> RemoveRemainder(int id, string remainder)
        {
            var result = await this.note.RemoveRemainder(id, remainder);
            if (result == "success")
            {
                return Ok(new { result });
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/getList")]
        public ActionResult GetList()
        {
            var result = this.note.GetList();
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/getTrash")]
        public ActionResult GetTrashList(string email)
        {
            var result = this.note.GetTrashList(email);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/getArchive")]
        public ActionResult GetArchiveList(string email)
        {
            var result = this.note.GetArchiveList(email);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("api/restore")]
        public async Task<ActionResult> Restore(int id)
        {
            var result = await this.note.Restore(id);
            if(result != null)
            {
                return Ok(new { result });
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("api/restoreAll")]
        public async Task<ActionResult> RestoreAll(string email)
        {
            var result = await this.note.RestoreAll(email);
            if (result != null)
            {
                return Ok(new { result });
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("api/deleteAll")]
        public async Task<ActionResult> DeleteAll(string email)
        {
            var result = await this.note.DeleteAll(email);
            if(result != null)
            {
                return Ok(new { result });
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("api/color")]
        public async Task<ActionResult> Color(int id, string color)
        {
            var result = await this.note.Color(id, color);

            if(result != null)
            {
                return Ok(new { result });
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("api/image")]
        public ActionResult Image(int id, string image)
        {
            var result = this.note.Image(id, image);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [("api/isTrash")]
        public ActionResult IsTrash(int id)
        {
            var result = this.note.IsTrash(id);
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}