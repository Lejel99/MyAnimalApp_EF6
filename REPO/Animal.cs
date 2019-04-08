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
        public Gender Gender { get; set; }

        [ForeignKey("Species")]
        public int SpeciesId { get; set; }
        public Species Species { get; set; }
    }
}
