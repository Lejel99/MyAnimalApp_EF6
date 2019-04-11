using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BIZ;
using REPO;

namespace MyAnimalApp_EF6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ClassBIZ CB = new ClassBIZ();
        ClassBIZ CBTemp = new ClassBIZ();
        public MainWindow()
        {
            InitializeComponent();
            gridMain.DataContext = CB;
            CB.MakeDataBase();
        }

        private void ButtonCreateAnimal_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Tag.ToString() == "1")
            {
                CB.SelectedAnimal = new Animal();
            }

            buttonCreateAnimal.Visibility = Visibility.Collapsed;
            buttonEditAnimal.Visibility = Visibility.Collapsed;
            buttonDeleteAnimal.Visibility = Visibility.Collapsed;

            buttonSaveAnimal.Visibility = Visibility.Visible;
            buttonDiscardChanges.Visibility = Visibility.Visible;

            textBoxAnimalName.IsEnabled = true;
            comboBoxAnimalSpecies.IsEnabled = true;
            comboBoxAnimalGenders.IsEnabled = true;
            textBoxAnimalAge.IsEnabled = true;
            listViewAnimals.IsEnabled = false;

            CopyAnimal(CBTemp, CB);
            gridInfo.DataContext = CBTemp;
        }

        private void ButtonSaveAnimal_Click(object sender, RoutedEventArgs e)
        {
            CopyAnimal(CB, CBTemp);
            CB.SaveAnimal();
            gridInfo.DataContext = CB;

            buttonCreateAnimal.Visibility = Visibility.Visible;
            buttonEditAnimal.Visibility = Visibility.Visible;
            buttonDeleteAnimal.Visibility = Visibility.Visible;

            buttonSaveAnimal.Visibility = Visibility.Collapsed;
            buttonDiscardChanges.Visibility = Visibility.Collapsed;

            textBoxAnimalName.IsEnabled = false;
            comboBoxAnimalSpecies.IsEnabled = false;
            comboBoxAnimalGenders.IsEnabled = false;
            textBoxAnimalAge.IsEnabled = false;
            listViewAnimals.IsEnabled = true;
        }

        //private void ComboBoxAnimalGenders_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    CB.SelectedAnimal.Gender = CB.SelectedGender;
        //}

        //private void ComboBoxAnimalSpecies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    CB.SelectedAnimal.Species = CB.SelectedSpecies;
        //}

        private void ButtonDiscardChanges_Click(object sender, RoutedEventArgs e)
        {
            gridInfo.DataContext = CB;

            buttonCreateAnimal.Visibility = Visibility.Visible;
            buttonEditAnimal.Visibility = Visibility.Visible;
            buttonDeleteAnimal.Visibility = Visibility.Visible;

            buttonSaveAnimal.Visibility = Visibility.Collapsed;
            buttonDiscardChanges.Visibility = Visibility.Collapsed;

            textBoxAnimalName.IsEnabled = false;
            comboBoxAnimalSpecies.IsEnabled = false;
            comboBoxAnimalGenders.IsEnabled = false;
            textBoxAnimalAge.IsEnabled = false;
            listViewAnimals.IsEnabled = true;
        }

        private void ButtonDeleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            if (CB.SelectedAnimal.AnimalId != 0)
            {
                CB.DeleteAnimal();
            }
            
        }

        private void ListViewAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView lv = (ListView)sender;
            if (lv.SelectedItem != null)
            {
                CB.SelectedAnimal = null;
                CB.SelectedAnimal = (Animal)lv.SelectedItem;
            }
        }

        private void CopyAnimal(ClassBIZ toBIZ, ClassBIZ fromBIZ)
        {
            toBIZ.SelectedAnimal = (Animal)fromBIZ.SelectedAnimal.Clone();
        }

        private void TextBoxAnimalAge_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
