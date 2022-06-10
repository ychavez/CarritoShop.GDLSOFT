using System.ComponentModel.DataAnnotations;

namespace CarritoShop.Domain.Entities.Base
{
    public class EntityBase : IAuditable
    {
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
