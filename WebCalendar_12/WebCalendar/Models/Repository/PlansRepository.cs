﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Dapper;
using WebCalendar.Models.Database_Connection;

namespace WebCalendar.Models
{
    public class PlansRepository: IPlansRepository
    {
        IConnectionFactory _connectionFactory;
        public PlansRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public async Task<int> AddNewPlan(string userId, string planTitle, string planDescription, DateTime startDate, DateTime endDate, string backgroundColor)
        {
            var planId = await SqlMapper.QueryAsync(_connectionFactory.GetConnection, "INSERT INTO Planner (PlanTitle, PlanDescription, StartDate, EndDate, BackgroundColor, UserId) "
                + "VALUES (@PlanTitle, @PlanDescription, @StartDate, @EndDate, @BackgroundColor, @UserId)", 
                new { PlanTitle = planTitle, PlanDescription = planDescription, StartDate = startDate, EndDate = endDate, BackgroundColor = backgroundColor, UserId = userId});
            return 0;
        }
    }
}