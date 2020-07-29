using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;
using Microting.eFormBasicCaseManagementBase.Infrastructure.Data;
using Microting.eFormBasicCaseManagementBase.Infrastructure.Data.Factories;
using NUnit.Framework;

namespace Microting.eformBasicCaseManagementBase.Unit.Test
{
        [TestFixture]
    public abstract class DbTestFixture
    {
        private eFormCaseManagementPnDbContext _dbContext;
        private string _connectionString;

        //public RentableItemsPnDbAnySql db;

        public void GetContext(string connectionStr)
        {

            CaseManagementPnDbContextFactory contextFactory = new CaseManagementPnDbContextFactory();
            _dbContext = contextFactory.CreateDbContext(new[] {connectionStr});
            
            _dbContext.Database.Migrate();
            _dbContext.Database.EnsureCreated();
        }

        [SetUp]
        public void Setup()
        {
            _connectionString = @"Server = localhost; port = 3306; Database = case-mamangement-pn-tests; user = root; Convert Zero Datetime = true;";


            GetContext(_connectionString);


            _dbContext.Database.SetCommandTimeout(300);

            try
            {
                ClearDb();
            }
            catch
            {
                _dbContext.Database.Migrate();
            }

            DoSetup();
        }

        [TearDown]
        public void TearDown()
        {

            ClearDb();

            ClearFile();

            _dbContext.Dispose();
        }

        private void ClearDb()
        {
            List<string> modelNames = new List<string>();
            modelNames.Add("CalendarUsers");
            modelNames.Add("CaseManagementSettings");


            foreach (var modelName in modelNames)
            {
                try
                {
                    _dbContext.Database.ExecuteSqlRaw($"SET FOREIGN_KEY_CHECKS = 0;TRUNCATE `case-mamangement-pn-tests`.`{modelName}`");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        private string _path;

        private void ClearFile()
        {
            _path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            _path = System.IO.Path.GetDirectoryName(_path).Replace(@"file:\", "");

            string picturePath = _path + @"\output\dataFolder\picture\Deleted";

            DirectoryInfo diPic = new DirectoryInfo(picturePath);

            try
            {
                foreach (FileInfo file in diPic.GetFiles())
                {
                    file.Delete();
                }
            }
            catch { }


        }
        public virtual void DoSetup() { }

    }
    
}