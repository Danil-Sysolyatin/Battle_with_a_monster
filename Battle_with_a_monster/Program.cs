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
                Console.WriteLine("Выберите команду:");
                Console.WriteLine("  Начать игру   -> 1");
                Console.WriteLine("  Выйти из игры -> 2");
                Console.Write("Команда -> ");
                string command = Console.ReadLine();

                switch (command) 
                {
                    case "1":

                        Console.Write("Введите имя Персонажа -> ");
                        string nameCharacter = Console.ReadLine();
                        Console.Write("Введите имя Монстра -> ");
                        string nameMonster = Console.ReadLine();

                        Player player = new Player(100, 100, nameCharacter, 7, 15, 15, 20);
                        Monster monster = new Monster(100, 100, nameMonster, 7, 15);
                        Game part = new Game(player, monster);
                        Console.Write($"\n{part.GetInfoP(player)} \t\t{part.GetInfoM(monster)}");
                        
                        break;
                    case "2":
                        duration = false;
                        break;
                }
            }
            


            
            //Game<string, string> n2 = new Game<string, string>("ffg", "hjk");
            //n2.StartGameP(new Player(100, 100, "Priora", 15, 25, 35, 50));
        }
    }
}
