using System;
using PlannerApi.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace PlannerApi.Models
{
    public class SingleTask
    {
        [BsonId]
        public string Id {get; set; }
        public string SubtaskOf {get; set; }
        public string Name {get; set; }
        public string Description {get; set; }
        public bool IsImportant {get; set; }
        public DateTime Deadline {get; set; }
        
        public StatusEnum Status {get; set; }
    }
}