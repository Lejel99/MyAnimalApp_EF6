using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPO;

namespace IO
{
    public class AnimalContext : DbContext
    {
        public AnimalContext() : base("Data Source=cv-bb-5851;Initial Catalog=Animals;Integrated Security=True")
        {
            Database.SetInitializer<AnimalContext>(new CreateDatabaseIfNotExists<AnimalContext>());
            Database.SetInitializer(new InitializerGender());
        }

        public DbSet<Gender> Gender { get; set; }
        public DbSet<Animal> Animal { get; set; }
        public DbSet<Species> Species { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EntityConfigurationGender());
        }
    }
}
