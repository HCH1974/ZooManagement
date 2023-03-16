using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Repositories;

namespace ZooManagement.Data
{
    public static class SampleEnclosures
    {
        public const int NumberOfEnclosures = 6;

        private static readonly IList<IList<string>> Data = new List<IList<string>>
        {
            new List<string> { "Lion's Enclosure", "10" , "10"},
            new List<string> { "Bird's Enclosure","50" , "45"},
            new List<string> { "Reptile's Enclosure","40" , "4"},
            new List<string> { "Giraffe's Enclosure","6" , "3"},
            new List<string> { "Hippo's Enclosure", "10" , "3"},
            new List<string> { "Others Enclosure", "1000" , "55"},
        };

        public static IEnumerable<Enclosure> GetEnclosures()
        {
            return Enumerable.Range(0, NumberOfEnclosures).Select(CreateRandomEnclosures);
        }

        private static Enclosure CreateRandomEnclosures(int index)
        {

            return new Enclosure
            {
                EnclosureName = Data[index][0],
                MaximumNumberOfAnimals = int.Parse(Data[index][1]),
                CurrentNumberOfAnimals = int.Parse(Data[index][2]),
            };
        }
    }
}

