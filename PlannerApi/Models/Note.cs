using MongoDB.Bson.Serialization.Attributes;

using System;

namespace PlannerApi.Models
{
    public class Note
    {
        [BsonId]
        public string Id {get; set; }
        public string Title {get; set; }
        public string Content {get; set; }
        public DateTime LastModification {get; set; }
    }
}
        