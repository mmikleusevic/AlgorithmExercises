namespace LeetCodeExcercises
{
    public static class NextGreaterElementI
    {
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> map = new();
            Stack<int> stack = new();
            foreach (int num in nums2)
            {
                while (stack.Count > 0 && stack.Peek() < num)
                {
                    map.Add(stack.Pop(), num);
                }
                stack.Push(num);
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = map.GetValueOrDefault(nums1[i], -1);
            }

            return nums1;
        }

        public static int[] NextSmallerElement(int[] nums1, int[] nums2)
        {
            Stack<int> stack = new();
            Dictionary<int, int> map = new();
            foreach (int num in nums2)
            {
                while (stack.Count > 0 && stack.Peek() > num)
                {
                    map.Add(stack.Pop(), num);
                }
                stack.Push(num);
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = map.GetValueOrDefault(nums1[i], -1);
            }

            return nums1;
        }

        public static int[] NextGreaterElementOneArray(int[] nums)
        {
            Stack<int> stack = new();
            int[] array = new int[nums.Length];
            Array.Fill(array, -1);
            for (int i = 0; i < nums.Length; i++)
            {
                while (stack.Count > 0 && nums[stack.Peek()] < nums[i])
                {
                    array[stack.Pop()] = nums[i];
                }
                stack.Push(i);
            }

            return array;
        }

        public static int[] NextSmallerElementOneArray(int[] nums)
        {
            Stack<int> stack = new();
            int[] array = new int[nums.Length];
            Array.Fill(array, -1);
            for (int i = 0; i < nums.Length; i++)
            {
                while (stack.Count > 0 && nums[stack.Peek()] > nums[i])
                {
                    array[stack.Pop()] = nums[i];
                }
                stack.Push(i);
            }

            return array;
        }
    }
}
