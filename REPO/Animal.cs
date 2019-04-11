using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO
{
    public class Animal : ClassNotify
    {
        private int animalId;
        private string animalName;
        private int animalAge;
        private Gender gender;
        private Species species;

        public Animal()
        {
            AnimalId = 0;
        }
        
        public int AnimalId
        {
            get { return animalId; }
            set
            {
                if (value != animalId)
                {
                    animalId = value;
                    Notify("AnimalId");
                }
            }
        }
        
        public string AnimalName
        {
            get { return animalName; }
            set
            {
                if (value != animalName)
                {
                    animalName = value;
                    Notify("AnimalName");
                }
            }
        }

        public int AnimalAge
        {
            get { return animalAge; }
            set
            {
                if (value != animalAge)
                {
                    animalAge = value;
                    Notify("AnimalAge");
                }
            }
        }

        [ForeignKey("Gender")]
        public int GenderId { get; set; }
        public Gender Gender
        {
            get { return gender; }
            set
            {
                if (value != gender)
                {
                    gender = value;
                    GenderId = gender.GenderId;
                    Notify("Gender");
                }
            }
        }

        [ForeignKey("Species")]
        public int SpeciesId { get; set; }
        public Species Species
        {
            get { return species; }
            set
            {
                if (value != species)
                {
                    species = value;
                    SpeciesId = species.SpeciesId;
                    Notify("Species");
                }
            }
        }
    }
}
