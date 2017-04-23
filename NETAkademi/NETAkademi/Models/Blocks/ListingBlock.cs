using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace NETAkademi.Models.Blocks
{
    [ContentType(DisplayName = "ListingBlock", GUID = "1afdca06-5022-48fc-9b14-219e3dc61faa", Description = "")]
    public class ListingBlock : BlockData
    {

        [Display(
          GroupName = SystemTabNames.Content,
          Order = 100)]
        public virtual string Heading { get; set; }


        [Display(
          GroupName = SystemTabNames.Content,
          Order = 200)]
        public virtual PageReference RootPage { get; set; }

    }
}