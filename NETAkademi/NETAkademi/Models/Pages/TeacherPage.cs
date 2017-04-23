using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer;
using EPiServer.Web;

namespace NETAkademi.Models.Pages
{
    [AvailableContentTypes(
      
        Availability = Availability.None)]
    [ContentType(
        DisplayName = "TeacherPage", 
        GUID = "7f976f70-7a2c-4b3d-b98f-45cb5fd34ece", 
        Description = "Information about a teacher")]
    public class TeacherPage : SitePageData
    {
        [CultureSpecific]
        [Display(
         Name = "Heading",
         GroupName = SystemTabNames.Content,
         Order = 0)]
        public virtual string Heading { get; set; }

        [Display(
            Name = "Teacher Image",
            Description = "Select teacher's image",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference TeacherImage { get; set; }


        [CultureSpecific]
        [Display(
            Name = "Teacher Name",
            Description = "Enter teacher name",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string TeacherName { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Teacher Lastname",
            Description = "Enter teacher lastname",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual string TeacherLastname { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Teacher Telephone",
            Description = "Enter teacher telephone",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual string TeacherTelephone { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Teacher Email",
            Description = "Enter teacher email",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        public virtual string TeacherEmail { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Teacher Course Subject",
            Description = "Enter teacher's course subject",
            GroupName = SystemTabNames.Content,
            Order = 6)]
        public virtual string CourseSubject { get; set; }

        [CultureSpecific]
        [Display(
         Name = "Linkedin Link",
         Description = "",
         GroupName = SystemTabNames.Content,
         Order = 7)]
        public virtual Url LinkedinLink { get; set; }

        [CultureSpecific]
        [Display(
             Name = "Biography",
             Description = "Write about teacher' biography",
             GroupName = SystemTabNames.Content,
             Order = 8)]
        public virtual XhtmlString Biography { get; set; }


    }


}