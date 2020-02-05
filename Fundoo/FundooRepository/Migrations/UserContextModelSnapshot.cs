﻿// <auto-generated />
using System;
using FundooRepository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FundooRepository.Migrations
{
    [DbContext(typeof(UserContext))]
    partial class UserContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FundooModels.AdminModels.AdminModel", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.HasKey("Email");

                    b.ToTable("AdminModels");
                });

            modelBuilder.Entity("FundooModels.AdminModels.AdminUserList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<DateTime>("LoginTime");

                    b.HasKey("Id");

                    b.ToTable("AdminUsers");
                });

            modelBuilder.Entity("FundooModels.Models.CollaboratorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NotesId");

                    b.Property<string>("ReceiverEmail");

                    b.Property<string>("SenderEmail");

                    b.HasKey("Id");

                    b.ToTable("CollaboratorModels");
                });

            modelBuilder.Entity("FundooModels.Models.RegisterModel", b =>
                {
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Password");

                    b.Property<bool>("Status");

                    b.HasKey("Email");

                    b.ToTable("RegisterModels");
                });

            modelBuilder.Entity("FundooModels.NotesModel.NotesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Archive");

                    b.Property<string>("Color");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<string>("Image");

                    b.Property<int>("Index");

                    b.Property<DateTime>("ModifiedTime");

                    b.Property<bool>("Pin");

                    b.Property<string>("Remainder");

                    b.Property<string>("Title");

                    b.Property<bool>("Trash");

                    b.HasKey("Id");

                    b.ToTable("NotesModels");
                });

            modelBuilder.Entity("FundooModels.NotesModels.LabelModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.ToTable("LabelModels");
                });
#pragma warning restore 612, 618
        }
    }
}
