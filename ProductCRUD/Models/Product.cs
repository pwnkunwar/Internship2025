using System.ComponentModel.DataAnnotations;

namespace ProductCRUD.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Range(1,1000)]
        public decimal Price { get; set; }

    }
}
