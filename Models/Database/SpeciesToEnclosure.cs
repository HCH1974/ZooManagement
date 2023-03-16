using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooManagement.Models.Database
{
    public class SpeciesToEnclosure
    {
        public int Id { get; set; }
        [ForeignKey("Species")]
        public int SpeciesId { get; set; }
        public virtual Species Species { get; set; }
        [ForeignKey("Enclosure")]
        public int EnclosureId { get; set; }
        public virtual Enclosure Enclosure { get; set; }
    }
}
