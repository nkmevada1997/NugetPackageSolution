using Ecommerce.Attributes;
using MongoDB.Bson;

namespace Ecommerce.MongoDB.Entity
{
    [BsonCollection("States")]
    public class State : Document<ObjectId>
    {
        public required string StateId { get; set; }
        public required string Name { get; set; }
        public required string CountryId { get; set; }
    }
}
