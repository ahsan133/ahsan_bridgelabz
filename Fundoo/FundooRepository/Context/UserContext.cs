
using FundooModels.Models;
using FundooModels.NotesModel;
using FundooModels.NotesModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundooRepository.Context
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<RegisterModel> RegisterModels
        {
            get;
            set;
        }

        public DbSet<NotesModel> NotesModels
        {
            get;
            set;
        }

        public DbSet<LabelModel> LabelModels
        {
            get;
            set;
        }
    }
}
