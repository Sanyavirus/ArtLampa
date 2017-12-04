using DomMezonin.DomainModel.DataBase;
using DomMezonin.DomainModel.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DomMezonin
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            using (ArtLampaContext ctx = new ArtLampaContext())
            {
                ctx.Images.Add(new Image() { Height = 400, Width = 400, Path = "newpath.jpg" });
                ctx.SaveChanges();
            }
        }
    }
}
