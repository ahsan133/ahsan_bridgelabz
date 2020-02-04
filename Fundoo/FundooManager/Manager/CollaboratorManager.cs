using FundooManager.Interface;
using FundooModels.Models;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public class CollaboratorManager : ICollaboratorManager
    {
        private ICollaboratorRepository repository;

        public CollaboratorManager(ICollaboratorRepository repository)
        {
            this.repository = repository;
        }
        public Task<string> AddCollaborator(CollaboratorModel model)
        {
            return this.repository.AddCollaborator(model);
        }

        public Task<string> RemoveCollaborator(int id)
        {
            return this.repository.RemoveCollaborator(id);
        }

        public List<CollaboratorModel> Get(int notesId)
        {
            return this.repository.Get(notesId);
        }

        public List<CollaboratorModel> GetList()
        {
            return this.repository.GetList();
        }
    }
}
