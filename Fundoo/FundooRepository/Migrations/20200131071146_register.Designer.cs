﻿// <auto-generated />
using System;
using FundooRepository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FundooRepository.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20200131071146_register")]
    partial class register
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                    b.Property<string>("Email")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Archive");

                    b.Property<string>("Color");

                    b.Property<DateTime>("CreatedTime");

                    b.Property<string>("Description");

                    b.Property<int>("Id");

                    b.Property<string>("Image");

                    b.Property<DateTime>("ModifiedTime");

                    b.Property<bool>("Pin");

                    b.Property<string>("Remainder");

                    b.Property<string>("Title");

                    b.Property<bool>("Trash");

                    b.HasKey("Email");

                    b.ToTable("NotesModels");
                });
#pragma warning restore 612, 618
        }
    }
}