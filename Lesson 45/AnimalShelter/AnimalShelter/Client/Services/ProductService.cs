using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using AnimalShelter.Shared;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace AnimalShelter.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        private List<Product> Products { get; set; } = new List<Product>();

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<Product[]>("api/Product");
                return response.ToList();
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }

            throw new InvalidOperationException("This code should not be reached");
        }

        public async Task<Product> GetProduct(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<Product>($"api/product/{id}");
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }

            throw new InvalidOperationException("This code should not be reached");
        }

        public async Task DeleteProduct(Product product)
        {
            try
            {
                await _httpClient.DeleteAsync($"api/product/{product.Id}");
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
        }

        public async Task AddProduct(Product newProduct)
        {
            try
            {
                await _httpClient.PostAsJsonAsync<Product>("api/Product", newProduct);
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
        }

        public async Task UpdateProduct(Product product)
        {
            try
            {
                await _httpClient.PutAsJsonAsync<Product>($"api/Product/{product.Id}", product);
            }
            catch (AccessTokenNotAvailableException exception)
            {
                exception.Redirect();
            }
        }
    }
}
