using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPO;
using IO;

namespace BIZ
{
    public class ClassBIZ : ClassNotify
    {
        private AnimalContext getData = new AnimalContext();
        private ObservableCollection<Animal> animals;
        private ObservableCollection<Gender> genders;
        private ObservableCollection<Species> species;
        private Animal selectedAnimal;
        private Species selectedSpecies;
        private Gender selectedGender;

        public ClassBIZ()
        {

        }
        
        public ObservableCollection<Animal> Animals
        {
            get { return animals; }
            set { animals = value; }
        }
        
        public ObservableCollection<Gender> Genders
        {
            get { return genders; }
            set { genders = value; }
        }
        
        public ObservableCollection<Species> Species
        {
            get { return species; }
            set { species = value; }
        }
        
        public Animal SelectedAnimal
        {
            get { return selectedAnimal; }
            set
            {
                if (value != selectedAnimal)
                {
                    selectedAnimal = value;
                    Notify("SelectedAnimal");
                }
            }
        }

        public Species SelectedSpecies
        {
            get { return selectedSpecies; }
            set
            {
                if (value != selectedSpecies)
                {
                    selectedSpecies = value;
                    Notify("SelectedSpecies");
                }
            }
        }

        public Gender SelectedGender
        {
            get { return selectedGender; }
            set
            {
                if (value != selectedGender)
                {
                    selectedGender = value;
                    Notify("SelectedGender");
                }
            }
        }
    }
}
