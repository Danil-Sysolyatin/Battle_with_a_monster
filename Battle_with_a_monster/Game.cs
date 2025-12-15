using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Battle_with_a_monster
{
    internal class Game  
    {
        private Player _player;
        private Monster _monster;
        private int _counter;
        private string _text;

        public Game(Player newPlayer, Monster newMonster) 
        {
            _player = newPlayer;
            _monster = newMonster;
            _counter = 0;
            _text = "Новая битва началась!";
        }

        public string StartGame(Player player, Monster monster) 
        {
            return $"--------------------------------------" +
                $"\n\nИнформация о герои {player.Name}:" +
                $"\nЗдоровье: {player.Health} / {player.MaxHealth}" +
                $"\nСила атаки: от {player.MinStrength} до {player.MaxStrength}" +
                $"\nЛечение: {player.AmountOfHealthBeingRestored} " +
                $"\nСпециальная атака: {player.UsingSpecialAttack}" +
                $"\n***********************" +
                $"\nИнформация о монстре {monster.Name}:" +
                $"\nЗдоровье: {monster.Health} / {monster.MaxHealth}" +
                $"\nСила атаки: от {monster.MinStrength} до {monster.MaxStrength}" +
                $"\n\n\n{_counter}| {_text}" +
                $"\n{_counter += 1}| {_text = "Герой готовиться к действию"}";
        }

        public string StopGame() 
        {
            if (_player.IsAlive == false)
            {
                return $"Герой - {_player.Name} погиб! Монстр - {_monster.Name} победил";
            }
            else if (_monster.IsAlive == false) 
            {
                return $"Поздравляем Герой - {_player.Name} победил! Монстр - {_monster.Name} проиграл";
            }

            return "Ничья";
        }

        public string StepMonster()
        {
            if (_monster.IsAlive == true)
            {
                int damage = _monster.GetAttackDamage();
                _player.TakeDamage(damage);
                _text = "Злой монстрик думает над ходом";
                return $"{_counter += 1}| {_text}" +
                    $"\n{_counter += 1}| {_text = $"Злой монстр {_monster.Name} атакует и наносит {damage} урона"}";
            }
            return "";
        }

        public string StepPlayer() 
        {
            if (_player.IsAlive == true) 
            {
                return $"Герой делает ход:" +
                $"\n\t1) Использовать атаку" +
                $"\n\t2) Использовать специальную атаку" +
                $"\n\t3) Вылечиться" +
                $"\n\t4) Сдаться врагу :(";
            }
            return "";
            
        }

        public string ProcessPlayerChoice(string choice)
        {
            switch (choice)
            {
                case "1":
                    int damage = _player.GetAttackDamage();
                    _monster.TakeDamage(damage);
                    _text = $"Герой {_player.Name} атакует и наносит {damage} урона";
                    break;

                case "2":
                    if (_player.UsingSpecialAttack == "Нет") 
                    {
                        _text = "Специальная атака уже была использована, выберите другую команду";
                        StepPlayer();
                        return _text;
                    }

                    int specialDamage = _player.GetSpecialAttackDamage();
                    _monster.TakeDamage(specialDamage);
                    _text = $"Герой {_player.Name} использует специальную атаку и наносит {specialDamage} урона";
                    break;

                case "3":
                    _player.Heal(_player.AmountOfHealthBeingRestored);
                    _text = $"Герой {_player.Name} восстановил {_player.AmountOfHealthBeingRestored} здоровья";
                    break;

                case "4":
                    _player.TakeDamage(_player.Health);
                    _text = "Вы сдались :(";
                    break;

                default:
                    _text = "Неверный ввод, попробуйте снова.";
                    StepPlayer();
                    return _text;
            }

            return $"{_counter += 1}| {_text}" +
                $"\n{_counter += 1}| Здоровье монстра: {_monster.Health}";

        }

        public string GameLoop() 
        {
            while (_player.IsAlive == true && _monster.IsAlive == true) 
            {
                StepPlayer();
                if (_monster.IsAlive == false) 
                {
                    break;
                }

                StepMonster();
                if (_player.IsAlive == false) 
                {
                    break;
                }
            }

            
            return $"{StopGame()}";
        }
    }
}
