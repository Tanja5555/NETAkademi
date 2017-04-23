using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using NETAkademi.Models.Pages;
using NETAkademi.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NETAkademi.Business
{
    public class PageContextActionFilter : IResultFilter
    {
        private readonly PageViewContextFactory _contextFactory;
        public PageContextActionFilter(PageViewContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var viewModel = filterContext.Controller.ViewData.Model;

            var model = viewModel as IPageViewModel<SitePageData>;
            if (model != null)
            {
                var currentContentLink = filterContext.RequestContext.GetContentLink();

                var layoutModel = model.Layout ?? _contextFactory.CreateLayoutModel(currentContentLink, filterContext.RequestContext);

                var layoutController = filterContext.Controller as IModifyLayout;
                if (layoutController != null)
                {
                    layoutController.ModifyLayout(layoutModel);
                }

                model.Layout = layoutModel;

                if (model.Section == null)
                {
                    model.Section = _contextFactory.GetSection(currentContentLink);
                }

                //Code for Search function that move from Navigation 
                var repo = ServiceLocator.Current.GetInstance<IContentRepository>();
                var start = repo.Get<NETAkademi.Models.Pages.StartPage>(PageReference.StartPage);

                var searchpagelink = start.SearchPageLink;

                var actionUrl = UrlResolver.Current.GetUrl(searchpagelink);
                model.SearchPageActionUrl = actionUrl;

            }
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }
    }

}
