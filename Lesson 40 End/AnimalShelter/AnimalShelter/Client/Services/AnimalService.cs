using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AnimalShelter.Shared;
using System.Net.Http.Json;

namespace AnimalShelter.Client.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly HttpClient _httpClient;
        private List<Animal> _animals = new List<Animal>();

        public AnimalService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Animal>> GetAllAnimals()
        {

            var result = await _httpClient.GetFromJsonAsync<Animal[]>("api/animals");

            return result.ToList();
        }

        public async Task<Animal> GetAnimal(int id)
        {
            return await _httpClient.GetFromJsonAsync<Animal>($"api/animals/{id}");
        }

        public async Task AdoptAnimal(Animal animalToAdopt)
        {
            await _httpClient.DeleteAsync($"api/animals/{animalToAdopt.Id}");
        }

        public async Task AddAnimal(Animal newAnimal)
        {
            await _httpClient.PostAsJsonAsync<Animal>("api/Animals", newAnimal);
        }

        public async Task Update(Animal animal)
        {
            await _httpClient.PutAsJsonAsync<Animal>($"api/Animals/{animal.Id}", animal);
        }



    }
}
