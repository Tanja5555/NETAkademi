using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace NETAkademi.Models.Pages
{

    [ContentType(
        DisplayName = "Standard Page",
        GUID = "3cd44abd-0e44-418e-b643-895353869e8e",
        Description = "A page with a sidebar, a heading, an area for writing text and a content area for adding blocks at the bottom.")
        ]
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Heading",
            Description = "The heading will be shown above the main body.",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Main Content Area",
           Description = "The main content area will be shown at the bottom of the page.",
           GroupName = SystemTabNames.Content,
           Order = 300)]
        public virtual ContentArea MainContentArea { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Righthand Content Area",
           Description = "The righthand content area will be shown to the right of the Main Body text. Its intended use is for maps or photos.",
           GroupName = SystemTabNames.Content,
           Order = 400)]
        public virtual ContentArea RighthandContentArea { get; set; }
    }
}