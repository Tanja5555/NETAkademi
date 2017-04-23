using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using NETAkademi.Models.Blocks;
using EPiServer;

namespace NETAkademi.Models.Pages 
{
    [ContentType(DisplayName = "StartPage",
        GUID = "5d06c147-bdda-4a8a-9b7b-dbbe1359da09",
        Description = "NETAkademi Start Page",
        GroupName = Global.GroupNames.Specialized)]
    public class StartPage : SitePageData
    {

        //[CultureSpecific]
        //[Display(
        //    Name = "Main body",
        //    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
        //    GroupName = SystemTabNames.Content,
        //    Order = 1)]
        //public virtual XhtmlString MainBody { get; set; }

        //[CultureSpecific]
        //[Display(
        //   Name = "Heading",
        //   GroupName = SystemTabNames.Content,
        //   Order = 0)]
        //public virtual string Heading { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Slide Show Content Area",
            Description = "Write youre content here",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual ContentArea SlideShowContentArea { get; set; }


        [Display(Order = 320, GroupName = SystemTabNames.Content)]
        public virtual TeaserBlock Teaser { get; set; }

        [Display(Order = 330, GroupName = SystemTabNames.Content)]
        public virtual QuoteBlock CompanyQuote1 { get; set; }

        [Display(Order = 330, GroupName = SystemTabNames.Content)]
        public virtual QuoteBlock CompanyQuote2 { get; set; }

        [Display(Order = 330, GroupName = SystemTabNames.Content)]
        public virtual QuoteBlock CompanyQuote3 { get; set; }

        [Display(Order = 330, GroupName = SystemTabNames.Content)]
        public virtual QuoteBlock CompanyQuote4 { get; set; }



        [CultureSpecific]
        [Display(
            Name = "Advertisement Content Area",
            Description =
                "Drag the pages you wish to promote on the startpage here. Ideally they should be displayed in 1/3 size",
            GroupName = SystemTabNames.Content,
            Order = 340)]
        public virtual ContentArea AdvertisementContentArea { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Partner Content Area",
            Description = "Drag the Partner Blocks you wish to feature on your start page here.",
            GroupName = SystemTabNames.Content,
            Order = 340)]
        public virtual ContentArea PartnerContentArea { get; set; }


        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 300)]
        public virtual LinkItemCollection ProductPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 350)]
        public virtual LinkItemCollection CompanyInformationPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 400)]
        public virtual LinkItemCollection NewsPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 450)]
        public virtual LinkItemCollection CustomerZonePageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual SiteLogotypeBlock SiteLogotype { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference SearchPageLink { get; set; }

        [Display(
            Name = "Url",
            GroupName = SystemTabNames.Content,
            Order = 350)]
        public virtual Url CourseListUrl { get; set; }

        [Display(
            Name = "Parent",
            GroupName = SystemTabNames.Content,
            Order = 360)]
        public virtual ContentReference CourseParentPage { get; set; }

        [Display(
           Name = "Parent2",
           GroupName = SystemTabNames.Content,
           Order = 370)]
        public virtual ContentReference CourseParentPage2 { get; set; }
    }
}