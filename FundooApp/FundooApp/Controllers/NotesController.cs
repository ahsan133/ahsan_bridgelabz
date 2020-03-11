// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NotesController.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooApp.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using FundooManager.Manager;
    using FundooModels.NotesModel;
    using FundooRepository.Context;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Class with Notes controller API.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class NotesController : ControllerBase
    {
        /// <summary>
        /// The note
        /// </summary>
        private INotesManager note;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotesController"/> class.
        /// </summary>
        /// <param name="notes">The notes.</param>
        public NotesController(INotesManager notes)
        {
            this.note = notes;
        }

        /// <summary>
        /// Adds the notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <returns>result of action</returns>
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
                return this.BadRequest();
            }       
        }

        /// <summary>
        /// Updates the notes.
        /// </summary>
        /// <param name="notes">The notes.</param>
        /// <returns>result of action</returns>
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
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Removes the notes.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of action</returns>
        [HttpDelete]
        [Route("api/removeNotes")]
        public async Task<ActionResult> RemoveNotes(int id)
        {
            var result = await this.note.RemoveNotes(id);
            if (result == "success")
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Gets the notes.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>result of action</returns>
        [HttpGet]
        [Route("api/getNotes")]
        public ActionResult GetNotes(string email)
        {
            var result = this.note.GetNotes(email);
            if (result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Determines whether the specified identifier is archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/isArchive")]
        public ActionResult IsArchive(int id)
        {
            var result = this.note.IsArchive(id);
            if (result != null)
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Removes the archive.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/unArchive")]
        public ActionResult UnArchive(int id)
        {
            var result = this.note.UnArchive(id);
            if (result != null)
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Determines whether the specified identifier is pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/IsPin")]
        public ActionResult IsPin(int id)
        {
            var result = this.note.IsPin(id);
            if (result != null)
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Removes the pin.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/UnPin")]
        public ActionResult UnPin(int id)
        {
            var result = this.note.UnPin(id);
            if (result != null)
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Sets the remainder.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="remainder">The remainder.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/setRemainder")]
        public async Task<ActionResult> SetRemainder(int id, string remainder)
        {
            var result = await this.note.SetRemainder(id, remainder);
            if (result == "success")
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Removes the remainder.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="remainder">The remainder.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/removeRemainder")]
        public async Task<ActionResult> RemoveRemainder(int id)
        {
            var result = await this.note.RemoveRemainder(id);
            if (result == "success")
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns>result of action</returns>
        [HttpGet]
        [Route("api/getList")]
        public ActionResult GetList()
        {
            var result = this.note.GetList();
            if (result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Gets the trash list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>result of action</returns>
        [HttpGet]
        [Route("api/getTrash")]
        public ActionResult GetTrashList(string email)
        {
            var result = this.note.GetTrashList(email);
            if (result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Gets the archive list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>result of action</returns>
        [HttpGet]
        [Route("api/getArchive")]
        public ActionResult GetArchiveList(string email)
        {
            var result = this.note.GetArchiveList(email);
            if (result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Gets the remainder list.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>result of action</returns>
        [HttpGet]
        [Route("api/getRemainders")]
        public ActionResult GetRemainderList(string email)
        {
            var result = this.note.GetRemainderList(email);
            if (result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Restores the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/restore")]
        public async Task<ActionResult> Restore(int id)
        {
            var result = await this.note.Restore(id);
            if (result != null)
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Restores all.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/restoreAll")]
        public async Task<ActionResult> RestoreAll(string email)
        {
            var result = await this.note.RestoreAll(email);
            if (result != null)
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Deletes all.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>result of action</returns>
        [HttpDelete]
        [Route("api/deleteAll")]
        public async Task<ActionResult> DeleteAll(string email)
        {
            var result = await this.note.DeleteAll(email);
            if (result != null)
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Colors the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="color">The color.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/color")]
        public async Task<ActionResult> Color(int id, string color)
        {
            var result = await this.note.Color(id, color);

            if (result != null)
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Images the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="image">The image.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/image")]
        public ActionResult Image(int id, IFormFile image)
        {
            var result = this.note.Image(id, image);
            if (result != null)
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Determines whether the specified identifier is trash.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/isTrash")]
        public ActionResult IsTrash(int id)
        {
            var result = this.note.IsTrash(id);
            if (result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Drags the and drop.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="dragIndex">Index of the drag.</param>
        /// <param name="dropIndex">Index of the drop.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/dragDrop")]
        public ActionResult DragAndDrop(string email, int dragIndex, int dropIndex)
        {
            var result = this.note.DragAndDrop(email, dragIndex, dropIndex);
            if (result != null)
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }
    }
}