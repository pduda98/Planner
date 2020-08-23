using MongoDB.Bson.Serialization.Attributes;

namespace PlannerApi.Models
{
    public class Task
    {
        [BsonId]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsImportant { get; set; }
        public Category Category{ get; set; }
    }
}