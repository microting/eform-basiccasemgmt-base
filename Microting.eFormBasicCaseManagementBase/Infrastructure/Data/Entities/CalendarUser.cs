using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microting.eForm.Infrastructure.Constants;
using Microting.eFormApi.BasePn.Infrastructure.Database.Base;

namespace Microting.eFormBasicCaseManagementBase.Infrastructure.Data.Entities
{
    public class CalendarUser : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public int SiteId { get; set; }
        
        public bool IsVisibleInCalendar { get; set; }
        
        public string NameInCalendar { get; set; }
        
        public string Color { get; set; }
        
        public int RelatedEntityId { get; set; }


        public async Task Create(eFormCaseManagementPnDbContext dbContext)
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Version = 1;
            WorkflowState = Constants.WorkflowStates.Created;

            await dbContext.CalendarUsers.AddAsync(this);
            await dbContext.SaveChangesAsync();

            await dbContext.CalendarUserVersions.AddAsync(MapVersion(this));
            await dbContext.SaveChangesAsync();
        }

        public async Task Update(eFormCaseManagementPnDbContext dbContext)
        {
            CalendarUser calendarUser = await dbContext.CalendarUsers
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (calendarUser == null)
            {
                throw new NullReferenceException($"Could not find Calendar User with ID: {Id}");
            }

            calendarUser.FirstName = FirstName;
            calendarUser.LastName = LastName;
            calendarUser.SiteId = SiteId;
            calendarUser.IsVisibleInCalendar = IsVisibleInCalendar;
            calendarUser.NameInCalendar = NameInCalendar;
            calendarUser.Color = Color;
            calendarUser.RelatedEntityId = RelatedEntityId;

            if (dbContext.ChangeTracker.HasChanges())
            {
                calendarUser.UpdatedAt = DateTime.UtcNow;
                calendarUser.UpdatedByUserId = UpdatedByUserId;
                calendarUser.Version += 1;

                await dbContext.CalendarUserVersions.AddAsync(MapVersion(calendarUser));
                await dbContext.SaveChangesAsync();
            }
            
        }

        public async Task Delete(eFormCaseManagementPnDbContext dbContext)
        {
            CalendarUser calendarUser = await dbContext.CalendarUsers
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (calendarUser == null)
            {
                throw new NullReferenceException($"Could not find Calendar User with ID: {Id}");
            }
            
            calendarUser.WorkflowState = Constants.WorkflowStates.Removed;

            if (dbContext.ChangeTracker.HasChanges())
            {
                calendarUser.UpdatedAt = DateTime.UtcNow;
                calendarUser.UpdatedByUserId = UpdatedByUserId;
                calendarUser.Version += 1;

                await dbContext.CalendarUserVersions.AddAsync(MapVersion(calendarUser));
                await dbContext.SaveChangesAsync();
            }
        }
        
        public CalendarUserVersions MapVersion(CalendarUser calendarUser)
        {
            CalendarUserVersions calendarUserVersion = new CalendarUserVersions
            {
                Version = calendarUser.Version,
                FirstName = calendarUser.FirstName,
                LastName = calendarUser.LastName,
                SiteId = calendarUser.SiteId,
                IsVisibleInCalendar = calendarUser.IsVisibleInCalendar,
                NameInCalendar = calendarUser.NameInCalendar,
                Color = calendarUser.Color,
                RelatedEntityId = calendarUser.RelatedEntityId,
                CreatedAt = calendarUser.CreatedAt,
                UpdatedAt = calendarUser.UpdatedAt,
                CreatedByUserId = calendarUser.CreatedByUserId,
                UpdatedByUserId = calendarUser.UpdatedByUserId,
                WorkflowState = calendarUser.WorkflowState,
                CalendarUserId = calendarUser.Id
            };

            return calendarUserVersion;
        }
    }
}