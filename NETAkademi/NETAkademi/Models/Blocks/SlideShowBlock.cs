using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace NETAkademi.Models.Blocks
{
    [ContentType(DisplayName = "SlideShowBlock", GUID = "e0f4a13b-a6eb-43be-a1e2-115294f65125", Description = "")]
    public class SlideShowBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "SlideShowBlock",
            Description = "Block for slideshow, just add some images and use it")]
        [AllowedTypes(typeof(ContentFolder))]
        public virtual ContentReference ImageFolder { get; set; }

        public virtual bool HideCaption { get; set; }

    }
}