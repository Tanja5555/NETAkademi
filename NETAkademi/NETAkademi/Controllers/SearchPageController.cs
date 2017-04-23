using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using NETAkademi.Models.Pages;
using NETAkademi.Models.ViewModels;
using System;
using EPiServer.Find;
using EPiServer.Find.Cms;
using EPiServer.Find.Framework;
using EPiServer.Find.UnifiedSearch;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;

namespace NETAkademi.Controllers
{
    //[TemplateDescriptor(Default = true)]
    public class SearchPageController : PageController<SearchPage>
    {
        public ActionResult Index(SearchPage currentPage, string q)
        {
            var model = new SearchPageViewModel(currentPage, q);

            if (string.IsNullOrEmpty(q))
            {
                return View(model);
            }

            var hitSpecification = new HitSpecification {HighlightExcerpt = true, HighlightTitle = true};

            var unifiedSearch = SearchClient.Instance.UnifiedSearchFor(q);
            model.Results = unifiedSearch.GetResult(hitSpecification);

            return View(model);
        }
    }
}