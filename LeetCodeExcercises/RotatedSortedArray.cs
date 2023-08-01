namespace LeetCodeExcercises
{
    public static class RotatedSortedArray
    {
        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            int first = nums[0];

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int value = nums[mid];

                if (target == value)
                {
                    return mid;
                }

                if (value < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

                bool isBig = value >= first;
                bool target_big = target >= first;

                if (isBig == target_big)
                {
                    if (value < target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else
                {
                    if (isBig)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return -1;
        }
    }
}
