using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace NETAkademi.Models.Blocks
{
    [ContentType(DisplayName = "ListingCoursesBlock", GUID = "98ec48c7-d8c5-493c-9d3b-38e1cf1b4eee", Description = "")]
    public class ListingCoursesBlock : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual String Heading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual PageReference RootPage { get; set; }
    }
}