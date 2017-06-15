using DataAccess.Repositories;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Services
{
    class PlanService: IPlanService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PlanService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> AddNewPlan(string userId, string planTitle, string planDescription, DateTime startDate, DateTime endDate, string backgroundColor)
        {
            return await _unitOfWork.PlanRepository.AddNewPlan(userId, planTitle, planDescription, startDate, endDate, backgroundColor);
        }
    }
}
