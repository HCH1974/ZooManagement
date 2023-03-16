using System;

namespace ZooManagement.Models.Database
{
    public class Enclosure
    {
        public int Id { get; set; }
        public string EnclosureName { get; set; }
        public int MaximumNumberOfAnimals { get; set; }
        public int CurrentNumberOfAnimals { get; set; }
    }
}
