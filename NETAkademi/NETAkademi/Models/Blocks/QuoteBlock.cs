using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using  EPiServer;

namespace NETAkademi.Models.Blocks
{
    [ContentType(DisplayName = "QuoteBlock", GUID = "38961459-3f15-4279-993a-f1c7f36b1d80", Description = "Här kan du lägga in kundcitat")]
    public class QuoteBlock : BlockData
    {
    
        [Display(
         GroupName = SystemTabNames.Content,
         Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference QuoteImage { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string QuoteHeading { get; set; }

        [Display(
           GroupName = SystemTabNames.Content,
           Order = 500)]
        public virtual string QuoteCompany { get; set; }

        [Display(
                  GroupName = SystemTabNames.Content,
                  Order = 600)]
        public virtual XhtmlString QuoteText { get; set; }
    }
}