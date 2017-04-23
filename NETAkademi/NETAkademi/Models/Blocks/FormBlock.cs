using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.XForms;

namespace NETAkademi.Models.Blocks
{
    [SiteContentType(
        DisplayName = "FormBlock", 
        GUID = "bc690a1e-2009-426f-a578-e9c4f0a79dfb",
        GroupName = Global.GroupNames.Specialized,
        Description = "Using for create a form")]
    [SiteImageUrl]
    public class FormBlock : SiteBlockData
    {
        [Display(
             GroupName = SystemTabNames.Content,
             Order = 1)]
        [CultureSpecific]
        public virtual string Heading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [CultureSpecific]
        public virtual XForm Form { get; set; }
    }
}
