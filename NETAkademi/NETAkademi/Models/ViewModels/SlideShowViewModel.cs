using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using NETAkademi.Models.Blocks;
using NETAkademi.Models.Media;

 namespace NETAkademi.Models.ViewModels
{
    public class SlideShowViewModel
    {
        public SlideShowBlock CurrentBlock {get;set;}
        public List<ImageFile> Images { get; set; }
    }
}