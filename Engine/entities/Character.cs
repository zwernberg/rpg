using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NDiceBag;

namespace Engine.entities
{
    public class Character
    {
        public string Name{ get; private set; }
        public CharacterClass CharacterClass { get; private set; }
        public Race Race { get; private set; }
        public int Level { get; private set; }
        public int Experience { get; private set; }
        public int Strength { get; private set; }
        public int Wisdom { get; private set; }
        public int Health { get; private set; }
        public int MaxHealth { get; private set; }
        public int Mana { get; private set; }
        public int MaxMana { get; private set; }


        public  Character(string name, CharacterClass characterClass, Race race, int level, int strength, int wisdom, int health, int maxHealth, int mana, int maxMana, int experience = 0)
        {
            this.Name = name;
            this.CharacterClass = characterClass;
            this.Race = race;
            this.Level = level;
            this.Strength = strength;
            this.Wisdom = wisdom;
            this.Health = health;
            this.MaxHealth = maxHealth;
            this.Mana = mana;
            this.MaxMana = maxMana;
            this.Experience = experience;



        }

        public static Character CharacterFactory(string name, CharacterClass characterClass, Race race)
        {
            int strength = 1.d().Roll();
            int wisdom = 1.d().Roll();
            int health = 1.d(10).Roll()+ 10;
            int maxHealth = health;
            int mana = 1.d(10).Roll() + 10;
            int maxMana = mana;

            return new Character(name, characterClass, race, 1, strength, wisdom, health, maxHealth, mana, maxMana, 0);
        }

        public static Character CharacterFactory(string name, CharacterClass characterClass, Race race, int strength, int wisdom,int health, int mana)
        {

            int maxHealth = health;
            int maxMana = mana;

            return new Character(name, characterClass, race, 1, strength, wisdom, health, maxHealth, mana, maxMana, 0);
        }

        public static Character RandomCharacterFactory(string name)
        {
            Random rand = new Random();
            int strength = rand.Next(1,6);
            int characterLength = Enum.GetNames(typeof(CharacterClass)).Length;
            System.Console.Write(characterLength);
            int raceLength = Enum.GetNames(typeof(Race)).Length;
            CharacterClass characterClass = (CharacterClass)(rand.Next(0, characterLength));
            Race race = (Race)(rand.Next(0,raceLength));
            int wisdom = rand.Next(1, 6);
            int health = rand.Next(10,20);
            int maxHealth = health;
            int mana = rand.Next(10, 20);
            int maxMana = mana;

            return new Character(name, characterClass, race, 1, strength, wisdom, health, maxHealth, mana, maxMana, 0);
        }


    }

}
