using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebCalendar.Models;

namespace WebCalendar.Hubs
{
    public class CalendarHub: Hub
    {
        static ConcurrentDictionary<string, string> dic = new ConcurrentDictionary<string, string>();
        //private IPlansRepository _planRepo;
        //public CalendarHub(IPlansRepository planRepo)
        //{
        //    _planRepo = planRepo;
        //}        
        public void Send(string userId, string name, DateTime startDate, DateTime endDate)
        {
            CalendarClass myCalendarClass = new CalendarClass();
            // 1. planColor => string
            // 2. The plandId should be returned so it could be passed to client part!
            //var planId = _planRepo.AddNewPlan(userId, name, "", startDate, endDate, "");
            Clients.All.broadCastMessage(userId, name, startDate, endDate);
        }

        public void NewUser(string guid, string name)
        {
            dic.TryAdd(guid, name);
            //Clients.Others.enters(guid);
        }
    }

    

    public class CalendarClass
    {
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Guid> UserId { get; set; }
    }
}