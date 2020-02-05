using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaveOurSpecies.Models
{
    public class Graphic
    {
        public int ID { get; set; }
        public int AnimalID { get; set; }
        public string Photo { get; set; }
        public string AltText { get; set; }

        public virtual Animal Animal { get; set; }
    }
}