using EPiServer.DataAbstraction;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using NETAkademi.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NETAkademi.Controllers
{
    [TemplateDescriptor(Inherited =true)]
    public class PagePartialController : PartialContentController<SitePageData>
    {
        // GET: PagePartial
        public override ActionResult Index(SitePageData currentContent)
        {
            return PartialView("/Views/Shared/PagePartials/PagePartial.cshtml", currentContent);
        }
    }
}