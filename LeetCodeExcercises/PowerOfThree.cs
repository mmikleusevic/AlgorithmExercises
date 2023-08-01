namespace LeetCodeExcercises
{
    public static class PowerOfThree
    {
        public static bool IsPowerOfThree(int n)
        {
            //Savršeno rješenje
            int max = (int)Math.Pow(3, 19);
            return n > 0 && max % n == 0;

            //Od lika
            //if (n <= 0) return false;
            //int x = 1;
            //int i = 0;

            //while(x <= n)
            //{
            //    if(x == n) return true;
            //    i++;
            //    x = (int)Math.Pow(3, i);
            //}

            //return false;


            //Moje rješenje
            //if (n == 1) return true;
            //if (n < 3) return false;

            //while (n != 1)
            //{
            //    int temp = n % 3;
            //    if (temp == 0)
            //    {
            //        n = n / 3;
            //    }
            //    else
            //    {
            //        return false;
            //    }
            //}

            //return true;
        }
    }
}
