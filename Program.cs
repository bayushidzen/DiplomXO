string[,] map = new string[3, 3]
            {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"}
            };
bool team = true;
int round = 1;
int maxRounds = 9;
while (round <= maxRounds)
{
    if (team) Console.WriteLine("Ходят крестики");
    else Console.WriteLine("Ходят нолики");
    PrintMap(map);
    Console.WriteLine("Введите цифру вашего хода:\n");
    MakeMove(map, GetPlayerCellNumber(map), team);
    if (HasWinner(map, ref team))
    {
        Console.WriteLine();
        if (team)
        {
            PrintMap(map);
            Console.WriteLine("\nКрестики победили!");
        }
        else
        {
            PrintMap(map);
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
    PrintMap(map);
    Console.WriteLine("\nНичья!");
}

static string GetPlayerCellNumber(string[,] map)
{
    string response = String.Empty;
    bool isCorrect = false;
    while (!isCorrect)
    {
        string userInput = Console.ReadLine();
        int number;
        if (int.TryParse(userInput, out number))
        {
            if (number > 0 && number < 10)
            {
                if (IsMoveCorrect(map, userInput))
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
static string[,] MakeMove(string[,] map, string cellNumber, bool isCrossNow) // Заменить в поле цифру на символ 
{
    string player = String.Empty;
    if (isCrossNow) player = "X";
    else player = "O";
    ChangeCellValue(map, cellNumber, player);
    return map;
}
static bool IsMoveCorrect(string[,] map, string cellNumber) // Проверить ввод пользователя на наличие существующего уже хода на поле 
{
    switch (cellNumber)
    {
        case "1": return CheckCell(map, 0, 0);
        case "2": return CheckCell(map, 0, 1);
        case "3": return CheckCell(map, 0, 2);
        case "4": return CheckCell(map, 1, 0);
        case "5": return CheckCell(map, 1, 1);
        case "6": return CheckCell(map, 1, 2);
        case "7": return CheckCell(map, 2, 0);
        case "8": return CheckCell(map, 2, 1);
        case "9": return CheckCell(map, 2, 2);
    }
    return false;
}
static void PrintMap(string[,] map) // Вывод поля через пробелы 
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
static void ChangeCellValue(string[,] map, string input, string player)
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
static bool HasWinner(string[,] map, ref bool team)
{
    int cnt = 0;
    while (cnt < map.GetLength(0))
    {
        if (map[cnt, 0] == map[cnt, 1] && map[cnt, 2] == map[cnt, 1])
        {
            if (map[cnt, 1] == "X") team = true;
            else team = false;
            return true;
        }
        cnt++;
    }
    cnt = 0;
    while (cnt < map.GetLength(0))
    {
        if (map[0, cnt] == map[1, cnt] && map[2, cnt] == map[1, cnt])
        {
            if (map[1, cnt] == "X") team = true;
            else team = false;
            return true;
        }
        cnt++;
    }
    if (map[0, 0] == map[1, 1] && map[2, 2] == map[1, 1])
    {
        if (map[1, 1] == "X") team = true;
        else team = false;
        return true;
    }
    if (map[0, 2] == map[1, 1] && map[2, 0] == map[1, 1])
    {
        if (map[1, 1] == "X") team = true;
        else team = false;
        return true;
    }
    return false;
}
static bool CheckCell(string[,] map, int num1, int num2)
{
    if (map[num1, num2] == "X") return false;
    else if (map[num1, num2] == "O") return false;
    else return true;
}