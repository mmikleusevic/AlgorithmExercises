namespace LeetCodeExcercises
{
    public static class FizzBuzz
    {
        public static IList<string> FizzBuzzMethod(int n)
        {
            List<string> list = new();
            int fizz = 0;
            int buzz = 0;
            for (int i = 1; i <= n; i++)
            {
                fizz++;
                buzz++;
                if (fizz == 3 && buzz == 5)
                {
                    list.Add("FizzBuzz");
                    fizz = 0;
                    buzz = 0;
                }
                else if (fizz == 3)
                {
                    list.Add("Fizz");
                    fizz = 0;
                }
                else if (buzz == 5)
                {
                    list.Add("Buzz");
                    buzz = 0;
                }
                else
                {
                    list.Add(i.ToString());
                }
            }

            return list;

            //List<string> list = new();

            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        list.Add("FizzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        list.Add("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        list.Add("Buzz");
            //    }
            //    else
            //    {
            //        list.Add(i.ToString());
            //    }
            //}
            //return list;
        }
    }
}
