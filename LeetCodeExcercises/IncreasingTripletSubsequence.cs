namespace LeetCodeExcercises
{
    public static class IncreasingTripletSubsequence
    {
        public static bool IncreasingTriplet(int[] nums)
        {
            int small = int.MaxValue;
            int big = int.MaxValue;
            foreach (int n in nums)
            {
                if (n <= small)
                {
                    small = n;
                }
                else if (n <= big)
                {
                    big = n;
                }
                else return true;
            }
            return false;
        }
    }
}
