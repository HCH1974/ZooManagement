using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Repositories;

namespace ZooManagement.Data
{
    public static class SampleAnimals
    {
        public const int NumberOfAnimals = 120;

        private static readonly IList<IList<string>> Data = new List<IList<string>>
        {
            new List<string> { "1", "Leo", "M", "2020-05-19 03:56:30" , "010123", "1"},
            new List<string> { "1", "Maureen", "F", "010120" , "010223", "1"},
            new List<string> { "1", "Dennis", "M", "130922" , "020123", "1"},
            new List<string> { "1", "Tigger", "M", "010199" , "020123", "1"},
            new List<string> { "1", "Tilly", "F", "010199" , "020123", "1"},
            new List<string> { "1", "Eddy", "M", "010199" , "020123", "1"},
            new List<string> { "1", "Polly", "F", "010101" , "010101", "1"},
            new List<string> { "1", "Penny", "F", "010101" , "010101", "1"},
            new List<string> { "1", "Pansy", "F", "010101" , "010101", "1"},
            new List<string> { "1", "Poppy", "F", "010101" , "010101", "1"},
            new List<string> { "2", "Terror", "M", "010110" , "010111", "2"},
            new List<string> { "2", "Fear", "M", "010110" , "010111", "2"},
            new List<string> { "2", "Jaws", "M", "010170" , "010111", "2"},
            new List<string> { "2", "Bob", "M", "130974" , "010123", "2"},
            new List<string> { "2", "Doreen", "F", "010120" , "010223", "2"},
            new List<string> { "2", "Roger", "M", "130922" , "020123", "2"},
            new List<string> { "2", "Dopey", "M", "010199" , "020123", "2"},
            new List<string> { "2", "Lyra", "F", "010199" , "020123", "2"},
            new List<string> { "2", "Jim", "M", "010199" , "020123", "2"},
            new List<string> { "2", "Emily", "F", "010101" , "010101", "2"},
            new List<string> { "2", "Sarah", "F", "010101" , "010101", "2"},
            new List<string> { "2", "Wanda", "F", "010101" , "010101", "2"},
            new List<string> { "2", "Tina", "F", "010101" , "010101", "2"},
            new List<string> { "2", "Eight", "M", "010110" , "010111", "2"},
            new List<string> { "2", "Seven", "M", "010110" , "010111", "2"},
            new List<string> { "3", "Aaargh", "M", "010170" , "010111", "2"},
            new List<string> { "3", "Darren", "M", "130974" , "010123", "2"},
            new List<string> { "3", "Margeret", "F", "010120" , "010223", "2"},
            new List<string> { "3", "Dave", "M", "130922" , "020123", "2"},
            new List<string> { "3", "Graham", "M", "010199" , "020123", "2"},
            new List<string> { "3", "Marjorie", "F", "010199" , "020123", "2"},
            new List<string> { "3", "Edwin", "M", "010199" , "020123", "2"},
            new List<string> { "3", "Florence", "F", "010101" , "010101", "2"},
            new List<string> { "3", "Rebecca", "F", "010101" , "010101", "2"},
            new List<string> { "3", "Megan", "F", "010101" , "010101", "2"},
            new List<string> { "3", "Hannah", "F", "010101" , "010101", "2"},
            new List<string> { "3", "Hello", "M", "010110" , "010111", "2"},
            new List<string> { "3", "Goodbye", "M", "010110" , "010111", "2"},
            new List<string> { "3", "Daisy", "M", "010170" , "010111", "2"},
            new List<string> { "3", "ALeo", "M", "130974" , "010123", "2"},
            new List<string> { "3", "AMaureen", "F", "010120" , "010223", "2"},
            new List<string> { "3", "ADennis", "M", "130922" , "020123", "2"},
            new List<string> { "3", "ATigger", "M", "010199" , "020123", "2"},
            new List<string> { "3", "ATilly", "F", "010199" , "020123", "2"},
            new List<string> { "3", "AEddy", "M", "010199" , "020123", "2"},
            new List<string> { "3", "APolly", "F", "010101" , "010101", "2"},
            new List<string> { "3", "APenny", "F", "010101" , "010101", "2"},
            new List<string> { "3", "APansy", "F", "010101" , "010101", "2"},
            new List<string> { "3", "APoppy", "F", "010101" , "010101", "2"},
            new List<string> { "3", "ATerror", "M", "010110" , "010111", "2"},
            new List<string> { "3", "AFear", "M", "010110" , "010111", "2"},
            new List<string> { "3", "AJaws", "M", "010170" , "010111", "2"},
            new List<string> { "3", "ABob", "M", "130974" , "010123", "2"},
            new List<string> { "3", "ADoreen", "F", "010120" , "010223", "2"},
            new List<string> { "3", "ARoger", "M", "130922" , "020123", "2"},
            new List<string> { "4", "ADopey", "M", "010199" , "020123", "3"},
            new List<string> { "4", "ALyra", "F", "010199" , "020123", "3"},
            new List<string> { "4", "AJim", "M", "010199" , "020123", "3"},
            new List<string> { "4", "AEmily", "F", "010101" , "010101", "3"},
            new List<string> { "5", "ASarah", "F", "010101" , "010101", "5"},
            new List<string> { "5", "AWanda", "F", "010101" , "010101", "5"},
            new List<string> { "5", "ATina", "F", "010101" , "010101", "5"},
            new List<string> { "6", "AEight", "M", "010110" , "010111", "6"},
            new List<string> { "6", "ASeven", "M", "010110" , "010111", "6"},
            new List<string> { "6", "AAaargh", "M", "010170" , "010111", "6"},
            new List<string> { "6", "ADarren", "M", "130974" , "010123", "6"},
            new List<string> { "6", "AMargeret", "F", "010120" , "010223", "6"},
            new List<string> { "6", "ADave", "M", "130922" , "020123", "6"},
            new List<string> { "6", "AGraham", "M", "010199" , "020123", "6"},
            new List<string> { "6", "AMarjorie", "F", "010199" , "020123", "6"},
            new List<string> { "6", "AEdwin", "M", "010199" , "020123", "6"},
            new List<string> { "6", "AFlorence", "F", "010101" , "010101", "6"},
            new List<string> { "6", "ARebecca", "F", "010101" , "010101", "6"},
            new List<string> { "6", "AMegan", "F", "010101" , "010101", "6"},
            new List<string> { "6", "AHannah", "F", "010101" , "010101", "6"},
            new List<string> { "6", "AHello", "M", "010110" , "010111", "6"},
            new List<string> { "6", "AGoodbye", "M", "010110" , "010111", "6"},
            new List<string> { "6", "ADaisy", "M", "010170" , "010111", "6"},
            new List<string> { "6", "BALeo", "M", "130974" , "010123", "6"},
            new List<string> { "6", "BABMaureen", "F", "010120" , "010223", "6"},
            new List<string> { "6", "BADennis", "M", "130922" , "020123", "6"},
            new List<string> { "6", "BATigger", "M", "010199" , "020123", "6"},
            new List<string> { "6", "BATilly", "F", "010199" , "020123", "6"},
            new List<string> { "6", "BAEddy", "M", "010199" , "020123", "6"},
            new List<string> { "6", "BAPolly", "F", "010101" , "010101", "6"},
            new List<string> { "6", "BAPenny", "F", "010101" , "010101", "6"},
            new List<string> { "6", "BAPansy", "F", "010101" , "010101", "6"},
            new List<string> { "6", "BAPoppy", "F", "010101" , "010101", "6"},
            new List<string> { "6", "BATerror", "M", "010110" , "010111", "6"},
            new List<string> { "6", "BBAFear", "M", "010110" , "010111", "6"},
            new List<string> { "6", "BAJaws", "M", "010170" , "010111", "6"},
            new List<string> { "6", "BABob", "M", "130974" , "010123", "6"},
            new List<string> { "7", "BBADoreen", "F", "010120" , "010223", "6"},
            new List<string> { "7", "BARoger", "M", "130922" , "020123", "6"},
            new List<string> { "7", "BADopey", "M", "010199" , "020123", "6"},
            new List<string> { "7", "BALyra", "F", "010199" , "020123", "6"},
            new List<string> { "7", "BBAJim", "M", "010199" , "020123", "6"},
            new List<string> { "7", "BAEmily", "F", "010101" , "010101", "6"},
            new List<string> { "7", "BASarah", "F", "010101" , "010101", "6"},
            new List<string> { "7", "BAWanda", "F", "010101" , "010101", "6"},
            new List<string> { "7", "BBATina", "F", "010101" , "010101", "6"},
            new List<string> { "7", "BAEight", "M", "010110" , "010111", "6"},
            new List<string> { "7", "BASeven", "M", "010110" , "010111", "6"},
            new List<string> { "7", "BAAaargh", "M", "010170" , "010111", "6"},
            new List<string> { "7", "BADarren", "M", "130974" , "010123", "6"},
            new List<string> { "7", "BAMargeret", "F", "010120" , "010223", "6"},
            new List<string> { "7", "BADave", "M", "130922" , "020123", "6"},
            new List<string> { "7", "BAGraham", "M", "010199" , "020123", "6"},
            new List<string> { "7", "BAMarjorie", "F", "010199" , "020123", "6"},
            new List<string> { "7", "BAEdwin", "M", "010199" , "020123", "6"},
            new List<string> { "7", "BAFlorence", "F", "010101" , "010101", "6"},
            new List<string> { "7", "BARebecca", "F", "010101" , "010101", "6"},
            new List<string> { "7", "BBAMegan", "F", "010101" , "010101", "6"},
            new List<string> { "7", "BAHannah", "F", "010101" , "010101", "6"},
            new List<string> { "7", "BAHello", "M", "010110" , "010111", "6"},
            new List<string> { "7", "BAGoodbye", "M", "010110" , "010111", "6"},
            new List<string> { "7", "BADaisy", "M", "010170" , "010111", "6"},
            new List<string> { "8", "Lanky", "M", "010170" , "010111", "4"},
            new List<string> { "8", "Shorty", "M", "010170" , "010111", "4"},
            new List<string> { "8", "Average", "F", "010170" , "010111", "4"},
         };

        public static IEnumerable<Animal> GetAnimals()
        {
            return Enumerable.Range(0, NumberOfAnimals).Select(CreateRandomAnimal);
        }

        private static Animal CreateRandomAnimal(int index)
        {
            Random gen = new Random();
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            DateTime newBirthDate = start.AddDays(gen.Next(range));
            DateTime newDateAcquired = newBirthDate.AddDays(gen.Next(10000));
            if (newDateAcquired > DateTime.Today)
            {
                newDateAcquired = DateTime.Today;
            }

            return new Animal
            {
                SpeciesId = int.Parse(Data[index][0]),
                Name = Data[index][1],
                Sex = Data[index][2],
                DateOfBirth = newBirthDate,
                DateAcquired = newDateAcquired,
                EnclosureId = int.Parse(Data[index][5]),
            };
        }
    }
}

