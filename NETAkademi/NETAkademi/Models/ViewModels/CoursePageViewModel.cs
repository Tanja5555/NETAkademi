using NETAkademi.Models.JsonUtils;
using NETAkademi.Models.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Find.Framework;

namespace NETAkademi.Models.ViewModels
{
    public class CoursePageViewModel : DefaultPageViewModel<CoursePage>
    {
        public CoursePageViewModel(CoursePage currentPage) : base(currentPage)
        {
        }

        public List<ClassEvent> ClassEvents { get; set; }
      
    }
    }