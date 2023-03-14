using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Repositories;

namespace ZooManagement.Data
{
    public static class SampleAnimals
    {
        public const int NumberOfAnimals = 117;

        private static readonly IList<IList<string>> Data = new List<IList<string>>
        {
            new List<string> { "1", "Leo", "M", "130974" , "010123"},
            new List<string> { "1", "Maureen", "F", "010120" , "010223"},
            new List<string> { "1", "Dennis", "M", "130922" , "020123"},
            new List<string> { "2", "Tigger", "M", "010199" , "020123"},
            new List<string> { "2", "Tilly", "F", "010199" , "020123"},
            new List<string> { "3", "Eddy", "M", "010199" , "020123"},
            new List<string> { "4", "Polly", "F", "010101" , "010101"},
            new List<string> { "4", "Penny", "F", "010101" , "010101"},
            new List<string> { "4", "Pansy", "F", "010101" , "010101"},
            new List<string> { "4", "Poppy", "F", "010101" , "010101"},
            new List<string> { "5", "Terror", "M", "010110" , "010111"},
            new List<string> { "5", "Fear", "M", "010110" , "010111"},
            new List<string> { "6", "Jaws", "M", "010170" , "010111"},
            new List<string> { "1", "Bob", "M", "130974" , "010123"},
            new List<string> { "1", "Doreen", "F", "010120" , "010223"},
            new List<string> { "1", "Roger", "M", "130922" , "020123"},
            new List<string> { "2", "Dopey", "M", "010199" , "020123"},
            new List<string> { "2", "Lyra", "F", "010199" , "020123"},
            new List<string> { "3", "Jim", "M", "010199" , "020123"},
            new List<string> { "4", "Emily", "F", "010101" , "010101"},
            new List<string> { "4", "Sarah", "F", "010101" , "010101"},
            new List<string> { "4", "Wanda", "F", "010101" , "010101"},
            new List<string> { "4", "Tina", "F", "010101" , "010101"},
            new List<string> { "5", "Eight", "M", "010110" , "010111"},
            new List<string> { "5", "Seven", "M", "010110" , "010111"},
            new List<string> { "6", "Aaargh", "M", "010170" , "010111"},
            new List<string> { "1", "Darren", "M", "130974" , "010123"},
            new List<string> { "1", "Margeret", "F", "010120" , "010223"},
            new List<string> { "1", "Dave", "M", "130922" , "020123"},
            new List<string> { "2", "Graham", "M", "010199" , "020123"},
            new List<string> { "2", "Marjorie", "F", "010199" , "020123"},
            new List<string> { "3", "Edwin", "M", "010199" , "020123"},
            new List<string> { "4", "Florence", "F", "010101" , "010101"},
            new List<string> { "4", "Rebecca", "F", "010101" , "010101"},
            new List<string> { "4", "Megan", "F", "010101" , "010101"},
            new List<string> { "4", "Hannah", "F", "010101" , "010101"},
            new List<string> { "5", "Hello", "M", "010110" , "010111"},
            new List<string> { "5", "Goodbye", "M", "010110" , "010111"},
            new List<string> { "6", "Daisy", "M", "010170" , "010111"},
            new List<string> { "1", "ALeo", "M", "130974" , "010123"},
            new List<string> { "1", "AMaureen", "F", "010120" , "010223"},
            new List<string> { "1", "ADennis", "M", "130922" , "020123"},
            new List<string> { "2", "ATigger", "M", "010199" , "020123"},
            new List<string> { "2", "ATilly", "F", "010199" , "020123"},
            new List<string> { "3", "AEddy", "M", "010199" , "020123"},
            new List<string> { "4", "APolly", "F", "010101" , "010101"},
            new List<string> { "4", "APenny", "F", "010101" , "010101"},
            new List<string> { "4", "APansy", "F", "010101" , "010101"},
            new List<string> { "4", "APoppy", "F", "010101" , "010101"},
            new List<string> { "5", "ATerror", "M", "010110" , "010111"},
            new List<string> { "5", "AFear", "M", "010110" , "010111"},
            new List<string> { "6", "AJaws", "M", "010170" , "010111"},
            new List<string> { "1", "ABob", "M", "130974" , "010123"},
            new List<string> { "1", "ADoreen", "F", "010120" , "010223"},
            new List<string> { "1", "ARoger", "M", "130922" , "020123"},
            new List<string> { "2", "ADopey", "M", "010199" , "020123"},
            new List<string> { "2", "ALyra", "F", "010199" , "020123"},
            new List<string> { "3", "AJim", "M", "010199" , "020123"},
            new List<string> { "4", "AEmily", "F", "010101" , "010101"},
            new List<string> { "4", "ASarah", "F", "010101" , "010101"},
            new List<string> { "4", "AWanda", "F", "010101" , "010101"},
            new List<string> { "4", "ATina", "F", "010101" , "010101"},
            new List<string> { "5", "AEight", "M", "010110" , "010111"},
            new List<string> { "5", "ASeven", "M", "010110" , "010111"},
            new List<string> { "6", "AAaargh", "M", "010170" , "010111"},
            new List<string> { "1", "ADarren", "M", "130974" , "010123"},
            new List<string> { "1", "AMargeret", "F", "010120" , "010223"},
            new List<string> { "1", "ADave", "M", "130922" , "020123"},
            new List<string> { "2", "AGraham", "M", "010199" , "020123"},
            new List<string> { "2", "AMarjorie", "F", "010199" , "020123"},
            new List<string> { "3", "AEdwin", "M", "010199" , "020123"},
            new List<string> { "4", "AFlorence", "F", "010101" , "010101"},
            new List<string> { "4", "ARebecca", "F", "010101" , "010101"},
            new List<string> { "4", "AMegan", "F", "010101" , "010101"},
            new List<string> { "4", "AHannah", "F", "010101" , "010101"},
            new List<string> { "5", "AHello", "M", "010110" , "010111"},
            new List<string> { "5", "AGoodbye", "M", "010110" , "010111"},
            new List<string> { "6", "ADaisy", "M", "010170" , "010111"},
            new List<string> { "1", "BALeo", "M", "130974" , "010123"},
            new List<string> { "1", "BABMaureen", "F", "010120" , "010223"},
            new List<string> { "1", "BADennis", "M", "130922" , "020123"},
            new List<string> { "2", "BATigger", "M", "010199" , "020123"},
            new List<string> { "2", "BATilly", "F", "010199" , "020123"},
            new List<string> { "3", "BAEddy", "M", "010199" , "020123"},
            new List<string> { "4", "BAPolly", "F", "010101" , "010101"},
            new List<string> { "4", "BAPenny", "F", "010101" , "010101"},
            new List<string> { "4", "BAPansy", "F", "010101" , "010101"},
            new List<string> { "4", "BAPoppy", "F", "010101" , "010101"},
            new List<string> { "5", "BATerror", "M", "010110" , "010111"},
            new List<string> { "5", "BBAFear", "M", "010110" , "010111"},
            new List<string> { "6", "BAJaws", "M", "010170" , "010111"},
            new List<string> { "1", "BABob", "M", "130974" , "010123"},
            new List<string> { "1", "BBADoreen", "F", "010120" , "010223"},
            new List<string> { "1", "BARoger", "M", "130922" , "020123"},
            new List<string> { "2", "BADopey", "M", "010199" , "020123"},
            new List<string> { "2", "BALyra", "F", "010199" , "020123"},
            new List<string> { "3", "BBAJim", "M", "010199" , "020123"},
            new List<string> { "4", "BAEmily", "F", "010101" , "010101"},
            new List<string> { "4", "BASarah", "F", "010101" , "010101"},
            new List<string> { "4", "BAWanda", "F", "010101" , "010101"},
            new List<string> { "4", "BBATina", "F", "010101" , "010101"},
            new List<string> { "5", "BAEight", "M", "010110" , "010111"},
            new List<string> { "5", "BASeven", "M", "010110" , "010111"},
            new List<string> { "6", "BAAaargh", "M", "010170" , "010111"},
            new List<string> { "1", "BADarren", "M", "130974" , "010123"},
            new List<string> { "1", "BAMargeret", "F", "010120" , "010223"},
            new List<string> { "1", "BADave", "M", "130922" , "020123"},
            new List<string> { "2", "BAGraham", "M", "010199" , "020123"},
            new List<string> { "2", "BAMarjorie", "F", "010199" , "020123"},
            new List<string> { "3", "BAEdwin", "M", "010199" , "020123"},
            new List<string> { "4", "BAFlorence", "F", "010101" , "010101"},
            new List<string> { "4", "BARebecca", "F", "010101" , "010101"},
            new List<string> { "4", "BBAMegan", "F", "010101" , "010101"},
            new List<string> { "4", "BAHannah", "F", "010101" , "010101"},
            new List<string> { "5", "BAHello", "M", "010110" , "010111"},
            new List<string> { "5", "BAGoodbye", "M", "010110" , "010111"},
            new List<string> { "6", "BADaisy", "M", "010170" , "010111"},
         };

        public static IEnumerable<Animal> GetAnimals()
        {
            return Enumerable.Range(0, NumberOfAnimals).Select(CreateRandomAnimal);
        }

        private static Animal CreateRandomAnimal(int index)
        {

            return new Animal
            {
                SpeciesId = Data[index][0],
                Name = Data[index][1],
                Sex = Data[index][2],
                DateOfBirth = Data[index][3],
                DateAcquired = Data[index][4],
            };
        }
    }
}

