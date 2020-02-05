using System;
using System.Collections.Generic;

namespace SaveOurSpecies.Models
{
    public class Adoption
    {
        public int ID { get; set; }
        public int AnimalID { get; set; }
        public int PatronID { get; set; }
        public double Donate { get; set; } = 100.00;

        public virtual Animal Animal{ get; set; }
        public virtual Patron Patron { get; set; }
    }
}