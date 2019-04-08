using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPO;

namespace IO
{
    public class EntityConfigurationSpecies : EntityTypeConfiguration<Species>
    {
        public EntityConfigurationSpecies()
        {
            this.ToTable("Species");

            this.HasKey<int>(g => g.SpeciesId);
            this.Property(g => g.SpeciesName)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
