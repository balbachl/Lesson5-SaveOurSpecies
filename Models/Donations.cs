using System;
using System.Collections.Generic;

namespace SaveOurSpecies.Models
{
    public class Donations
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public double donation { get; set; } = 100.00;

        public virtual ICollection<Animal> Animal { get; set; }
    }
}