using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelter.Shared;

namespace AnimalShelter.Client.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();

        Task<Product> GetProduct(int id);

        Task DeleteProduct(Product product);

        Task AddProduct(Product newProduct);

        Task UpdateProduct(Product product);
    }
}
