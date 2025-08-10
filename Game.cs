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
    }
}
