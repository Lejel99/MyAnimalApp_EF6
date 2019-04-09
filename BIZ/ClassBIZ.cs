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
using System.Windows;
using System.Data.Entity;

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
            Animals = new ObservableCollection<Animal>(getData.Animal.ToList() as List<Animal>);
            Species = new ObservableCollection<Species>(getData.Species.ToList() as List<Species>);
            Genders = new ObservableCollection<Gender>(getData.Gender.ToList() as List<Gender>);
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

        public void MakeDataBase()
        {
            try
            {
                using (var ctx = new AnimalContext())
                {
                    ctx.Database.CreateIfNotExists();
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var t in ex.EntityValidationErrors)
                {
                    MessageBox.Show(t.ValidationErrors.First().ErrorMessage);
                }
            }
        }
    }
}
