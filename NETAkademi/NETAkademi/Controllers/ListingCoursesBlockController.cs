using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using NETAkademi.Models.Blocks;
using EPiServer.ServiceLocation;
using NETAkademi.Models.ViewModels;
using NETAkademi.Models.Pages;

namespace NETAkademi.Controllers
{
    public class ListingCoursesBlockController : BlockController<ListingCoursesBlock>
    {
        public override ActionResult Index(ListingCoursesBlock currentBlock)
        {
            var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();
            var model = new ListingCoursesBlockModel();
            model.Heading = currentBlock.Heading;
            if (currentBlock.RootPage != null)
            {
                model.Items = contentRepository.GetChildren<CoursePage>(currentBlock.RootPage);
                model.OnlineItems = contentRepository.GetChildren<OnlineCoursePage>(currentBlock.RootPage);
            }
            else
            {
                model.Items = null;
                model.OnlineItems = null;
            }

            return PartialView(model);
        }
    }
}
