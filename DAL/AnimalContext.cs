using SaveOurSpecies.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SaveOurSpecies.DAL
{
    public class AnimalContext : DbContext
    {
        public AnimalContext() :base("AnimalContext")
        {

        }
        public DbSet<Animal>Animals { get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Adoption> Adoptions { get; set; }
        public DbSet<Graphic>Graphics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<SaveOurSpecies.Models.Donations> Donations { get; set; }
    }
}