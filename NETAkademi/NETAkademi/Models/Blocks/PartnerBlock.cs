using System;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using NETAkademi.Models.Media;
using EPiServer.Web;
using EPiServer;

namespace NETAkademi.Models.Blocks
{
    [ContentType(DisplayName = "PartnerBlock", GUID = "bf0f000a-141f-4b98-90de-bce5bf3ce639", Description = "")]
    public class PartnerBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Partner Logo",
            Description = "The logo for the partner who has provided certification to NETAkademi",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [UIHint(UIHint.Image)]
        [AllowedTypes(typeof(ImageFile))]
        public virtual ContentReference PartnerLogo { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Partner Link",
            Description = "A clickable link for your partners website.",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual Url PartnerLink { get; set; }


    }
}