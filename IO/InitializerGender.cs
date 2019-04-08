using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using REPO;

namespace IO
{
    public class InitializerGender : DropCreateDatabaseIfModelChanges<AnimalContext>
    {
        protected override void Seed(AnimalContext context)
        {
            IList<Gender> defaultGender = new List<Gender>();
            defaultGender.Add(new Gender() { GenderName = "Hankøn" });
            defaultGender.Add(new Gender() { GenderName = "Hunkøn" });
            defaultGender.Add(new Gender() { GenderName = "Tvekøn" });

            foreach (Gender gender in defaultGender)
            {
                context.Gender.Add(gender);
            }

            base.Seed(context);
        }
    }
}
