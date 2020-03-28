﻿// <auto-generated />
using System;
using EntityModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityModel.Migrations
{
    [DbContext(typeof(DbModel))]
    [Migration("20200328005558_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityModel.Feedback", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("SenderId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("EntityModel.Organization", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsVerified");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("EntityModel.Resource", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Available");

                    b.Property<string>("Category");

                    b.Property<string>("CreatedById");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<bool>("HasWaitlist");

                    b.Property<bool>("IsRecordComplete");

                    b.Property<bool>("IsWaitlistOpen");

                    b.Property<int>("Max");

                    b.Property<string>("Name");

                    b.Property<string>("OrganizationId");

                    b.HasKey("Id");

                    b.ToTable("Resources");
                });

            modelBuilder.Entity("EntityModel.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ContactEnabled");

                    b.Property<string>("OrganizationId");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("ReminderFrequency");

                    b.Property<string>("ReminderTime");

                    b.HasKey("Id");

                    b.HasIndex("PhoneNumber")
                        .IsUnique()
                        .HasFilter("[PhoneNumber] IS NOT NULL");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
