using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Repositories;

namespace ZooManagement.Data
{
    public static class SampleSpecies
    {
        public const int NumberOfSpecies = 8;

        private static readonly IList<IList<string>> Data = new List<IList<string>>
        {
            new List<string> { "Lion", "Mammal", "10"},
            new List<string> { "Eagle", "Bird", "15"},
            new List<string> { "Penguin", "Bird", "30"},
            new List<string> { "Crocodile", "Reptile", "4"},
            new List<string> { "Hippo", "Mammal", "3"},
            new List<string> { "Tarantula", "Spider", "30"},
            new List<string> { "Shark", "Fish", "25"},
            new List<string> { "Giraffe", "Mammal", "8"},
        };

        public static IEnumerable<Species> GetSpecies()
        {
            return Enumerable.Range(0, NumberOfSpecies).Select(CreateRandomSpecies);
        }

        private static Species CreateRandomSpecies(int index)
        {

            return new Species
            {
                SpeciesName = Data[index][0],
                Classification = Data[index][1],
                NumberInZoo = Data[index][2],
            };
        }
    }
}

