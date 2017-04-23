using System.Web.Mvc;
using EPiServer.Web.Mvc;
using NETAkademi.Models.Blocks;

namespace NETAkademi.Controllers
{
    public class TeaserBlockController : BlockController<TeaserBlock>
    {
        public override ActionResult Index(TeaserBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
