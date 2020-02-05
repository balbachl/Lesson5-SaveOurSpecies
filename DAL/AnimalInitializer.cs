using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SaveOurSpecies.Models;

namespace SaveOurSpecies.DAL
{
    public class AnimalInitializer :System.Data.Entity.DropCreateDatabaseIfModelChanges<AnimalContext>
    {
        protected override void Seed(AnimalContext context)
        {
            var animals = new List<Animal>
            {
                new Animal{CommonName="Yangtze Finless Porpoise",ScientificName="Neophocaena asiaeorientalis ssp. asiaeorientalis",Habitat="Rivers and Streams", Status="Critically Endangered"},
                new Animal{CommonName="Sumatran Tiger",ScientificName="Panthera tigris sumatrae",Habitat="Tropical broadleaf evergreen forests, freshwater swamp forests and peat swamps", Status="Critically Endangered"},
                new Animal{CommonName="Sumatran Rhino",ScientificName="Dicerorhinus sumatrensis",Habitat="Dense highland and lowland tropical and sub-tropical forests", Status="Critically Endangered"},
                new Animal{CommonName="Sumatran Orangutan",ScientificName="Pongo abelii",Habitat="Tropical and Subtropical Moist Broadleaf Forests", Status="Critically Endangered"},
                new Animal{CommonName="Sumatran Elephant",ScientificName="Elephas maximus sumatranus",Habitat="Broadleaf moist tropical forests", Status="Critically Endangered"},
                new Animal{CommonName="South China Tiger",ScientificName="Panthera tigris amoyensis",Habitat="Southeast China-Hainan Moist Forests", Status="Critically Endangered"},
                new Animal{CommonName="Orangutan",ScientificName="Pongo abelii, Pongo pygmaeus",Habitat="Lowland forests", Status="Critically Endangered"},
                new Animal{CommonName="Malayan Tiger",ScientificName="Panthera tigris jacksoni",Habitat="Tropical moist broadleaf forests", Status="Critically Endangered"},
                new Animal{CommonName="Hawksbill Turtle",ScientificName="	Eretmochelys imbricata",Habitat="Oceans", Status="Critically Endangered"},
                new Animal{CommonName = "Western Lowland Gorilla", ScientificName = "Gorilla gorilla gorilla", Habitat = "Forested areas of the Congo.", Status="Critically Endangered"}
            };

            animals.ForEach(a=>context.Animals.Add(a));
            context.SaveChanges();

            var patrons = new List<Patron>
            {
                new Patron{FirstName="Frank", LastName="Furter", Address="100 stadium drive", City="Chicago", State="IL", Country="USA"},
                new Patron{FirstName="Daphne", LastName="Blake", Address="100 elmstreet", City="Traverse City", State="MI", Country="USA"},
                new Patron{FirstName="Johnny", LastName="Quest", Address="1 oceana ave", City="Wayzata", State="MN", Country="USA"},
                new Patron{FirstName="Elmer", LastName="Fudd", Address="16 rabbit lane", City="Naples", State="FL", Country="USA"},
                new Patron{FirstName="Christopher", LastName="Robin", Address="100 acre woods", City="San Francisco", State="CA", Country="USA"},
                new Patron{FirstName="Shaggy", LastName="Rogers", Address="10 olivet ave", City="San Jose", State="CA", Country="USA"},
                new Patron{FirstName="Freddie", LastName="Jones", Address="900 royal palm way", City="Traverse City", State="IL", Country="USA"},
                new Patron{FirstName="Betty", LastName="Rubble", Address="1600 dino drive", City="Bedrock", State="MI", Country="USA"},
                new Patron{FirstName="Velma", LastName="Dinkley", Address="16 hatchett ave", City="Traverse City", State="IL", Country="USA"},
                new Patron{FirstName="Wilma", LastName="Flintstone", Address="100 boulder blvd", City="Bedrock", State="MI", Country="USA"}
            };
            patrons.ForEach(d => context.Patrons.Add(d));
            context.SaveChanges();

            var adoptions = new List<Adoption>
            {
                new Adoption{AnimalID=1, PatronID=1,Donate=500.00},
                new Adoption{AnimalID=2, PatronID=2,Donate=100.00},
                new Adoption{AnimalID=3, PatronID=3,Donate=900.00},
                new Adoption{AnimalID=4, PatronID=4,Donate=7500.00},
                new Adoption{AnimalID=5, PatronID=5,Donate=550.00},
                new Adoption{AnimalID=6, PatronID=1,Donate=100.00},
                new Adoption{AnimalID=7, PatronID=2,Donate=50.00},
                new Adoption{AnimalID=8, PatronID=2,Donate=50.00},
                new Adoption{AnimalID=7, PatronID=9,Donate=100.00},
                new Adoption{AnimalID=2, PatronID=2, Donate=60.00}
            };
            adoptions.ForEach(ad => context.Adoptions.Add(ad));
            context.SaveChanges();

            var graphics = new List<Graphic>
            {
                new Graphic{AnimalID=1, Photo="~/Content/Images/porpoise.jpg",AltText="Yangtze Finless Porpoise"},
                new Graphic{AnimalID=2, Photo="~/Content/Images/sumatran-tiger.jpg",AltText="Sumatran Tiger"},
                new Graphic{AnimalID=3, Photo="~/Content/Images/rhino.jpg",AltText="Sumatran Rhino"},
                new Graphic{AnimalID=4, Photo="~/Content/Images/orangutan.jpg",AltText="Sumatran Orangutan"},
                new Graphic{AnimalID=5, Photo="~/Content/Images/elephant.jpg",AltText="Sumatran Elephant"},
                new Graphic{AnimalID=6, Photo="~/Content/Images/south-china-tiger.jpg",AltText="South China Tiger"},
                new Graphic{AnimalID=7, Photo="~/Content/Images/bornean.jpg",AltText="Orangutan"},
                new Graphic{AnimalID=8, Photo="~/Content/Images/malaysian-tiger.jpg",AltText="Malayan Tiger"},
                new Graphic{AnimalID=9, Photo="~/Content/Images/turtle.jpg",AltText="Hawksbill Turtle"},
                new Graphic{AnimalID=10, Photo="~/Content/Images/gorilla.jpg",AltText="Western Lowland Gorilla"}
            };
            graphics.ForEach(g => context.Graphics.Add(g));
            context.SaveChanges();
        }
    }
}