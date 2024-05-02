using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entity
{
    [Table("Cities", Schema = "dbo")]
    public class City : ModelBase
    {
        public required string Name { get; set; }

        public Guid StateId { get; set; }
    }
}
