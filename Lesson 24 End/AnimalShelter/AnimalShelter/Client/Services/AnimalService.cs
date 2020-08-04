using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelter.Shared;

namespace AnimalShelter.Client.Services
{
    public class AnimalService : IAnimalService
    {
        private List<Animal> _animals = new List<Animal>();

        public AnimalService()
        {
            SeedAnimals();
        }

        public List<Animal> GetAllAnimals()
        {
            return _animals;
        }

        public Animal GetAnimal(int id)
        {
            return _animals.SingleOrDefault(animal => animal.Id == id);
        }

        public void AdoptAnimal(Animal animalToAdopt)
        {
            _animals.Remove(animalToAdopt);
        }

        public void AddAnimal(Animal newAnimal)
        {
            _animals.Add(newAnimal);
        }

        private void SeedAnimals()
        {
            _animals.AddRange(
                new List<Animal>()
            {
                    new Animal
                    {
                        Id = 1,
                        Name = "Max",
                        AnimalKind = AnimalKind.Dog,
                        EstimatedAge = 1,
                        PictureUrl = "https://cdn.pixabay.com/photo/2017/06/24/09/13/dog-2437110__340.jpg",
                        Gender = Gender.Male
                    },
                    new Animal
                    {
                        Id = 2,
                        Name = "Kitty",
                        AnimalKind = AnimalKind.Cat,
                        DateOfBirth = new DateTime(2018, 01, 30),
                        PictureUrl = "https://cdn.pixabay.com/photo/2014/04/13/20/49/cat-323262__340.jpg",
                        Gender = Gender.Female
                    },
                    new Animal
                    {
                        Id = 3,
                        Name = "Lucy",
                        AnimalKind = AnimalKind.Dog,
                        EstimatedAge = 2,
                        PictureUrl = "https://cdn.pixabay.com/photo/2018/03/18/18/06/australian-shepherd-3237735__340.jpg",
                        Gender = Gender.Female
                    },
                    new Animal
                    {
                        Id = 4,
                        Name = "Charlie",
                        AnimalKind = AnimalKind.Dog,
                        EstimatedAge = 3,
                        PictureUrl = "https://cdn.pixabay.com/photo/2017/10/02/21/56/dog-2810484__340.jpg",
                        Gender = Gender.Male
                    },
                    new Animal
                    {
                        Id = 5,
                        Name = "Simba",
                        AnimalKind = AnimalKind.Cat,
                        EstimatedAge = 1,
                        PictureUrl = "https://cdn.pixabay.com/photo/2017/11/09/21/41/cat-2934720__340.jpg",
                        Gender = Gender.Female
                    },
                    new Animal
                    {
                        Id = 6,
                        Name = "Sammy",
                        AnimalKind = AnimalKind.Cat,
                        EstimatedAge = 6,
                        PictureUrl = "https://cdn.pixabay.com/photo/2017/03/14/14/49/cat-2143332__340.jpg",
                        Gender = Gender.Male
                    }
                });

        }
    }
}
