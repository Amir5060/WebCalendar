using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalendar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ThisWeek()
        {
            ViewBag.Message = "";
            return View();
        }

        public string Init()
        {
            return "";
            //bool rslt = Utils.InitialiseDiary();
            //return rslt.ToString();
        }

        public void UpdateEvent(int id, string NewEventStart, string NewEventEnd)
        {
            //DiaryEvent.UpdateDiaryEvent(id, NewEventStart, NewEventEnd);
        }


        public bool SaveEvent(string Title, string NewEventDate, string NewEventTime, string NewEventDuration)
        {
            return true;
            //return DiaryEvent.CreateNewEvent(Title, NewEventDate, NewEventTime, NewEventDuration);
        }

        public JsonResult GetDiarySummary(double start, double end)
        {
            //var ApptListForDate = DiaryEvent.LoadAppointmentSummaryInDateRange(start, end);
            //var eventList = from e in ApptListForDate
            //    select new
            //    {
            //        id = e.ID,
            //        title = e.Title,
            //        start = e.StartDateString,
            //        end = e.EndDateString,
            //        someKey = e.SomeImportantKeyID,
            //        allDay = false
            //    };
            //var rows = eventList.ToArray();
            //return Json(rows, JsonRequestBehavior.AllowGet);
            return null;
        }

        public JsonResult GetDiaryEvents(double start, double end)
        {
            //var ApptListForDate = DiaryEvent.LoadAllAppointmentsInDateRange(start, end);
            //var eventList = from e in ApptListForDate
            //    select new
            //    {
            //        id = e.ID,
            //        title = e.Title,
            //        start = e.StartDateString,
            //        end = e.EndDateString,
            //        color = e.StatusColor,
            //        className = e.ClassName,
            //        someKey = e.SomeImportantKeyID,
            //        allDay = false
            //    };
            //var rows = eventList.ToArray();
            //return Json(rows, JsonRequestBehavior.AllowGet);
            return null;
        }
    }
}