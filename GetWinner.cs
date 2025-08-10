namespace DiplomXO
{
    internal static class GetWinner
    {
        public static bool HasWinner(string[,] map, ref bool team)
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
    }
}