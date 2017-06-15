using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalendar.Hubs
{
    public class CalendarHub: Hub
    {
        static ConcurrentDictionary<string, string> dic = new ConcurrentDictionary<string, string>();

        public void Send(string userId, string name, DateTime startDate, DateTime endDate)
        {
            CalendarClass myCalendarClass = new CalendarClass();
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