using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Shared
{
    public class Product
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Range(0, 50)]
        public int VatPercentage { get; set; }

        public decimal NetPrice => Price * (1 + (VatPercentage / (decimal)100));

        [Required]
        [Url]
        public string ProductImageUrl { get; set; }
    }
}
