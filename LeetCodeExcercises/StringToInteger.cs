namespace LeetCodeExcercises
{
    public static class StringToInteger
    {
        public static int MyAtoi(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) { return 0; }

            char c = '+';
            int i = 0;

            while (i < s.Length && s[i] == ' ')
            {
                i++;
            };

            if (s[i] == '-')
            {
                c = '-';
                i++;
            }
            else if (s[i] == '+')
            {
                i++;
            }

            int maxOverflow = int.MaxValue / 10;
            var maxOverflowTail = int.MaxValue % 10;

            int result = 0;
            for (; i < s.Length; i++)
            {
                int digit = s[i] - '0';
                if (s[i] < '0' || s[i] > '9')
                {
                    break;
                }
                else
                {
                    if (result > maxOverflow ||
                        (result == maxOverflow && digit > maxOverflowTail))
                    {
                        return c == '-' ? int.MinValue : int.MaxValue;
                    }

                    result = result * 10 + digit;
                }
            }

            if (c == '-') result = -result;

            return result;
        }
    }
}
