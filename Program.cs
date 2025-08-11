namespace DiplomXO
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в дипломную игру\n\"Крестики-Нолики\"");
            Console.WriteLine("Игра для двух игроков, игроки делают ход по очереди");
            Console.Write("Ходы ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Х");
            Console.ResetColor();
            Console.Write(" отмечаются красным, ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("О");
            Console.ResetColor();
            Console.WriteLine(" - синим");
            Console.WriteLine();
            Game.LaunchMenu();
        }
    }
}