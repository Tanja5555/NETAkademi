using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace NETAkademi.Models.Pages
{
    [AvailableContentTypes(
        Availability = Availability.None)] //To not able to create new page have to set Availability.None
    [ContentType(DisplayName = "OnlineCoursePage", GUID = "1ab98ce2-dce9-4ffc-93ee-ba3555218d87", Description = "Displays information about a specific online course.")]
    public class OnlineCoursePage : SitePageData
    {
        

        [CultureSpecific]
        [Display(
          Name = "Course Level",
          GroupName = SystemTabNames.Content,
          Order = 1)]
        public virtual string Level { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Course Duration",
          GroupName = SystemTabNames.Content,
          Order = 2)]
        public virtual string Duration { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Released",
          GroupName = SystemTabNames.Content,
          Order = 3)]
        public virtual string ReleaseDate { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Course Author",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual string Author { get; set; }

        [Display(
            Name = "Author's Image",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 6)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Course Title 1",
           GroupName = SystemTabNames.Content,
           Order = 7)]
        public virtual string CourseTitle1 { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Course Description 1",
          GroupName = SystemTabNames.Content,
          Order = 8)]
        public virtual XhtmlString CourseDescription1 { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Course Title 2",
          GroupName = SystemTabNames.Content,
          Order = 9)]
        public virtual string CourseTitle2 { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Course Description 2",
        GroupName = SystemTabNames.Content,
        Order = 10)]
        public virtual XhtmlString CourseDescription2 { get; set; }


        [CultureSpecific]
        [Display(
          Name = "Course Title 3",
          GroupName = SystemTabNames.Content,
          Order = 11)]
        public virtual string CourseTitle3 { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Course Description 3",
        GroupName = SystemTabNames.Content,
        Order = 12)]
        public virtual XhtmlString CourseDescription3 { get; set; }


        [CultureSpecific]
        [Display(
          Name = "Course Title 4",
          GroupName = SystemTabNames.Content,
          Order = 13)]
        public virtual string CourseTitle4 { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Course Description 4",
        GroupName = SystemTabNames.Content,
        Order = 14)]
        public virtual XhtmlString CourseDescription4 { get; set; }


        [CultureSpecific]
        [Display(
          Name = "Course Title 5",
          GroupName = SystemTabNames.Content,
          Order = 15)]
        public virtual string CourseTitle5 { get; set; }

        
        [CultureSpecific]
        [Display(
         Name = "Course Description 5",
         GroupName = SystemTabNames.Content,
         Order = 16)]
        public virtual XhtmlString CourseDescription5 { get; set; }

    }
}