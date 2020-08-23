using System.Drawing;
using MongoDB.Bson.Serialization.Attributes;

namespace PlannerApi.Models
{
    public class Category
    {
        [BsonId]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Name { get; set; }
        public Color Color { get; set; }
    }
}   