namespace LeetCodeExcercises
{
    public static class HouseRobber
    {
        public static int Rob(int[] nums)
        {
            int rob1 = 0;
            int rob2 = 0;

            foreach (int money in nums)
            {
                int temp = Math.Max(money + rob1, rob2);
                rob1 = rob2;
                rob2 = temp;
            }

            return rob2;
        }
    }
}
