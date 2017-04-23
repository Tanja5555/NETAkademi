using EPiServer.Core;
using NETAkademi.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NETAkademi.Models.ViewModels
{
    public class ListingCoursesBlockModel
    {
        public String Heading { get; set; }
        public IEnumerable<CoursePage> Items { get; set; }

        public IEnumerable<OnlineCoursePage> OnlineItems { get; set; }

    }
}