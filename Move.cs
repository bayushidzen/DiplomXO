namespace DiplomXO
{
    internal class Move
    {
        public static bool IsMoveCorrect(string[,] map, string cellNumber)
        {
            switch (cellNumber)
            {
                case "1": return Cell.CheckCell(map, 0, 0);
                case "2": return Cell.CheckCell(map, 0, 1);
                case "3": return Cell.CheckCell(map, 0, 2);
                case "4": return Cell.CheckCell(map, 1, 0);
                case "5": return Cell.CheckCell(map, 1, 1);
                case "6": return Cell.CheckCell(map, 1, 2);
                case "7": return Cell.CheckCell(map, 2, 0);
                case "8": return Cell.CheckCell(map, 2, 1);
                case "9": return Cell.CheckCell(map, 2, 2);
            }
            return false;
        }

        public static string[,] MakeMove(string[,] map, string cellNumber, bool isCrossNow)
        {
            string player = string.Empty;
            if (isCrossNow) player = "X";
            else player = "O";
            Cell.ChangeCellValue(map, cellNumber, player);
            return map;
        }
    }
}