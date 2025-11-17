using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_with_a_monster
{
    internal class Monster : Character
    {
        public Monster() 
        {
            
        }

        public Monster(int newHealth, int newMaxHealth, string newName, int newMinStrength, int newMaxStrength) 
            : base(newHealth, newMaxHealth, newName, newMinStrength, newMaxStrength)
        {
            
        }
    }
}
