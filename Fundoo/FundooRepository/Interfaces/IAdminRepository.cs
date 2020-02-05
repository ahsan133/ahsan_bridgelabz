using FundooModels.AdminModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interfaces
{
    public interface IAdminRepository
    {
        Task AddAdmin(AdminModel model);
        string LoginAdmin(AdminModel model);
        List<AdminUserList> GetUserList();
    }
}
