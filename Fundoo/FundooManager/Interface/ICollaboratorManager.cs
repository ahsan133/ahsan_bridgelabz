using FundooModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
    public interface ICollaboratorManager
    {
        Task AddCollaborator(CollaboratorModel model);
    }
}
