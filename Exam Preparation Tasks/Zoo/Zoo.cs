using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        private List<Animal> animals;
        public Zoo(string name, int capacity)
        {
            Animals = new List<Animal>();
            //animals = Animals;

            Name = name;
            Capacity = capacity;
        }
        public string  Name { get; set; }
        public int Capacity { get; set; }
        public List<Animal> Animals { get; set; }
        public int RemovedAnimalsCount { get; set; }
        public string AddAnimal(Animal animal)
        {
            if (Capacity > 0)
            {
                if (animal.Species == null || animal.Species == " ")
                {
                    return "Invalid animal species.";
                }
                else if (animal.Diet != "herbivore" && animal.Diet != "carnivore")
                {
                    return "Invalid animal diet.";
                }
                else
                {
                    Animals.Add(animal);
                    Capacity--;
                    return $"Successfully added {animal.Species} to the zoo.";
                }
            }

            else
            {
                return "The zoo is full.";
            }
        }

        public int RemoveAnimals(string species)
        {
            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].Species == species)
                {
                    Animals.Remove(Animals[i]);
                    RemovedAnimalsCount++;
                    Capacity++;
                    i--;
                }
            }
            return RemovedAnimalsCount;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animalsSortedByDiet = Animals.Where(x => x.Diet == diet).ToList();
            return animalsSortedByDiet;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            var animal = Animals.First(x => x.Weight == weight);
            return animal;
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = Animals.Where(x => x.Length >= minimumLength).Where(x => x.Length <= maximumLength).Count();
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
