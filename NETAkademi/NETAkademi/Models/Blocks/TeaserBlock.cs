using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using EPiServer;

namespace NETAkademi.Models.Blocks
{
    [ContentType(DisplayName = "TeaserBlock", Description = "")] //GUID = "3ec2370a-21eb-4000-bd5b-38ce4e35cc2e"
    public class TeaserBlock : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TeaserImage { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual string TeaserHeading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 300)]
        [UIHint(UIHint.Textarea)]
        public virtual XhtmlString TeaserText { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 400)]
        public virtual Url TeaserLink { get; set; }

    }
}