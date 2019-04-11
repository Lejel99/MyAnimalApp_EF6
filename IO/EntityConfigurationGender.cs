using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPO;

namespace IO
{
    class EntityConfigurationGender : EntityTypeConfiguration<Gender>
    {

        public EntityConfigurationGender()
        {
            this.ToTable("Genders");
            this.HasKey<int>(g => g.GenderId);
            this.Property(g => g.GenderName)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
