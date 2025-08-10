namespace DiplomXO
{
    internal static class Cell
    {
        public static void ChangeCellValue(string[,] map, string input, string player)
        {
            switch (input)
            {
                case "1": map[0, 0] = player; break;
                case "2": map[0, 1] = player; break;
                case "3": map[0, 2] = player; break;
                case "4": map[1, 0] = player; break;
                case "5": map[1, 1] = player; break;
                case "6": map[1, 2] = player; break;
                case "7": map[2, 0] = player; break;
                case "8": map[2, 1] = player; break;
                case "9": map[2, 2] = player; break;
            }
        }

        public static bool CheckCell(string[,] map, int num1, int num2)
        {
            if (map[num1, num2] == "X") return false;
            else if (map[num1, num2] == "O") return false;
            else return true;
        }

        public static string GetPlayerCellNumber(string[,] map)
        {
            string response = string.Empty;
            bool isCorrect = false;
            while (!isCorrect)
            {
                string userInput = Console.ReadLine();
                int number;
                if (int.TryParse(userInput, out number))
                {
                    if (number > 0 && number < 10)
                    {
                        if (Move.IsMoveCorrect(map, userInput))
                        {
                            isCorrect = true;
                            return userInput;
                        }
                        else Console.WriteLine("Неверный ввод. Пожалуйста, введите цифру пустой ячейки.");
                    }
                    else Console.WriteLine("Неверный ввод. Пожалуйста, введите цифру от 1 до 9.");
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Пожалуйста, введите цифру от 1 до 9.");
                }
            }
            return response;
        }
    }
}