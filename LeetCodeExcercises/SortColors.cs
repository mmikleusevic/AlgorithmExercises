namespace LeetCodeExcercises
{
    public static class SortColors
    {
        public static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        public static void SortColorsMethod(int[] nums)
        {

            int l = 0;
            int r = nums.Length - 1;
            int i = 0;
            while (i <= r)
            {
                if (nums[i] == 0)
                {
                    Swap(nums, l, i);
                    l++;
                }
                else if (nums[i] == 2)
                {
                    Swap(nums, i, r);
                    r--;
                    i--;
                }
                i++;
            }



            //Moje rješenje sporije

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] > nums[j])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[i];
            //            nums[i] = temp;
            //        }
            //    }
            //}
        }
    }
}
