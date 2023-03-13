using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Repositories;

namespace ZooManagement.Data
{
    public static class SampleAnimals
    {
        public const int NumberOfAnimals = 3;

        private static readonly IList<IList<string>> Data = new List<IList<string>>
        {
            new List<string> { "Lion", "Mammal", "King Leo", "M" , "130974" , "010123" , "5"},
            new List<string> { "Tiger", "Mammal", "Doris", "F" , "010190" , "020123" , "7"},
            new List<string> { "Eagle", "Bird", "Eddie", "M" , "010195" , "010122" , "1"},

        };

        public static IEnumerable<Animal> GetAnimals()
        {
            return Enumerable.Range(0, NumberOfAnimals).Select(CreateRandomAnimal);
        }

        private static Animal CreateRandomAnimal(int index)
        {

            return new Animal
            {
                Species = Data[index][0],
                Classification = Data[index][1],
                Name = Data[index][2],
                Sex = Data[index][3],
                DateOfBirth = Data[index][4],
                DateAcquired = Data[index][5],
                NumberInZoo = Data[index][6],

            };
        }
    }
}

