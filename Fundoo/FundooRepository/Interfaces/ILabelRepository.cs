using FundooModels.NotesModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interfaces
{
    public interface ILabelRepository
    {
        Task<int> AddLabel(LabelModel labelModel);
        Task<string> UpdateLabel(LabelModel labelModel);
        Task<string> DeleteLabel(int id);

        List<LabelModel> GetLabel(string email);
    }
}
