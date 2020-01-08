﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

 namespace Microting.eFormBasicCaseManagementBase.Infrastructure.Data.Factories
{
    public class CaseManagementPnDbContextFactory : IDesignTimeDbContextFactory<eFormCaseManagementPnDbContext>
    {
        public eFormCaseManagementPnDbContext CreateDbContext(string[] args)
        {
            //args = new[]
            //    {"host=localhost;Database=case-pl;Uid=root;Pwd=111111;port=3306;Convert Zero Datetime = true;SslMode=none;PersistSecurityInfo=true;"};
            //args = new[]
            //    {"Data Source=.\\SQLEXPRESS;Database=case-pl;Integrated Security=True"};
            var optionsBuilder = new DbContextOptionsBuilder<eFormCaseManagementPnDbContext>();
            if (args.Any())
            {
                if (args.FirstOrDefault().ToLower().Contains("convert zero datetime"))
                {
                    optionsBuilder.UseMySql(args.FirstOrDefault());
                }
                else
                {
                    optionsBuilder.UseSqlServer(args.FirstOrDefault());
                }
            }
            else
            {
                throw new ArgumentNullException("Connection string not present");
            } 
            // optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\SharedInstance;Initial Catalog=eform-basic-case-management-base;Integrated Security=True;");
            // dotnet ef migrations add InitialMigration --project Microting.eFormBasicCaseManagementBase --startup-project DBMigrator
            optionsBuilder.UseLazyLoadingProxies();
            return new eFormCaseManagementPnDbContext(optionsBuilder.Options);
        }
    }
}
