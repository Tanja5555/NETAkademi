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
    public class ListingTeacherBlockController : BlockController<ListingTeacherBlock>
    {
        public override ActionResult Index(ListingTeacherBlock currentBlock)
        {
            var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();
            var model = new ListingTeacherBlockModel();

            model.Heading = currentBlock.Heading;
            if (currentBlock.RootPage != null)
            {
                model.Items = contentRepository.GetChildren<TeacherPage>(currentBlock.RootPage);
              
            }
            else
            {
                model.Items = null;
            
            }

            return PartialView(model);
       
        }
    }
}
