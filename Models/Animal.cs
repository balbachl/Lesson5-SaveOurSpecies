using System;
using System.Collections.Generic;
namespace SaveOurSpecies.Models
{
    public class Animal
    {
        public int ID { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public string Habitat { get; set; }
        //critical, endangered, near threatened, vulnerable, least threatened
        public string Status { get; set; }

        public virtual ICollection<Adoption> Adoptions { get; set; }
        public virtual ICollection<Graphic> Photos { get; set; }
    }
}