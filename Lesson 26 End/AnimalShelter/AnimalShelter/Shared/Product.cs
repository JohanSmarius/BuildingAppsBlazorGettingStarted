namespace AnimalShelter.Shared
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int VatPercentage { get; set; }

        public decimal NetPrice => Price * (1 + (VatPercentage / (decimal)100));

        public string ProductImageUrl { get; set; }
    }
}
