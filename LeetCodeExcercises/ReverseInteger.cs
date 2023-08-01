namespace LeetCodeExcercises
{
    public static class ReverseInteger
    {
        public static int Reverse(int x)
        {
            var result = 0;

            var positiveOverflow = int.MaxValue / 10;
            var nagativeOverflow = int.MinValue / 10;

            for (; x != 0; x = x / 10)
            {
                if (result > positiveOverflow || result < nagativeOverflow)
                {
                    return 0;
                }
                result = result * 10 + x % 10;
            }

            return result;


            //Moje rješenje

            //long result = 0;
            //char[] number = x.ToString().ToCharArray();

            //int l;
            //if (number[0] == '-')
            //{
            //    l = 1;
            //}
            //else
            //{
            //    l = 0;
            //}

            //for (int i = number.Length - 1; i > l; i--)
            //{
            //    char temp = number[i];
            //    number[i] = number[l];
            //    number[l] = temp;
            //    l++;
            //}

            //result = long.Parse(number);

            //if (result > int.MaxValue || result < int.MinValue) return 0;

            //return (int)result;
        }
    }
}
