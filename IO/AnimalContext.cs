using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using REPO;

namespace IO
{
    public class AnimalContext : DbContext
    {
        public AnimalContext() : base("EntityAnimalDB")
        {
            Database.SetInitializer(new AnimalContextSeedInitializer());
        }

        public DbSet<Gender> Gender { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Species> Species { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EntityConfigurationGender());
            modelBuilder.Configurations.Add(new EntityConfigurationSpecies());
            modelBuilder.Configurations.Add(new EntityConfigurationAnimal());
            base.OnModelCreating(modelBuilder);
        }
    }
}
