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
        public string SpeciesId => _animal.SpeciesId;
        public string Name => _animal.Name;
        public string Sex => _animal.Sex;
        public string DateOfBirth => _animal.DateOfBirth;
        public string DateAcquired => _animal.DateAcquired;
    }
}