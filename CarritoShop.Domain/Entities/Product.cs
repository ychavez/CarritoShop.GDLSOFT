using CarritoShop.Domain.Entities.Base;
using System.ComponentModel.DataAnnotations;

namespace CarritoShop.Domain.Entities
{
    public class Product : EntityBase
    {
        [MaxLength(40)]
        public string Name { get; set; } = null!;
        [MaxLength(100)]
        public string? Descripcion { get; set; }
        public decimal Price { get; set; }
    }
}
