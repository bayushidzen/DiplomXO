namespace DiplomXO
{
    class Program
    {
        private static void Main(string[] args)
        {
            var map = Map.GenerateMap();
            Game.MainGame(map);
        }
    }
}