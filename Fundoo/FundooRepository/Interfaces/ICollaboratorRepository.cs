using FundooModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interfaces
{
    public interface ICollaboratorRepository
    {
        Task AddCollaborator(CollaboratorModel model);
    }
}
