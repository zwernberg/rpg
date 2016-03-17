using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg
{
    public class Character
    {
        public string name{ get; private set; }
        public CharacterClass characterClass { get; private set; }
        public Race race { get; private set; }
        public int level { get; private set; }
        public int experience { get; private set; }
        public int strength { get; private set; }
        public int wisdom { get; private set; }
        public int health { get; private set; }
        public int maxHealth { get; private set; }
        public int mana { get; private set; }
        public int maxMana { get; private set; }


        public  Character(string _name, CharacterClass _characterClass, Race _race)
        {
            name = _name;
            characterClass = _characterClass;
            race = _race;

        }
    }

}
