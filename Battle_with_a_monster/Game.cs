using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_with_a_monster
{
    internal class Game  
    {
        private Player _player;
        private Monster _moster;

        public Game(Player newPlayer, Monster newMonster) 
        {
            _player = newPlayer;
            _moster = newMonster;
        }

        public string GetInfoP(Player player)
        {
            return $"Информация о герои {player.Name}:" +
                $"\nЗдоровье: {player.Health} / {player.MaxHealth}" +
                $"\nСила атаки: от {player.MinStrength} до {player.MaxStrength}" +
                $"\nЛечение: {player.AmountOfHealthBeingRestored} " +
                $"\nСпециальная атака: {player.UsingSpecialAttack}";
        }

        public string GetInfoM(Monster monster) 
        {
            return $"Информация о монстре {monster.Name}:" +
                $"\nЗдоровье: {monster.Health} / {monster.MaxHealth}" +
                $"\nСила атаки: от {monster.MinStrength} до {monster.MaxStrength}";
        }
    }
}
