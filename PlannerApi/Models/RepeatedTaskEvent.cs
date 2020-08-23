using System;
using PlannerApi.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace PlannerApi.Models
{
    public class RepeatedTaskEvent
    {
        [BsonId]
        public string Id { get; set; }
        public string UserId {get; set; }
        public string TaskId { get; set; }
        public string Name {get; set; }
        public DateTime FirstDeadline { get; set; }
        public StatusEnum Status { get; set; }
    }
}