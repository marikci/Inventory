using Inventory.App_Start;
using Inventory.Business;
using Inventory.Model.Interfaces;
using System.Web.Http;
using System.Web.Http.Cors;
using Unity;
using Unity.Lifetime;

namespace Inventory
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var container = new UnityContainer();
            container.RegisterType<ISoftwareCompanyOperations, SoftwareCompanyOperations>(new HierarchicalLifetimeManager());
            container.RegisterType<ISoftwareTypeOperations, SoftwareTypeOperations>(new HierarchicalLifetimeManager());
            container.RegisterType<IStockOperations, StockOperations>(new HierarchicalLifetimeManager());
            config.DependencyResolver = new DependencyResolver(container);
        }
    }
}
