// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelController.cs" company="Bridgelabz">
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
    using FundooModels.NotesModels;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Class with Label controller API.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    public class LabelController : ControllerBase
    {
        /// <summary>
        /// The label
        /// </summary>
        private ILabelManager label;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelController"/> class.
        /// </summary>
        /// <param name="label">The label.</param>
        public LabelController(ILabelManager label)
        {
            this.label = label;
        }

        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns>result of action</returns>
        [HttpPost]
        [Route("api/addLabel")]
        public async Task<ActionResult> AddLabel([FromBody] LabelModel labelModel)
        {
            var result = await this.label.AddLabel(labelModel);
            if (result == 1)
            {
                return this.Ok(new { result });
            }
            else
            {
                return this.BadRequest();
            }
        }

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/updateLabel")]
        public async Task<ActionResult> UpdateLabel([FromBody] LabelModel labelModel)
        {
            var result = await this.label.UpdateLabel(labelModel);
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
        /// Removes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of action</returns>
        [HttpPut]
        [Route("api/removeLabel")]
        public async Task<ActionResult> RemoveLabel(int id)
        {
            var result = await this.label.RemoveLabel(id);
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
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>result of action</returns>
        [HttpDelete]
        [Route("api/deleteLabel")]
        public async Task<ActionResult> DeleteLabel(int id)
        { 
            var result = await this.label.DeleteLabel(id);
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
        /// Gets the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>result of action</returns>
        [HttpGet]
        [Route("api/getLabel")]
        public ActionResult GetLabel(string email)
        {
            var list = this.label.GetLabel(email);
            if (list != null)
            {
                return this.Ok(list);
            }
            else
            {
                return this.BadRequest();
            }
        }
    }
}