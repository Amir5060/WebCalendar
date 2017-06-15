using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebCalendar.App_Start
{
    public class WebApiConfig
    {
       public static void Register(HttpConfiguration config)
       {
            var container = new UnityContainer();

       }
    }
}