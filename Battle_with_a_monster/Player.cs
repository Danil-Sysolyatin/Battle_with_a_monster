using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_with_a_monster
{
    internal class Player : Character
    {
        private int _amountOfHealthBeingRestored; //количество восстанавливаемого здоровья
        private int _specialAttackCoefficient; //коэффициент специальной атаки
        private bool _usingSpecialAttack; //использования специальной атаки

        public Player()
        {
            _amountOfHealthBeingRestored = 0;
            _specialAttackCoefficient = 0;
            _usingSpecialAttack = false;

        }

        public Player(int newAmountOfHealthBeingRestored, int newSpecialAttackCofficient)
        {
            _amountOfHealthBeingRestored = newAmountOfHealthBeingRestored;
            _specialAttackCoefficient = newSpecialAttackCofficient;
            _usingSpecialAttack = false;
        }

        public int GetSpecialAttackDamage(int damege)
        {
            _usingSpecialAttack = true;
            return damege * _specialAttackCoefficient;

        }
    }
}
