// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CollaboratorController.cs" company="Bridgelabz">
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
    using FundooManager.Interface;
    using FundooModels.Models;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Class with Collaborator controller API.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class CollaboratorController : ControllerBase
    {
        /// <summary>
        /// The collaborator
        /// </summary>
        private ICollaboratorManager collaborator;

        /// <summary>
        /// Initializes a new instance of the <see cref="CollaboratorController"/> class.
        /// </summary>
        /// <param name="collaborator">The collaborator.</param>
        public CollaboratorController(ICollaboratorManager collaborator)
        {
            this.collaborator = collaborator;
        }

        /// <summary>
        /// Adds the collaborator.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/addCollaborator")]
        public async Task<ActionResult> AddCollaborator(CollaboratorModel model)
        {
            var result = await this.collaborator.AddCollaborator(model);
            if (result == "success")
            {
                return this.Ok(model);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Removes the collaborator.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of action</returns>
        [HttpDelete]
        [Route("api/removeCollaborator")]
        public async Task<ActionResult> RemoveCollaborator(int id)
        {
            var result = await this.collaborator.RemoveCollaborator(id);
            if (result == "success")
            {
                return this.Ok(result);
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Gets the specified notes identifier.
        /// </summary>
        /// <param name="notesId">The notes identifier.</param>
        /// <returns>list of user statistics</returns>
        [HttpGet]
        [Route("api/GetCollaborator")]
        public IEnumerable<CollaboratorModel> Get(int notesId)
        {
            return this.collaborator.Get(notesId);
        }

        /// <summary>
        /// Gets the list.
        /// </summary>
        /// <returns>list of user statistics</returns>
        [HttpGet]
        [Route("api/GetAllCollaborator")]
        public IEnumerable<CollaboratorModel> GetList()
        {
            return this.collaborator.GetList();
        }
    }
}