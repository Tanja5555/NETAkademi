using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using NETAkademi.Models.Pages;
using NETAkademi.Models.ViewModels;

namespace NETAkademi.Controllers
{
    public class TeacherPageController : PageControllerBase<TeacherPage>
    {
        public ActionResult Index(TeacherPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            DefaultPageViewModel<TeacherPage> model = new DefaultPageViewModel<TeacherPage>(currentPage);

            return View(model);
        }
    }
}