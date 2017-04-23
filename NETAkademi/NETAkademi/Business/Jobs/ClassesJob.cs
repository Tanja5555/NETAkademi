using System;
using EPiServer.Core;
using EPiServer.PlugIn;
using EPiServer.Scheduler;
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
using EPiServer.Find;
using Newtonsoft.Json;

namespace NETAkademi.Business.Jobs
{
    [ScheduledPlugIn(DisplayName = "Classes Job")]
    public class ClassesJob : ScheduledJobBase
    {
        private bool _stopSignaled;

        public ClassesJob()
        {
            IsStoppable = true;
        }

        public override void Stop()
        {
            _stopSignaled = true;
        }

        public override string Execute()
        {
            OnStatusChanged(String.Format("Starting execution of {0}", this.GetType()));

            //Add implementation
            DoImport().Wait();


            if (_stopSignaled)
            {
                return "Stop of job was called";
            }

            return "Change to message that describes outcome of execution";
        }



        private async Task DoImport()
        {
            var repo = ServiceLocator.Current.GetInstance<IContentRepository>();
            IClient findClient = Client.CreateFromConfig();


            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://epi15-lms.azurewebsites.net/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // New code:
                HttpResponseMessage response = await client.GetAsync("api/Classes?take=1000");
                if (response.IsSuccessStatusCode)
                {
                    var classEvents = await response.Content.ReadAsAsync<List<ClassEvent>>();
                    var newClassList = new List<ClassEvent>();

                    foreach (var classevent in classEvents.ToList())
                    {
                        ClassEvent newclassevent = new ClassEvent
                        {
                            Course = classevent.Course,
                            CourseId = classevent.CourseId,
                            Id = classevent.Id,
                            Location = classevent.Location,
                            LocationId = classevent.LocationId,
                            MaxNumberOfParticipants = classevent.MaxNumberOfParticipants,
                            Price = classevent.Price,
                            StartDate = classevent.StartDate,
                            Status = classevent.Status
                        };
                        newClassList.Add(newclassevent);
                    }
                    findClient.Index(newClassList);
                    newClassList.Clear();
                }
            }
        }


    }
}