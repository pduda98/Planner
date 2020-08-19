using System;
using PlannerApi.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace PlannerApi.Models
{
    public class RoutineTaskEvent
    {
        [BsonId]
        public string Id {get; set; }
        public DateTime FirstDeadline {get; set; }
        public StatusEnum Status {get; set; }
    }
}