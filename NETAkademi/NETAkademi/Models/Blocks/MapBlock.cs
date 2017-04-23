using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace NETAkademi.Models.Blocks
{
    [ContentType(DisplayName = "MapBlock", GUID = "6da9f17b-8051-4aeb-9410-3eedacd9f6f0", Description = "A Block to show the location where we have oure courses")]
    public class MapBlock : BlockData
    {
        [CultureSpecific]
        [Display(
         Name = "Heading",
         Description = "Whrite what you want to say about the map",
         GroupName = SystemTabNames.Content,
         Order = 1)]
        public virtual string MapHeading { get; set; }

        [Required]
        [Display(
            Name = "Url for map",
            Description = "Fix a url from google maps and paste the iframe here",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHint(UIHint.Textarea)]
        public virtual string IFrameMapUrl { get; set; }
    }
}