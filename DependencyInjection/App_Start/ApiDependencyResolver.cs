using Autofac;
using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using System.Web.Mvc;

namespace DependencyInjection.App_Start
{
    public class ApiDependencyResolver : System.Web.Http.Dependencies.IDependencyResolver
    {
        private readonly IComponentContext _container;

        public ApiDependencyResolver(IContainer container)
        {
            _container = container;
        }

        public IDependencyScope BeginScope()
        {
            return this;
        }

        public void Dispose()
        {
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == null)
            {
                throw new ArgumentNullException("serviceType");
            }
            var ret = _container.ResolveOptional(serviceType);
            return ret;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            if (serviceType == null)
            {
                throw new ArgumentNullException("serviceType");
            }
            Type enumerableType = typeof(IEnumerable<>).MakeGenericType(serviceType);
            var ret = (IEnumerable<object>)_container.ResolveOptional(enumerableType);
            return ret;
        }
    }
}