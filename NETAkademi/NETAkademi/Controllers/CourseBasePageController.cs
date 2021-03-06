﻿using System.Collections.Generic;
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
    public class CourseBasePageController : PageController<CourseBasePage>
    {
        public ActionResult Index(CourseBasePage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            DefaultPageViewModel<CourseBasePage> model = new DefaultPageViewModel<CourseBasePage>(currentPage);

            return View(model);
        }
    }
}