using DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WebCalendar.Models
{
    public class PlanViewModel
    {
        private IPlanService planService;
        public PlanViewModel(IPlanService planService)
        {
            this.planService = planService;
        }

        public async Task<int> AddNewPlan(string userId, string planTitle, string planDescription, DateTime startDate, DateTime endDate, string backgroundColor)
        {
            return await planService.AddNewPlan(userId, planTitle, planDescription, startDate, endDate, backgroundColor);
        }
    }
}