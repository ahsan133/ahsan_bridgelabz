using FundooModels.AdminModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Interface
{
    public interface IAdminManager
    {
        Task AddAdmin(AdminModel model);
        string LoginAdmin(AdminModel model);
        List<AdminUserList> GetUserList();
    }
}
