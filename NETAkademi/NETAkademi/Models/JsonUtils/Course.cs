using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NETAkademi.Models.JsonUtils
{
    public class Course
    {

        public virtual int Id { get; set; }
        public virtual string CourseCode { get; set; }
        public virtual int TopicId { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual string Name { get; set; }
        public virtual int Duration { get; set; }
        public virtual int DefaultPrice { get; set; } 
    }

    public class Topic
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }

    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ClassEvent
    {
        public virtual int Id { get; set; }
        public virtual int Status { get; set; }
        public virtual int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public virtual int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual int MaxNumberOfParticipants { get; set; }
        public virtual object Price { get; set; }
    }
}