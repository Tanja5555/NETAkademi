using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using NETAkademi.Models.ViewModels;
using NETAkademi.Models.Blocks;

namespace NETAkademi.Models.Pages
{
    [ContentType(
        DisplayName = "ListingTeacherPage", 
        GUID = "7e0c4284-273f-46ab-bb53-b63392326329", 
        Description = "Show List of teachers")]
    public class ListingTeacherPage : SitePageData
    {
        [Display(
           Name = "Main Teacher Listing",
           Description = "A listing of teacher",
           GroupName = SystemTabNames.Content,
           Order = 315)]
        public virtual ListingTeacherBlock MainListing { get; set; }

        [Display(
           Name = "Map",
           Description = "A listing of teacher",
           GroupName = SystemTabNames.Content,
           Order = 315)]
        public virtual MapBlock MapBlock { get; set; }

    }
}