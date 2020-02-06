// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AdminRepository.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using FundooModels.AdminModels;
    using FundooRepository.Context;
    using FundooRepository.Interfaces;

    /// <summary>
    /// This class is for Admin access.
    /// </summary>
    /// <seealso cref="FundooRepository.Interfaces.IAdminRepository" />
    public class AdminRepository : IAdminRepository
    {
        /// <summary>
        /// The context
        /// </summary>
        private UserContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public AdminRepository(UserContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adds the admin.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// result of task
        /// </returns>
        /// <exception cref="Exception"></exception>
        public Task AddAdmin(AdminModel model)
        {
            try
            {
                this.context.AdminModels.Add(model);
                return Task.Run(() => this.context.SaveChanges());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// Logins the admin.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns>
        /// login result
        /// </returns>
        public string LoginAdmin(AdminModel model)
        {
            var result = this.context.AdminModels.Where(p => p.Email == model.Email).SingleOrDefault();
            if (result != null && this.CheckPassword(model.Email, model.Password))
            {
                return "Login successful";
            }

            return null;
        }

        /// <summary>
        /// Checks the password.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <param name="password">The password.</param>
        /// <returns>boolean value of check password</returns>
        public bool CheckPassword(string email, string password)
        {
            bool data = this.context.AdminModels.Where(p => p.Email == email && p.Password == password).SingleOrDefault().Password != null ? true : false;
            return data;
        }

        /// <summary>
        /// Gets the user list.
        /// </summary>
        /// <returns>
        /// list of user statistics
        /// </returns>
        public List<AdminUserList> GetUserList()
        {
            return this.context.AdminUsers.ToList<AdminUserList>();
        }
    }
}