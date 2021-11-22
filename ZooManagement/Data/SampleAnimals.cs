using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Faker;
using ZooManagement.Models.Database;
using ZooManagement.Data;
using Enum = System.Enum;

namespace ZooManagement.Data
{
    public class SampleAnimals
    {

        public const int NumberOfAnimals = 100;

        private static readonly IList<IList<string>> Data = new List<IList<string>>
        {
            new List<string> {"Elephant", "Mammal", "Mammal", "Male"}
        };

        public static void AddAnimalsDataToList()
        {
            for (int animal = 0; animal < NumberOfAnimals; animal++)
            {
                Data.Insert(animal, new List<string>
                {
                    Faker.Name.First(),
                    Faker.Name.Middle(),
                    Faker.Enum.Random<ClassificationType>().ToString(),
                    Faker.Enum.Random<SexType>().ToString()
                });
            }
        }

        public static IEnumerable<Animal> GetAnimals()
        {
            AddAnimalsDataToList();
            return Enumerable.Range(0, NumberOfAnimals).Select(CreateRandomAnimal);
        }
        
        private static Animal CreateRandomAnimal(int index)
        {
            return new Animal
            {
                Name = Data[index][0],
                Species = Data[index][1],
                Classification = Enum.Parse<ClassificationType>(Data[index][2]),
                Sex = Enum.Parse<SexType>(Data[index][3]),
                DateOfBirth = DateGenerator.GetAnimalDateOfBirth(),
                DateAcquired = DateGenerator.GetAnimalDateAcquired()
            };
        }
    }
}