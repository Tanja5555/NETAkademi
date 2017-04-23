using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using NETAkademi.Models.JsonUtils;
using NETAkademi.Models.Pages;
using NETAkademi.Models.ViewModels;

namespace NETAkademi.Controllers
{
    public class CoursePageController : PageControllerBase<CoursePage>
    {
        public ActionResult Index(CoursePage currentPage)
        {
            var resultat = SearchClient.Instance.Search<ClassEvent>().Filter(x => x.Course.CourseCode.Match(currentPage.CourseCode)).GetResult();

            CoursePageViewModel model = new CoursePageViewModel(currentPage);

           model.ClassEvents = resultat.ToList();
            return View(model);

        }
    }
}

//var hitSpecification = new HitSpecification { HighlightExcerpt = true, HighlightTitle = true };

//var unifiedSearch = SearchClient.Instance.UnifiedSearchFor(q);
//model.Results = unifiedSearch.GetResult(hitSpecification);