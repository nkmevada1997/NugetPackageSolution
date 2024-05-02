using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entity
{
    [Table("Countries", Schema = "dbo")]
    public class Country : ModelBase
    {
        public required string Name { get; set; }
    }
}
