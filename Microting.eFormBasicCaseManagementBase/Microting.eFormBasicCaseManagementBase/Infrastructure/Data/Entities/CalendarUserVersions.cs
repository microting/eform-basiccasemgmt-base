using System.ComponentModel.DataAnnotations.Schema;
using Microting.eFormApi.BasePn.Infrastructure.Database.Base;

namespace Microting.eFormBasicCaseManagementBase.Infrastructure.Data.Entities
{
    public class CalendarUserVersions : BaseEntity
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public int SiteId { get; set; }
        
        public bool IsVisibleInCalendar { get; set; }
        
        public string NameInCalendar { get; set; }
        
        public string Color { get; set; }
        
        [ForeignKey("CalendarUser")]
        public int CalendarUserId { get; set; }
        
        public int RelatedEntityId { get; set; }

    }
}