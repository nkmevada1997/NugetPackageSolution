using Ecommerce.Attributes;
using MongoDB.Bson;

namespace Ecommerce.MongoDB.Entity
{
    [BsonCollection("Suppliers")]
    public class Supplier : Document<ObjectId>
    {
        public required string SupplierId {  get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string CountryId { get; set; }
        public required string StateId { get; set; }
        public required string CityId { get; set; }
    }
}
