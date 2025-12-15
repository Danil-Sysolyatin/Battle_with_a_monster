namespace Battle_with_a_monster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n\t\t\t\t*****************************" +
                              $"\n\t\t\t\t*  Добро пожаловать в игру  *" +
                              $"\n\t\t\t\t*   Battle with a manster   *" +
                              $"\n\t\t\t\t*****************************");

            bool duration = true;
            while (duration == true)
            {
                Console.WriteLine("\nВыберите команду:");
                Console.WriteLine("  Начать игру   -> 1");
                Console.WriteLine("  Выйти из игры -> 2");
                Console.Write("Команда -> ");
                string command = Console.ReadLine();

                switch (command) 
                {
                    case "1":

                        Console.Write("\nВведите имя Персонажа -> ");
                        string nameCharacter = Console.ReadLine();
                        Console.Write("\nВведите имя Монстра -> ");
                        string nameMonster = Console.ReadLine();

                        Player player = new Player(100, 100, nameCharacter, 8, 15, 15, 2);
                        Monster monster = new Monster(100, 100, nameMonster, 7, 15);
                        Game part = new Game(player, monster);

                        while (player.IsAlive == true && monster.IsAlive == true) 
                        {
                            Console.WriteLine($"\n{part.StartGame(player, monster)}");
                            Console.WriteLine($"\n{part.StepPlayer()}");

                            Console.Write("Команда -> ");
                            string choice = Console.ReadLine();

                            Console.WriteLine($"\n{part.ProcessPlayerChoice(choice)}");
                            Console.WriteLine($"\n{part.StepMonster()}");
                            
                        }
                        Console.WriteLine($"\n{part.StopGame()}");

                        break;
                    case "2":
                        duration = false;
                        break;
                    default:
                        Console.WriteLine("Ошибка: Неправильная команда");
                        break;
                }
            }
            


            
            //Game<string, string> n2 = new Game<string, string>("ffg", "hjk");
            //n2.StartGameP(new Player(100, 100, "Priora", 15, 25, 35, 50));
        }
    }
}
