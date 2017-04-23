using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NETAkademi.Models.Pages
{
    public abstract class SitePageData : PageData
    {
        [CultureSpecific]
        [Display(
          GroupName = "SEO",
          Order = 100)]
        public virtual string MetaTitle { get; set; }


        [CultureSpecific]
        [Display(
          GroupName = "SEO",
          Order = 200)]

        public virtual string MetaKeywords { get; set; }

        [CultureSpecific]
        [Display(
          GroupName = "SEO",
          Order = 300)]
        [UIHint(UIHint.Textarea)]

        public virtual string MetaDescription { get; set; }

        [Display(
           GroupName = "SEO",
           Name = "PropertyID for Google Analytics",
           Order = 400)]
        public virtual string PropertyID { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = "Teaser",
            Order = 100)]
        [UIHint(UIHint.Image)]

        public virtual EPiServer.Core.ContentReference PageImage { get; set; }

        [CultureSpecific]
        [Display(
         GroupName = "Teaser",
         Order = 200)]
        [UIHint(UIHint.Textarea)]

        public virtual string TeaserText { get; set; }

        [Display(
            GroupName = SystemTabNames.Settings,
            Order = 200)]
        [CultureSpecific]
        public virtual bool HideSiteHeader { get; set; }

        [Display(
            GroupName = SystemTabNames.Settings,
            Order = 300)]
        [CultureSpecific]
        public virtual bool HideSiteFooter { get; set; }

        public string ContentAreaCssClass
        {
            get { return "teaserblock"; } //Page partials should be style like teasers
        }


    }
}