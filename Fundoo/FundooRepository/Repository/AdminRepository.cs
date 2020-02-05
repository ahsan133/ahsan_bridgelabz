using FundooModels.AdminModels;
using FundooRepository.Context;
using FundooRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private UserContext context;
        public AdminRepository(UserContext context)
        {
            this.context = context;
        }

        public Task AddAdmin(AdminModel model)
        {
            try
            {
                context.AdminModels.Add(model);
                return Task.Run(() => context.SaveChanges());
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public string LoginAdmin(AdminModel model)
        {
            var result = this.context.AdminModels.Where(p => p.Email == model.Email).SingleOrDefault();
            if (result != null && this.CheckPassword(model.Email, model.Password))
            {
                return "Login successful";
            }
            return null;
        }

        public bool CheckPassword(string email, string password)
        {
            bool data = this.context.AdminModels.Where(p => p.Email == email && p.Password == password).SingleOrDefault().Password != null ? true : false;
            return data;
        }

        public List<AdminModel> GetUserList()
        {
            return context.AdminModels.ToList<AdminModel>();
        }
    }
}