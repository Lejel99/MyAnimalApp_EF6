using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO
{
    public class Species : ClassNotify
    {
        private int speciesId;
        private string speciesName;

        public Species()
        {
            SpeciesId = 0;
        }
        
        public int SpeciesId
        {
            get { return speciesId; }
            set
            {
                if (value != speciesId)
                {
                    speciesId = value;
                    Notify("SpeciesId");
                }
            }
        }

        public string SpeciesName
        {
            get { return speciesName; }
            set
            {
                if (value != speciesName)
                {
                    speciesName = value;
                    Notify("SpeciesName");
                }
            }
        }
    }
}
