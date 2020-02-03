using FundooModels.Models;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class CollaboratorRepository : ICollaboratorRepository
    {
        private UserContext context;
        public CollaboratorRepository(UserContext context)
        {
            this.context = context;
        }

        public Task AddCollaborator(CollaboratorModel model)
        {
            context.CollaboratorModels.Add(model);
            this.context.SaveChangesAsync();
        }
    }
}
