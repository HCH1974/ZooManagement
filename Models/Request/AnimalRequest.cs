namespace ZooManagement.Models.Request
{
    public class AnimalRequest
    {
        public int SpeciesId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string DateOfBirth { get; set; }
        public string DateAcquired { get; set; }
        public int EnclosureId { get; set; }
    }
}