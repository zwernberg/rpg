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
using NDiceBag;
using Engine.entities;
using Engine;

namespace rpg
{
    /// <summary>
    /// Interaction logic for NewCharacter.xaml
    /// </summary>
    /// 





    public partial class NewCharacter : Window
    {

        private Character _character { get; set; }

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
            GeneratePlayer();
        }

        private void Window_loaded(object sender, RoutedEventArgs e)
        {

        }




        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CreateCharacter_Click(object sender, RoutedEventArgs e)
        {
            this._character = Character.CharacterFactory(NameTextBox.Text, (CharacterClass)CharacterClassCombo.SelectedIndex, (Race)RaceComboBox.SelectedIndex, _character.Strength, _character.Wisdom, _character.Health, _character.Mana);
            MainWindow main = new MainWindow(_character);
            this.Hide();
            main.ShowDialog();
        }

        private void comboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
          
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            GeneratePlayer();

        }

        private void GeneratePlayer()
        {
            string name;
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                name = "";
            }
            else
            {
                name = NameTextBox.Text;
            }
            this._character = Character.RandomCharacterFactory("");
            DataContext = _character;
            RaceComboBox.SelectedValue = this._character.Race;
            CharacterClassCombo.SelectedValue = this._character.CharacterClass;

        }
    }
}
