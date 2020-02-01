using FundooManager.Interface;
using FundooModels.NotesModels;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public class LabelManager : ILabelManager
    {
        private ILabelRepository repository;

        public LabelManager(ILabelRepository repository)
        {
            this.repository = repository;
        }

        public Task<int> AddLabel(LabelModel labelModel)
        {
            var result = repository.AddLabel(labelModel);
            return result;
        }

        public Task<string> UpdateLabel(LabelModel labelModel)
        {
            var result = repository.UpdateLabel(labelModel);
            return result;
        }

        public Task<string> DeleteLabel(int id)
        {
            var result = repository.DeleteLabel(id);
            return result;
        }

        public List<LabelModel> GetLabel(string email)
        {
            return repository.GetLabel(email);
        }
    }
}
