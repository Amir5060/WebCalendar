using DataAccess.Entiteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Repositories
{
    public interface IPlansRepository: IGenericRepository<Plan>
    {
        Task<int> AddNewPlan(string userId, string planTitle, string planDescription, DateTime startDate, DateTime endDate, string backgroundColor);
    }
}
