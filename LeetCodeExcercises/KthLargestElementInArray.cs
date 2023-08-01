namespace LeetCodeExcercises
{
    public static class KthLargestElementInArray
    {
        //Navodno bolje rješenje na leetcodeu

        public static int FindKthLargest(int[] nums, int k)
        {
            Sort(nums, 0, nums.Length - 1);
            return nums[nums.Length - k];
        }

        public static void Sort(int[] nums, int l, int r)
        {
            int leftIndex = l;
            int rightIndex = r;
            int pivot = nums[l];
            while (l <= r)
            {
                while (nums[l] < pivot)
                {
                    l++;
                }
                while (nums[r] > pivot)
                {
                    r--;
                }
                if (l <= r)
                {
                    int temp = nums[l];
                    nums[l] = nums[r];
                    nums[r] = temp;
                    l++;
                    r--;
                }
            }
            if (leftIndex < r)
            {
                Sort(nums, leftIndex, r);
            }
            if (l < rightIndex)
            {
                Sort(nums, l, rightIndex);
            }
        }
    }
}
