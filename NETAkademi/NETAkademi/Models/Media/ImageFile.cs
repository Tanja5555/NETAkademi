using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace NETAkademi.Models.Media
{
    [ContentType(DisplayName = "DefaultMedia1", GUID = "c5acd224-b47d-4674-816c-37efd4f9a40f", Description = "")]
    /*[MediaDescriptor(ExtensionString = "pdf,doc,docx")]*/
    public class ImageFile : ImageData
    {

        public virtual string Heading { get; set; }
        public virtual string Description { get; set; }

    }
}