using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace NETAkademi.Models.Blocks
{
    [ContentType(
        DisplayName = "ListingTeacherBlock", 
        GUID = "3a226451-0656-46f1-86c6-3b05174cf0cb", 
        Description = "")]
    public class ListingTeacherBlock : BlockData
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