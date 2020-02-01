using FundooModels.NotesModels;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class LabelRepository : ILabelRepository
    {
        private UserContext context;

        public LabelRepository(UserContext context)
        {
            this.context = context;
        }


        public Task<int> AddLabel(LabelModel labelModel)
        {
            Random random = new Random();
            LabelModel model = new LabelModel()
            {
                Label = labelModel.Label,
                Email = labelModel.Email,
                Id = random.Next(10000)
            };
            this.context.LabelModels.Add(model);
            return context.SaveChangesAsync();
        }

        public async Task<string> UpdateLabel(LabelModel labelModel)
        {
            var label = context.LabelModels.Where(p => p.Id == labelModel.Id).SingleOrDefault();
            if (label != null)
            {
                label.Label = labelModel.Label;
                this.context.LabelModels.Update(label);
                await context.SaveChangesAsync();
                return "success";
            }
            return null;
        }

        public async Task<string> DeleteLabel(int id)
        {
            var label = context.LabelModels.Where(p => p.Id == id).SingleOrDefault();
            if (label != null)
            {
                this.context.LabelModels.Remove(label);
                await context.SaveChangesAsync();
                return "success";
            }
            return null;
        }

        public List<LabelModel> GetLabel(string email)
        {
            List<LabelModel> list = new List<LabelModel>();
            var result = context.LabelModels.Where(p => p.Email == email).FirstOrDefault();
            if (result != null)
            {
                var data = from user in context.LabelModels where user.Email == email select user;
                foreach (var item in data)
                {
                    list.Add(item);
                }
                return list;
            }
            return null;
        }
    }
}