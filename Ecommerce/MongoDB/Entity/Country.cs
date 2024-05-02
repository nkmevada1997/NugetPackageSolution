using Ecommerce.Attributes;
using MongoDB.Bson;

namespace Ecommerce.MongoDB.Entity
{
    [BsonCollection("Countries")]
    public class Country : Document<ObjectId>
    {
        public required string CountryId { get; set; }
        public required string Name { get; set; }
    }
}
