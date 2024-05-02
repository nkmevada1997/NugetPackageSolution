using Ecommerce.Attributes;
using MongoDB.Bson;

namespace Ecommerce.MongoDB.Entity
{
    [BsonCollection("Customers")]
    public class Customer : Document<ObjectId>
    {
        public required string CustomerId { get; set; } 
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required DateTime DOB { get; set; }
        public required string Gender { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Password { get; set; }
        public required string CountryId { get; set; }
        public required string StateId { get; set; }
        public required string CityId { get; set; }
    }
}
