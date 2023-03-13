using System;

namespace ZooManagement.Models.Database
{
    public class Animal
    {
        public int Id { get; set; }
        public string Species { get; set; }
        public string Classification { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string DateOfBirth { get; set; }
        public string DateAcquired { get; set; }
        public string NumberInZoo { get; set; }

    }
}
