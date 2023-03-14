using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Repositories;

namespace ZooManagement.Data
{
    public static class SampleSpecies
    {
        public const int NumberOfSpecies = 6;

        private static readonly IList<IList<string>> Data = new List<IList<string>>
        {
            new List<string> { "Lion", "Mammal", "27"},
            new List<string> { "Tiger", "Mammal", "18"},
            new List<string> { "Eagle", "Bird", "9"},
            new List<string> { "Penguin", "Bird", "36"},
            new List<string> { "Tarantula", "Spider", "18"},
            new List<string> { "Shark", "Fish", "9"},
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

