using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FundooManager.Interface;
using FundooModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fundoo.Controllers
{
    public class CollaboratorController : ControllerBase
    {
        private ICollaboratorManager collaborator;

        public CollaboratorController(ICollaboratorManager collaborator)
        {
            this.collaborator = collaborator;
        }

        [HttpPut]
        [Route("api/addCollaborator")]
        public async Task<ActionResult> AddCollaborator(CollaboratorModel model)
        {
            var result = await this.collaborator.AddCollaborator(model);
            if(result == "success")
            {
                return Ok(model);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("api/removeCollaborator")]
        public async Task<ActionResult> RemoveCollaborator(int id)
        {
            var result = await this.collaborator.RemoveCollaborator(id);
            if(result == "success")
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/GetCollaborator")]
        public IEnumerable<CollaboratorModel> Get(int notesId)
        {
            return this.collaborator.Get(notesId);
        }

        [HttpGet]
        [Route("api/GetAllCollaborator")]
        public IEnumerable<CollaboratorModel> GetList()
        {
            return this.collaborator.GetList();
        }
    }
}