using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebCalendar.Models
{
    public class WebCalendarViewModel
    {
        [Key]
        public int CalendarId { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string CalendarTitle { get; set; }
        [Display(Name = "Description")]
        public string CalendarDescription { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required]        
        public DateTime CreatedPlan { get; set; }
        [Required]
        public DateTime ModifiedPlan { get; set; }
        [Required]
        [Display(Name = "Plan Color")]
        public string PlanColor { get; set; }
        [Required]
        public string UserId { get; set; }
    }
}