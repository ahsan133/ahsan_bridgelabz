// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelRepository.cs" company="Bridgelabz">
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
    using FundooModels.NotesModels;
    using FundooRepository.Context;
    using FundooRepository.Interfaces;

    /// <summary>
    /// This class is for Labels.
    /// </summary>
    /// <seealso cref="FundooRepository.Interfaces.ILabelRepository" />
    public class LabelRepository : ILabelRepository
    {
        /// <summary>
        /// The context
        /// </summary>
        private UserContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="LabelRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public LabelRepository(UserContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Adds the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns>
        /// add label result
        /// </returns>
        public Task<int> AddLabel(LabelModel labelModel)
        {
            Random random = new Random();
            LabelModel model = new LabelModel()
            {
                Label = labelModel.Label,
                Email = labelModel.Email,
                NotesId = labelModel.NotesId
            };
            this.context.LabelModels.Add(model);
            return this.context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates the label.
        /// </summary>
        /// <param name="labelModel">The label model.</param>
        /// <returns>
        /// update label result
        /// </returns>
        public async Task<string> UpdateLabel(LabelModel labelModel)
        {
            var label = this.context.LabelModels.Where(p => p.Id == labelModel.Id).SingleOrDefault();
            if (label != null)
            {
                label.Label = labelModel.Label;
                this.context.LabelModels.Update(label);
                await this.context.SaveChangesAsync();
                return "success";
            }

            return null;
        }

        /// <summary>
        /// Removes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// remove label result
        /// </returns>
        public async Task<string> RemoveLabel(int id)
        {
            var label = this.context.LabelModels.Where(p => p.Id == id).SingleOrDefault();
            if(label != null)
            {
                label.NotesId = 0;
                await this.context.SaveChangesAsync();
                return "success";
            }

            return null;
        }

        /// <summary>
        /// Deletes the label.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// delete label result
        /// </returns>
        public async Task<string> DeleteLabel(int id)
        {
            var label = this.context.LabelModels.Where(p => p.Id == id).SingleOrDefault();
            if (label != null)
            {
                this.context.LabelModels.Remove(label);
                await this.context.SaveChangesAsync();
                return "success";
            }

            return null;
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>
        /// list of user statistics
        /// </returns>
        public List<LabelModel> GetLabel(string email)
        {
            List<LabelModel> list = new List<LabelModel>();
            var result = this.context.LabelModels.Where(p => p.Email == email).FirstOrDefault();
            if (result != null)
            {
                var data = from user in this.context.LabelModels where user.Email == email select user;
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