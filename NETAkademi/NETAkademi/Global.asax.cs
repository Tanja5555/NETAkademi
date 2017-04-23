using NETAkademi.Business.Initialization;
using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace NETAkademi
{
    public class EPiServerApplication : EPiServer.Global
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            //RouteConfig.RegisterRoutes(RouteTable.Routes); // Har försökt att lägga till denna men får felmeddelanden

            //Register JS and CSS bundles
            BundleConfig.RegisterBundles(BundleTable.Bundles);


            //Tip: Want to call the EPiServer API on startup? Add an initialization module instead (Add -> New Item.. -> EPiServer -> Initialization Module)
        }
    }
}