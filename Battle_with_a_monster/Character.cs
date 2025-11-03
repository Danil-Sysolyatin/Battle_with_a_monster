using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_with_a_monster
{
    internal class Character
    {
        private int _health; //Текущее здоровье
        private int _maxHealth; //Максимальное здоровье
        private string _name; //Имя персонажа
        private int _minStrength;//Минимальная сила атаки
        private int _maxStrength; //Максимальная сила атаки


        public Character()
        {
            _health = 0;
            _maxHealth = 0;
            _name = "No name";
            _minStrength = 0;
            _maxStrength = 0;
        }

        public Character(int newHealth, int newMaxHealth, string newName, int newMinStrength, int newMaxStrength)
        {
            _health = newHealth;
            _maxHealth = newMaxHealth;
            _name = newName;
            _minStrength = newMinStrength;
            _maxStrength = newMaxStrength;
        }

        //свойство которое возвращает true если здоровье больше нуля.
        public bool IsAlive
        {
            get
            {
                if (_health > 0)
                {
                    return true;
                }
                return false;
            }

        }

        public int GetAttackDamage()
        {
            Random attack = new Random();
            return (attack.Next(_minStrength, _maxStrength));
        }

        public int TakeDamage(int damage)
        {
            _health = _health - damage;
            return _health;
        }

        public int Heal(int getHeal)
        {
            _health = _health + getHeal;
            return _health;
        }

    }
}
