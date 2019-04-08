using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPO;

namespace IO
{
    class EntityConfigurationAnimal : EntityTypeConfiguration<Animal>
    {
        public EntityConfigurationAnimal()
        {
            this.ToTable("Animals");

            this.HasKey<int>(g => g.AnimalId);

            this.Property(u => u.AnimalName)
                .HasMaxLength(30)
                .IsRequired();

            this.Property(a => a.GenderId)
                .IsRequired();

            this.Property(a => a.SpeciesId)
                .IsRequired();
        }
    }
}
