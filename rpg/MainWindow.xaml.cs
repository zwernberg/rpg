﻿using Engine.entities;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace rpg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public MainWindow(Character character)
        {
            InitializeComponent();
            NameLabel.Content = character.Name;
            RaceLabel.Content = character.Race;
            ClassLabel.Content = character.CharacterClass;
            StrengthLabel.Content = character.Strength;

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            NewCharacter newCharWindow = new NewCharacter();
            this.Hide();
            newCharWindow.ShowDialog();
        }

    }
}
