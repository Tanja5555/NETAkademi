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

namespace NETAkademi.Controllers
{
    public class QuoteBlockController : BlockController<QuoteBlock>
    {
        public override ActionResult Index(QuoteBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
