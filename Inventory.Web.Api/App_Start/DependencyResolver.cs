using System;
using System.Collections.Generic;
using System.Web.Http.Dependencies;
using Unity;

namespace Inventory.App_Start
{
    public sealed class DependencyResolver : IDependencyResolver
    {
        private readonly IUnityContainer _container;

        public DependencyResolver(IUnityContainer container)
        {
            this._container = container ?? throw new ArgumentNullException("container");
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch (ResolutionFailedException)
            {
                return new List<object>();
            }
        }

        public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new DependencyResolver(child);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            _container.Dispose();
        }
    }
}