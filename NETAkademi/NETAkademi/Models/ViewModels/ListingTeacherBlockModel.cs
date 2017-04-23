using NETAkademi.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NETAkademi.Models.ViewModels
{
    public class ListingTeacherBlockModel
    {
        public String Heading { get; set; }
        public IEnumerable<TeacherPage> Items { get; set; }

    }
}