using ZooManagement.Models.Database;

namespace ZooManagement.Models.Response
{
    public class AnimalResponse
    {
        private readonly Animal _animal;

        public AnimalResponse(Animal animal)
        {
            _animal = animal;
        }

        public int Id => _animal.Id;
        public int SpeciesId => _animal.SpeciesId;
        public string Name => _animal.Name;
        public string Sex => _animal.Sex;
        public DateTime DateOfBirth => _animal.DateOfBirth;
        public DateTime DateAcquired => _animal.DateAcquired;
        public int EnclosureId => _animal.EnclosureId;
    }
}