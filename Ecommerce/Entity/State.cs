using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Entity
{
    [Table("States", Schema = "dbo")]
    public class State : ModelBase
    {
        public required string Name { get; set; }

        public Guid CountryId { get; set; }
    }
}
