using Ecommerce.Attributes;
using MongoDB.Bson;

namespace Ecommerce.MongoDB.Entity
{
    [BsonCollection("Users")]
    public class User : Document<ObjectId>
    {
        public required string UserId { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string UserType { get; set; }
        public bool CanLogin { get; set; } = true;
        public string? CustomerId { get; set; }
        public string? SupplierId { get; set; }
    }
}
