using System.Web.Mvc;
using NETAkademi.Models.Pages;
using NETAkademi.Models.ViewModels;

namespace NETAkademi.Controllers
{
    public class OnlineCoursePageController : PageControllerBase<OnlineCoursePage>
    {
        public ActionResult Index(OnlineCoursePage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            DefaultPageViewModel<OnlineCoursePage> model = new DefaultPageViewModel<OnlineCoursePage>(currentPage);
            return View(model);
        }
    }
}