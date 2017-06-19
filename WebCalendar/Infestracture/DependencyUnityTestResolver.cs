using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCalendar.Infestracture
{
    public class DependencyUnityTestResolver : IDependencyResolver
    {
        private readonly IUnityContainer unityContainer;
        public DependencyUnityTestResolver(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }
        public object GetService(Type serviceType)
        {
            try
            {
                return unityContainer.Resolve(serviceType);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return unityContainer.ResolveAll(serviceType);
            }
            catch (Exception ex)
            {
                return new List<object>();
            }
        }
    }
}