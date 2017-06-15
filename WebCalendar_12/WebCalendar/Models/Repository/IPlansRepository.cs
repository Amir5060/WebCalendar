using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCalendar.Models
{
    public interface IPlansRepository
    {
        Task<int> AddNewPlan(string userId, string planTitle, string planDescription, DateTime startDate, DateTime endDate, string backgroundColor);
    }
}
