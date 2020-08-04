using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelter.Shared;

namespace AnimalShelter.Client.Services
{
    public class ProductService : IProductService
    {
        private List<Product> Products { get; set; } = new List<Product>();

        public ProductService()
        {
            Seed();
        }

        public List<Product> GetAllProducts()
        {
            return Products;
        }

        public Product GetProduct(int id)
        {
            return Products.SingleOrDefault(product => product.Id == id);
        }

        public void DeleteProduct(Product product)
        {
            Products.Remove(product);
        }

        public void AddProduct(Product newProduct)
        {
            Products.Add(newProduct);
        }

        protected void Seed()
        {
            Products.AddRange(new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Dogfood",
                    Price = 10.99m,
                    VatPercentage = 21,
                    ProductImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4f/Hundefutter.jpg"
                },
                new Product
                {
                    Id = 2,
                    Name = "Catfood",
                    Price = 8.99m,
                    VatPercentage = 21,
                    ProductImageUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/1/16/Whiskas_cat%27s_petfood_with_chicken_dry.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Cat litter 50 liter",
                    Price = 15.12m,
                    VatPercentage = 21,
                    ProductImageUrl = "https://www.publicdomainpictures.net/pictures/30000/velka/cat-litter.jpg"
                }
            });
        }
    }
}
