using System;
using System.Collections.Generic;
using SportsStore.WebUI.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using SportsStore.Domain.Entities;
using SportsStore.WebUI.Binders;

namespace SportsStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
			// in het boek wordt er ook WebApiConfig.Register(GlobalConfiguration.Configuration);
			ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
			ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());

		}
    }
}
