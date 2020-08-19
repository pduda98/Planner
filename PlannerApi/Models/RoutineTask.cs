using System;
using PlannerApi.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace PlannerApi.Models
{
    public class RoutineTask 
    {
        [BsonId]
        public string Id {get; set; }
        public string Name {get; set; }
        public string Description {get; set; }
        public IntervalTypeEnum IntervalType {get; set; }
        public TimeSpan? Interval {get; set; }
        public bool IsImportant {get; set; }
        public DateTime FirstDeadline {get; set; }
    }
}