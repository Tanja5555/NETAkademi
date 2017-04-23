using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace NETAkademi.Models.Pages
{
    [AvailableContentTypes(
        //Include= new Type[] { typeof(StartPage)}, // Ändra startPage till KursListSidan
        //IncludeOn= new Type[] { typeof(StartPage)},
        Availability = Availability.None)]
    [ContentType(DisplayName = "Course Page", GUID = "c1983dd1-ab11-4053-8976-0d088117acde", Description = "Displays information about a specific course.")]
    public class CoursePage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
        Name = "Course Topic",
        Description = " Enter the course topic",
        GroupName = SystemTabNames.Content,
        Order = 0)]
        public virtual string Topic { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Course Code",
          Description = " Enter the course code",
          GroupName = SystemTabNames.Content,
          Order = 1)]
        public virtual string CourseCode { get; set; }

        [CultureSpecific]
        [Display(
                Name = "Price",
                Description = "Price of the course",
                GroupName = SystemTabNames.Content,
                Order = 2)]
        public virtual int Price { get; set; }

        [CultureSpecific]
        [Display(
                Name = "Course Length",
                Description = "Write here how many days the course is",
                GroupName = SystemTabNames.Content,
                Order = 3)]
        public virtual int CourseLength { get; set; }

        [CultureSpecific]
        [Display(
               Name = "Prerequisites",
               Description = "Write here the knowledge they need prior to this course",
               GroupName = SystemTabNames.Content,
               Order = 5)]
        public virtual XhtmlString Knowledge { get; set; }


        [CultureSpecific]
        [Display(
               Name = "Subjects",
               Description = "Write here what is included in the course in bullet form, eg which lectures, etc.",
               GroupName = SystemTabNames.Content,
               Order = 6)]
        public virtual XhtmlString SubjectAreas { get; set; }


        [CultureSpecific]
        [Display(
               Name = "Target Audience",
               Description = "Which target audience this course is aiming for",
               GroupName = SystemTabNames.Content,
               Order = 7)]
        public virtual XhtmlString TargetGroup { get; set; }


    }
}