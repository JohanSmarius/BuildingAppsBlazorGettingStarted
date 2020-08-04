using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelter.Shared;

namespace AnimalShelter.Client.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();

        Product GetProduct(int id);

        void DeleteProduct(Product product);

        void AddProduct(Product newProduct);

    }
}
