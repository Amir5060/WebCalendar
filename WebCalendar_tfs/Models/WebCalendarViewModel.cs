using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalendar.Models
{
    public class WebCalendarViewModel
    {
        public int CalendarId { get; set; }
        public string CalendarTitle { get; set; }
        public string CalendarDescription { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedPlan { get; set; }
        public DateTime ModifiedPlan { get; set; }
        public int PlanColor { get; set; }
        public string UserId { get; set; }
    }
}