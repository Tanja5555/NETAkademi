using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer;

namespace NETAkademi.Models.Blocks
{
    [SiteContentType(
       GUID = "166b4f6d-b02c-4b1f-872a-a7fe42d059c6",
       AvailableInEditMode = false)] // Should not be created and added to content areas by editors, the SiteLogotypeBlock is only used as a property type
    [SiteImageUrl]
    public class SiteLogotypeBlock : SiteBlockData
    {
        /// <summary>
        /// Gets the site logotype URL
        /// </summary>
        /// <remarks>If not specified a default logotype will be used</remarks>
        [DefaultDragAndDropTarget]
        [UIHint(EPiServer.Web.UIHint.Image)]
        public virtual EPiServer.Url Url
        {
            get
            {
                var url = this.GetPropertyValue(b => b.Url);

                return url == null || url.IsEmpty()
                           ? new Url("/Static/gfx/logotype.png")
                           : url;
            }
            set
            {
                this.SetPropertyValue(b => b.Url, value);
            }
        }

        [CultureSpecific]
        public virtual string Title { get; set; }
    }
}
