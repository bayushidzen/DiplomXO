namespace DiplomXO
{
    internal class Game
    {
        public static void MainGame(string[,] map)
        {
            bool team = true;
            int round = 1;
            int maxRounds = 9;
            while (round <= maxRounds)
            {
                if (team) Console.WriteLine("Ходят крестики");
                else Console.WriteLine("Ходят нолики");
                Map.PrintMap(map);
                Console.WriteLine("Введите цифру вашего хода:\n");
                Move.MakeMove(map, Cell.GetPlayerCellNumber(map), team);
                if (GetWinner.HasWinner(map, ref team))
                {
                    Console.WriteLine();
                    if (team)
                    {
                        Map.PrintMap(map);
                        Console.WriteLine("\nКрестики победили!");
                    }
                    else
                    {
                        Map.PrintMap(map);
                        Console.WriteLine("\nНолики победили!");
                    }
                    break;
                }
                team = !team;
                round++;
                Console.WriteLine();
            }
            if (round >= 9)
            {
                Map.PrintMap(map);
                Console.WriteLine("\nНичья!");
            }
        }
        public static void MainMenu()
        {
            bool isGameActive = true;
            bool isFirstRun = true;
            while (isGameActive)
            {
                if (isFirstRun)
                {
                    Console.WriteLine("Вы хотите начать игру?");
                    Console.WriteLine("1 - Да 2 - Нет");
                    Console.Write("Ваш выбор: ");
                }
                else
                {
                    Console.WriteLine("Вы хотите сыграть еще раз?");
                    Console.WriteLine("1 - Да 2 - Нет");
                    Console.Write("Ваш выбор: ");
                }

                string userInput = Console.ReadLine();
                int userChoice;
                if (int.TryParse(userInput, out userChoice))
                {
                    switch (userChoice)
                    {
                        case 1:
                            isFirstRun = false;
                            Console.WriteLine();
                            var map = Map.GenerateMap();
                            MainGame(map);
                            break;
                        case 2: isGameActive = false; break;
                        default: Console.WriteLine("Неверный ввод. Пожалуйста, введите цифру от 1 до 2."); break;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите цифру от 1 до 2.");
                }
            }
        }
    }
}
