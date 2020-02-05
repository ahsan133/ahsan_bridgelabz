using FundooModels.Models;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<string> AddCollaborator(CollaboratorModel model)
        {
            context.CollaboratorModels.Add(model);
            await this.context.SaveChangesAsync();
            return "success";
        }

        public async Task<string> RemoveCollaborator(int id)
        {
            var data = context.CollaboratorModels.Where(p => p.Id == id).SingleOrDefault();
            if (data != null)
            {
                context.CollaboratorModels.Remove(data);
                await this.context.SaveChangesAsync();
                return "success";
            }

            return null;
        }

        public List<CollaboratorModel> Get(int notesId)
        {
            try
            {
                List<CollaboratorModel> list = new List<CollaboratorModel>();
                var result = context.CollaboratorModels.Where(p => p.NotesId == notesId).FirstOrDefault();
                if (result != null)
                {
                    var data = from user in context.CollaboratorModels where user.NotesId == notesId select user;
                    foreach (var item in data)
                    {
                        list.Add(item);
                    }

                    return list;
                }

                return null;
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<CollaboratorModel> GetList()
        {
            try
            {
                return context.CollaboratorModels.ToList<CollaboratorModel>();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
