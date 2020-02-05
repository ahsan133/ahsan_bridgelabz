using FundooManager.Interface;
using FundooModels.AdminModels;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooManager.Manager
{
    public class AdminManager : IAdminManager
    {
        private IAdminRepository repository;
        public AdminManager(IAdminRepository repository)
        {
            this.repository = repository;
        }

        public Task AddAdmin(AdminModel model)
        {
            return this.repository.AddAdmin(model);
        }

        public string LoginAdmin(AdminModel model)
        {
            return this.repository.LoginAdmin(model);
        }

        public List<AdminModel> GetUserList()
        {
            return this.repository.GetUserList();
        }
    }
}
