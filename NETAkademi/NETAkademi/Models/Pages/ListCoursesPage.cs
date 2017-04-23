using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using NETAkademi.Models.Blocks;

namespace NETAkademi.Models.Pages
{
    [ContentType(DisplayName = "ListCoursesPage", 
        GUID = "43e65c12-8843-4d46-bde0-62ff20d64029", 
        Description = "Display information about listing of all coourses")]
    public class ListCoursesPage : SitePageData
    {

        [Display(
            Name = "Main Course Listing",
            Description = "A listing of courses",
            GroupName = SystemTabNames.Content,
            Order = 315)]
        public virtual ListingCoursesBlock MainListing { get; set; }

        //[CultureSpecific]
        //[Display(
        //    Name = "Main body",
        //    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
        //    GroupName = SystemTabNames.Content,
        //    Order = 4)]
        //public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Course Subject",
            Description = "The course subject will be shown above the main body.",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual string CourseSubject { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Course Description",
            Description = "The Course Description will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual XhtmlString CourseSubjectDescription { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Righthand Content Area",
          Description = "The righthand content area will be shown to the right of the Main Body text.",
          GroupName = SystemTabNames.Content,
          Order = 400)]
        public virtual ContentArea RighthandContentArea { get; set; }


    }
}