using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using REPO;

namespace IO
{
    public class InitializerSpecies : DropCreateDatabaseIfModelChanges<AnimalContext>
    {
        protected override void Seed(AnimalContext context)
        {
            IList<Species> defaultSpecies = new List<Species>();
            defaultSpecies.Add(new Species() { SpeciesName = "Skildpadde" });
            defaultSpecies.Add(new Species() { SpeciesName = "Hun" });
            defaultSpecies.Add(new Species() { SpeciesName = "Kat" });
            defaultSpecies.Add(new Species() { SpeciesName = "Hest" });
            defaultSpecies.Add(new Species() { SpeciesName = "Slange" });
            defaultSpecies.Add(new Species() { SpeciesName = "Gris" });
            defaultSpecies.Add(new Species() { SpeciesName = "Fugl" });

            foreach (Species species in defaultSpecies)
            {
                context.Species.Add(species);
            }

            base.Seed(context);
        }
    }
}
