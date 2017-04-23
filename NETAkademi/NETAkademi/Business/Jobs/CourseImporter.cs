using System;
using EPiServer.Core;
using EPiServer.PlugIn;
using EPiServer.Scheduler;
//using EPiServer.Personalization;
using EPiServer.ServiceLocation;
using EPiServer;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Linq;
using NETAkademi.Models.Pages;
using NETAkademi.Models.JsonUtils;
using System.Collections.Generic;
using EPiServer.DataAccess;

namespace NETAkademi.Business.Jobs
{
    [ScheduledPlugIn(DisplayName = "CourseImporter")]
    public class CourseImporter : ScheduledJobBase
    {
        private bool _stopSignaled;

        public CourseImporter()
        {
            IsStoppable = true;
        }

        public override void Stop()
        {
            _stopSignaled = true;
        }

        public override string Execute()
        {
            //OnStatusChanged(String.Format("Starting execution of {0}", this.GetType()));

            DoImport().Wait();




            if (_stopSignaled)
            {
                return "Stop of job was called";
            }

            return "OK";
        }


        private async Task DoImport()
        {
            var repo = ServiceLocator.Current.GetInstance<IContentRepository>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://epi15-lms.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("api/Courses?take=500");
                if (response.IsSuccessStatusCode)
                {
                    var test = await response.Content.ReadAsStringAsync();
                    var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();
                    var startPage = contentRepository.Get<StartPage>(ContentReference.StartPage);
                    var courseRootPage = startPage.CourseParentPage2;

                    var courses = await response.Content.ReadAsAsync<List<Course>>();
                    var coursePages = contentRepository.GetChildren<CoursePage>(courseRootPage).ToList();
                    //var parent = courseRootPage;
                    var existingPages = repo.GetChildren<CoursePage>(courseRootPage, LanguageSelector.AutoDetect(true)).ToList();


                    foreach (var course in courses)
                    {
                        CoursePage page = null;
                        // Kolla om sidan finns

                        page = existingPages.FirstOrDefault(p => p.CourseCode == course.CourseCode);
                        if (page != null)
                        {
                            page = (CoursePage)page.CreateWritableClone();
                        }
                        else
                        {
                            page = repo.GetDefault<CoursePage>(courseRootPage);
                        }

                        UpdatePageFromCourse(course, page);

                        if (page.Status == VersionStatus.Published)
                        {
                            repo.Save(page, SaveAction.Publish);
                        }
                        else
                        {
                            repo.Save(page, SaveAction.Save);
                        }
                    }
                }
            }
        }

        private static void UpdatePageFromCourse(Course course, CoursePage page)
        {
            page.Name = course.Name;
            page.CourseCode = course.CourseCode;
            page.Price = course.DefaultPrice;
            page.CourseLength = course.Duration;
            page.Topic = course.Topic.Name;
        }

    }
}
