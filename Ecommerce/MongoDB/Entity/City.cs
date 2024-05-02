using Ecommerce.Attributes;
using MongoDB.Bson;

namespace Ecommerce.MongoDB.Entity
{
    [BsonCollection("Cities")]
    public class City : Document<ObjectId>
    {
        public required string CityId { get; set; }
        public required string Name { get; set; }
        public required string StateId { get; set; }
    }
}
