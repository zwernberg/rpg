using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace rpg
{
    /// <summary>
    /// Interaction logic for NewCharacter.xaml
    /// </summary>
    /// 





    public partial class NewCharacter : Window
    {

        public NewCharacter()
        {
            InitializeComponent();
            var races = new Dictionary<Race, string>();

            foreach (var enumValue in typeof(Race).GetEnumValues())
            {
                races.Add((Race)enumValue, enumValue.ToString());
            }
            RaceComboBox.IsReadOnly = true;
            RaceComboBox.ItemsSource = races;
            RaceComboBox.SelectedValuePath = "Key";
            RaceComboBox.DisplayMemberPath = "Value";

            var playerClasses = new Dictionary<CharacterClass, string>();

            foreach (var enumValue in typeof(CharacterClass).GetEnumValues())
            {
                playerClasses.Add((CharacterClass)enumValue, enumValue.ToString());
            }

            CharacterClassCombo.IsReadOnly = true;
            CharacterClassCombo.ItemsSource = playerClasses;
            CharacterClassCombo.SelectedValuePath = "Key";
            CharacterClassCombo.DisplayMemberPath = "Value";
        }

        private void Window_loaded(object sender, RoutedEventArgs e)
        {

        }




        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CreateCharacter_Click(object sender, RoutedEventArgs e)
        {
            Character hero = new Character(NameTextBox.Text, (CharacterClass)CharacterClassCombo.SelectedIndex, (Race)RaceComboBox.SelectedIndex);
            MainWindow main = new MainWindow();
            this.Hide();
            main.ShowDialog();
        }

        private void comboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
          
        }
    }
}
