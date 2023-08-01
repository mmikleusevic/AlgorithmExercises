namespace LeetCodeExcercises
{
    public static class FindFirstAndLastPositionOfElementInSortedArray
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            int left = BinarySearch(nums, target, true);
            int right = BinarySearch(nums, target, false);

            return new int[] { left, right };



            //Moje rješenje

            //int[] array = new int[] { -1, -1 };
            //if (nums == null || nums.Length == 0) return array;
            //int l = 0;
            //int r = nums.Length - 1;
            //while (l <= r)
            //{
            //    if (nums[l] == target)
            //    {
            //        array[0] = l;
            //        while (r >= l)
            //        {
            //            if (nums[r] == target)
            //            {
            //                array[1] = r;
            //                return array;
            //            }
            //            r--;
            //        }
            //    }
            //    else if (nums[r] == target)
            //    {
            //        array[1] = r;
            //        while (l <= r)
            //        {
            //            if (nums[l] == target)
            //            {
            //                array[0] = l;
            //                return array;
            //            }
            //            l++;
            //        }
            //    }
            //    l++;
            //    r--;
            //}

            //return array;
        }

        public static int BinarySearch(int[] nums, int target, bool leftBias)
        {
            int l = 0;
            int r = nums.Length - 1;
            int i = -1;

            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (target > nums[mid])
                {
                    l = mid + 1;
                }
                else if (target < nums[mid])
                {
                    r = mid - 1;
                }
                else
                {
                    i = mid;
                    if (leftBias)
                    {
                        r = mid - 1;
                    }
                    else
                    {
                        l = mid + 1;
                    }
                }
            }
            return i;
        }
    }
}
