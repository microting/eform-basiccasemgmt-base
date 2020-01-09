﻿using Microting.eFormBasicCaseManagementBase.Infrastructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microting.eFormApi.BasePn.Abstractions;
using Microting.eFormApi.BasePn.Infrastructure.Database.Entities;
using Microting.eFormApi.BasePn.Infrastructure.Database.Extensions;

 namespace Microting.eFormBasicCaseManagementBase.Infrastructure.Data
{
    public class eFormCaseManagementPnDbContext : DbContext, IPluginDbContext
    {
        public eFormCaseManagementPnDbContext() { }

        public eFormCaseManagementPnDbContext(DbContextOptions<eFormCaseManagementPnDbContext> options) : base(options)
        {

        }
        public DbSet<CalendarUser> CalendarUsers { get; set; }
        public DbSet<CalendarUserVersions> CalendarUserVersions { get; set; }

        // plugin configuration
        public DbSet<PluginConfigurationValue> PluginConfigurationValues { get; set; }
        public DbSet<PluginConfigurationValueVersion> PluginConfigurationValueVersions { get; set; }
        public DbSet<PluginPermission> PluginPermissions { get; set; }
        public DbSet<PluginGroupPermission> PluginGroupPermissions { get; set; }
        public DbSet<PluginGroupPermissionVersion> PluginGroupPermissionVersions { get; set; }
    }
}
