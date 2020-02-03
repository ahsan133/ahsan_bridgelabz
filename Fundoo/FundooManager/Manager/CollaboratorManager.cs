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
        public Task AddCollaborator(CollaboratorModel model)
        {
            return this.repository.AddCollaborator(model);
        }
    }
}
