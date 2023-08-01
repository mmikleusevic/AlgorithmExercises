namespace LeetCodeExcercises
{
    public static class ReverseString
    {
        public static void ReverseStringMethod(char[] s)
        {
            //Rekurzija Lošije

            //Reverse(0,s.Length-1);

            //void Reverse(int l, int r)
            //{
            //    if (l < r)
            //    {
            //        char temp = s[l];
            //        s[l] = s[r];
            //        s[r] = temp;
            //        Reverse(l + 1, r - 1);
            //    }
            //}

            //Stack Lošije

            //Stack<char> stack = new();

            //foreach(char c in s)
            //{
            //    stack.Push(c);
            //}
            //int i = 0;
            //while(stack.Count > 0)
            //{
            //    s[i] = stack.Pop();
            //    i++;
            //}

            //Iterative Najbolje rješenje
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
        }
    }
}
