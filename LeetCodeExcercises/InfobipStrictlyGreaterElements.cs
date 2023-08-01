namespace LeetCodeExcercises
{
    public static class InfobipStrictlyGreaterElements
    {
        public static int Solve(int[] A, int[] B, int N)
        {
            int count = 0;

            Array.Sort(B);

            foreach (int num in A)
            {
                int index = Array.BinarySearch(B, num);

                if (index < 0)
                {
                    // Element not found in B, binary search returns bitwise complement of the next larger element
                    index = ~index;
                    count += B.Length - index;
                }
                else
                {
                    // Element found in B, count elements greater than it
                    count += B.Length - index - 1;
                }
            }

            return count;
        }

        //public static int Solve(int[] A, int[] B, int N)
        //{
        //    SortedSet<int> tree = new();
        //    int result = 0;

        //    for (int i = 0; i < N; i++)
        //    {
        //        tree.Add(A[i]);
        //    }

        //    for (int i = 0; i < N; i++)
        //    {
        //        SortedSet<int> countHigher = tree.GetViewBetween(i+1, int.MaxValue);
        //        if (countHigher.Count > 0)
        //        {
        //            result += countHigher.Count;
        //        }
        //    }
        //    return result;
        //}
    }
}
