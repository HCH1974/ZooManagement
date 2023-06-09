﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooManagement.Models.Database
{
    public class Animal
    {
        public int Id { get; set; }
        [ForeignKey("Species")]
        public int SpeciesId { get; set; }
        public virtual Species Species { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateAcquired { get; set; }
        [ForeignKey("Enclosure")]
        public int EnclosureId { get; set; }
        public virtual Enclosure Enclosure { get; set; }
    }
}
