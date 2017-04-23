using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using EPiServer.DataAbstraction;
using EPiServer.PlugIn;
using System.Net.Http;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAccess;
using EPiServer.Security;
using EPiServer.ServiceLocation;
using NETAkademi.Models.Pages;
namespace NETAkademi.Business.Jobs
{
    [ScheduledPlugIn(DisplayName = "Course Job",
        DefaultEnabled = false,
        IntervalLength = 1,
        IntervalType = ScheduledIntervalType.Minutes)]

    public class CourseJob
    {
        //todo: hämta inställningar från startsidan: url för kurslista och id för parent sida
        //Lägg till egenskaper på StartPage sidtypen. Använd datatypen Url respektive ContentReference
        //Som redaktör: skapa en sida som ska innehålla alla kurser och peka ut den på startsidan 
        // samt sätt url-egenskapen att peka på "http://fredrikhaglund.se/lab/courses/CourseList.txt"
        // Lägg in kod som laddar startsidan med hjälp av IContentRepository och metoden Get

        public static string Execute()
        {
            var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();

            var startPage = contentRepository.Get<StartPage>(ContentReference.StartPage);

            // Input validation - Check that we have resonable settings.
            //if (startPage.CourseListUrl == null)
            //{
            //    throw new Exception("Set CourseListUrl on start page");
            //}
            //if (ContentReference.IsNullOrEmpty(startPage.CourseParentPage))
            //{
            //    throw new Exception("Select parent page with CourseParentPage on start page");
            //}

            var url = startPage.CourseListUrl.Uri;
            var courseListRootpage = startPage.CourseParentPage;


            var webClient = new WebClient();
            var data = webClient.DownloadString(url);

            var rows = data.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            var coursePages = contentRepository.GetChildren<CoursePage>(courseListRootpage).ToList();

            foreach (var row in rows)
            {
                var cols = row.Split(';');

                var coursename = cols[0];
                var teacher = cols[1];
                var description = cols[2];


                var coursePage = coursePages.FirstOrDefault(c => c.Name == coursename);

                if (coursePage == null)
                {
                    coursePage = contentRepository.GetDefault<CoursePage>(courseListRootpage);
                }
                else
                {
                    coursePages.Remove(coursePage);
                    coursePage = coursePage.CreateWritableClone() as CoursePage;
                }

                coursePage.Name = coursename;
                coursePage.MetaDescription = description;
                contentRepository.Save(coursePage, SaveAction.Publish);


            }

            //foreach (var coursePage in coursePages)
            //{
            //    contentRepository.Delete(coursePage.ContentLink, false);
            //}


            return string.Format("Done importing {0} courses", rows.Length);
        }
    }
}
