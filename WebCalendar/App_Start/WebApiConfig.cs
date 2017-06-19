using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebCalendar.Infestracture;
using WebCalendar.Test;

namespace WebCalendar.App_Start
{
    public static class WebApiConfig
    {
       public static void Register(HttpConfiguration config)
       {
            var container = new UnityContainer();
            RegisterServices(container);
            DependencyResolver.SetResolver(new DependencyUnityTestResolver(container));
       }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IUnityTest, UnityTest>();
        }
    }
}