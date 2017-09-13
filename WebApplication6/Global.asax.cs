using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using WebApplication6.App_Start;
using WebApplication6.Dtos;
using WebApplication6.Models;

namespace WebApplication6
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(c => c.AddProfile(typeof(MappingProfile)));

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            
        }
    }
}
