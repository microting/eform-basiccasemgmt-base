﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microting.eFormBasicCaseManagementBase.Infrastructure.Data;

namespace Microting.eFormBasicCaseManagementBase.Migrations
{
    [DbContext(typeof(eFormCaseManagementPnDbContext))]
    partial class eFormCaseManagementPnDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginConfigurationValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<string>("WorkflowState")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginConfigurationValues");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginConfigurationValueVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<string>("WorkflowState")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginConfigurationValueVersions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<string>("WorkflowState")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.ToTable("PluginGroupPermissions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermissionVersion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int>("PluginGroupPermissionId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<string>("WorkflowState")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginGroupPermissionVersions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginPermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("PermissionName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<string>("WorkflowState")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("PluginPermissions");
                });

            modelBuilder.Entity("Microting.eFormBasicCaseManagementBase.Infrastructure.Data.Entities.CalendarUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsVisibleInCalendar")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NameInCalendar")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("RelatedEntityId")
                        .HasColumnType("int");

                    b.Property<int>("SiteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<string>("WorkflowState")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("CalendarUsers");
                });

            modelBuilder.Entity("Microting.eFormBasicCaseManagementBase.Infrastructure.Data.Entities.CalendarUserVersions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CalendarUserId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("CreatedByUserId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsVisibleInCalendar")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NameInCalendar")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("RelatedEntityId")
                        .HasColumnType("int");

                    b.Property<int>("SiteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("UpdatedByUserId")
                        .HasColumnType("int");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.Property<string>("WorkflowState")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("CalendarUserVersions");
                });

            modelBuilder.Entity("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginGroupPermission", b =>
                {
                    b.HasOne("Microting.eFormApi.BasePn.Infrastructure.Database.Entities.PluginPermission", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
