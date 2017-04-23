using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace NETAkademi.Models.Pages
{
    [ContentType(DisplayName = "CourseBasePage", Description = "NETAkademi CourseBase Page")] //GUID = "737e15dc-36d0-4bb6-8b91-c52b425b1a1e", 
    public class CourseBasePage : StandardPage
    {
        
                
                [Display(
                   
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 305)]
        [UIHint(UIHint.Textarea)]
        public virtual string UniqueSellingPoints { get; set; }


        [CultureSpecific]
        [Display(
          Name = "CourseBase Main Content Area",
          Description = "The main content area will be shown at the bottom of the page.",
          GroupName = SystemTabNames.Content,
          Order = 300)]
        public virtual ContentArea CourseBaseMainContentArea { get; set; }

    }
}