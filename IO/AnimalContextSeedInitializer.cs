using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using REPO;

namespace IO
{
    public class AnimalContextSeedInitializer : DropCreateDatabaseIfModelChanges<AnimalContext>
    {
        IList<Gender> defaultGender = new List<Gender>();
        IList<Species> defaultSpecies = new List<Species>
            {
            new Species() { SpeciesName = "Skildpadde" },
            new Species() { SpeciesName = "Hun" },
            new Species() { SpeciesName = "Kat" },
            new Species() { SpeciesName = "Hest" },
            new Species() { SpeciesName = "Slange" },
            new Species() { SpeciesName = "Gris" },
            new Species() { SpeciesName = "Fugl" }
            };

        public AnimalContextSeedInitializer()
        {
            defaultGender.Add(new Gender() { GenderName = "Hankøn" });
            defaultGender.Add(new Gender() { GenderName = "Hunkøn" });
            defaultGender.Add(new Gender() { GenderName = "Tvekøn" });
        }

        protected override void Seed(AnimalContext context)
        {
            foreach (Gender gender in defaultGender)
            {
                context.Gender.Add(gender);
            }
            
            foreach (Species species in defaultSpecies)
            {
                context.Species.Add(species);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
