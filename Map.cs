namespace DiplomXO
{
    internal static class Map
    {
        public static void PrintMap(string[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(map[i, j] + " ");
                        Console.ResetColor();
                    }
                    else if (map[i, j] == "O")
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(map[i, j] + " ");
                        Console.ResetColor();
                    }
                    else Console.Write(map[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static string[,] GenerateMap()
        {
            var map = new string[3, 3]
                {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"}
                };
            return map;
        }
    }
}