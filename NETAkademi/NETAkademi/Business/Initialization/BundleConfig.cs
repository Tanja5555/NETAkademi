using System;
using System.Linq;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System.Web.Optimization;

namespace NETAkademi.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class BundleConfig : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (context.HostType == HostType.WebApplication)
            {
                RegisterBundles(BundleTable.Bundles);
            }
        }

        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Scripts/jquery-2.2.3.js",
                        "~/Scripts/bootstrap.js"));

            //"~/Static/js/jquery.js",
            // "~/Static/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Content/bootstrap.css", new CssRewriteUrlTransform())
                //.Include("~/Content/bootstrap-theme.css")
                .Include("~/Content/Site.css", new CssRewriteUrlTransform()));
                //.Include("~/Templates/Editor.css"));
            
            //.Include("~/Content/bootstrap-theme.min.css")
            //.Include("~/Content/bootstrap.min.css"));
            //.Include("~/Static/css/media.css")

            //.Include("~/Static/css/editmode.css"));

            //BundleTable.EnableOptimizations = true;
        }


        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }

        public void Preload(string[] parameters)
        {
        }
    }
}