using System;
using MongoDB.Bson.Serialization.Attributes;

namespace PlannerApi.Models
{
    public class CalendarEvent
    {
        [BsonId]
        public string Id {get; set; }
        public string Name {get; set; }
        public string Description {get; set; }
        public DateTime Date {get; set; }
    }
}