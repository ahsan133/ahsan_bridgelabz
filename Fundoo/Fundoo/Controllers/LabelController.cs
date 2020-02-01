using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FundooManager.Interface;
using FundooModels.NotesModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fundoo.Controllers
{
    public class LabelController : ControllerBase
    {
        private ILabelManager label;
        public LabelController(ILabelManager label)
        {
            this.label = label;
        }

        [HttpPost]
        [Route("api/addLabel")]
        public async Task<ActionResult> AddLabel([FromBody] LabelModel labelModel)
        {
            var result = await this.label.AddLabel(labelModel);
            if (result == 1)
            {
                return Ok(labelModel);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("api/updateLabel")]
        public async Task<ActionResult> UpdateLabel([FromBody] LabelModel labelModel)
        {
            var result = await this.label.UpdateLabel(labelModel);
            if (result == "success")
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("api/deleteLabel")]
        public async Task<ActionResult> DeleteLabel(int id)
        { 
            var result = await this.label.DeleteLabel(id);
            if (result == "success")
            {
                return Ok(result);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/getLabel")]
        public async Task<ActionResult> GetLabel(string email)
        {
            List<LabelModel> list = this.label.GetLabel(email);
            if (list != null)
            {
                return Ok(list);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}