// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserContext.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// --------------------------------------------------------------------------------------------------------------------
namespace FundooRepository.Context
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using FundooModels.AdminModels;
    using FundooModels.Models;
    using FundooModels.NotesModel;
    using FundooModels.NotesModels;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// User Context class is to configure with the database
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class UserContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the register models.
        /// </summary>
        /// <value>
        /// The register models.
        /// </value>
        public DbSet<RegisterModel> RegisterModels
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the notes models.
        /// </summary>
        /// <value>
        /// The notes models.
        /// </value>
        public DbSet<NotesModel> NotesModels
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the label models.
        /// </summary>
        /// <value>
        /// The label models.
        /// </value>
        public DbSet<LabelModel> LabelModels
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the collaborator models.
        /// </summary>
        /// <value>
        /// The collaborator models.
        /// </value>
        public DbSet<CollaboratorModel> CollaboratorModels
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the admin models.
        /// </summary>
        /// <value>
        /// The admin models.
        /// </value>
        public DbSet<AdminModel> AdminModels
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the admin users.
        /// </summary>
        /// <value>
        /// The admin users.
        /// </value>
        public DbSet<AdminUserList> AdminUsers
        {
            get;
            set;
        }
    }
}
