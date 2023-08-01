namespace LeetCodeExcercises
{
    public static class BasicCalculatorII
    {
        public static int Calculate(string s)
        {
            int i = 0;
            int cur = 0;
            int prev = 0;
            int res = 0;
            char curOperation = '+';
            while (i < s.Length)
            {
                char curChar = s[i];

                if (IsDigit(curChar))
                {
                    while (i < s.Length && IsDigit(s[i]))
                    {
                        cur = cur * 10 + int.Parse(s[i].ToString());

                        i++;
                    }
                    i--;
                    if (curOperation == '+')
                    {
                        res += cur;
                        prev = cur;
                    }
                    else if (curOperation == '-')
                    {
                        res -= cur;
                        prev = -cur;
                    }
                    else if (curOperation == '*')
                    {
                        res -= prev;
                        res += prev * cur;
                        prev = prev * cur;
                    }
                    else
                    {
                        res -= prev;
                        res += prev / cur;
                        prev = prev / cur;
                    }
                    cur = 0;
                }
                else if (curChar != ' ')
                {
                    curOperation = curChar;
                }
                i++;
            }
            return res;
        }

        public static bool IsDigit(char c)
        {
            if (c >= '0' && c <= '9')
            {
                return true;
            }
            return false;
        }
    }
}
