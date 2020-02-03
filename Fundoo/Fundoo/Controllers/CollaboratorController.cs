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
        public ActionResult AddCollaborator(CollaboratorModel model)
        {
            var result = this.collaborator.AddCollaborator(model);
        }

    }
}