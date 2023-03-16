using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Repositories;

namespace ZooManagement.Data
{
    public static class SampleSpeciesToEnclosure
    {
        public const int NumberOfSpeciesToEnclosure = 8;

        private static readonly IList<IList<string>> Data = new List<IList<string>>
        {
            new List<string> { "1" , "1"},
            new List<string> { "2" , "2"},
            new List<string> { "3" , "2"},
            new List<string> { "4" , "3"},
            new List<string> { "5" , "5"},
            new List<string> { "6" , "6"},
            new List<string> { "7" , "6"},
            new List<string> { "8" , "4"},
        };

        public static IEnumerable<SpeciesToEnclosure> GetSpeciesToEnclosures()
        {
            return Enumerable.Range(0, NumberOfSpeciesToEnclosure).Select(CreateRandomSpeciesToEnclosure);
        }

        private static SpeciesToEnclosure CreateRandomSpeciesToEnclosure(int index)
        {

            return new SpeciesToEnclosure
            {
                SpeciesId = int.Parse(Data[index][0]),
                EnclosureId = int.Parse(Data[index][1]),
            };
        }
    }
}

