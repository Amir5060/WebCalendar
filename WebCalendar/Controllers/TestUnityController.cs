using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCalendar.Test;

namespace WebCalendar.Controllers
{
    public class TestUnityController : Controller
    {
        private readonly IUnityTest testService;
        public TestUnityController(IUnityTest testService)
        {
            this.testService = testService;
        }
        // GET: TestUnity
        public ActionResult Index()
        {
            ViewBag.test = testService.TestForUnity();
            return View();
        }
    }
}