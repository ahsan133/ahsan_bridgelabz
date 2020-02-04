using FundooModels.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interfaces
{
    public interface ICollaboratorRepository
    {
        Task<string> AddCollaborator(CollaboratorModel model);
        Task<string> RemoveCollaborator(int id);
        List<CollaboratorModel> Get(int notesId);
        List<CollaboratorModel> GetList();
    }
}
