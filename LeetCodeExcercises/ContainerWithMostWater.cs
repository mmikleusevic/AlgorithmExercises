namespace LeetCodeExcercises
{
    public static class ContainerWithMostWater
    {
        public static int MaxArea(int[] height)
        {
            int length = height.Length;

            int left = 0;
            int right = length - 1;
            int result = 0;

            while (left < right)
            {
                int area = Math.Min(height[left], height[right]) * (right - left);
                result = Math.Max(result, area);

                if (height[left] <= height[right])
                {
                    var temp = height[left];
                    left++;
                    while (left < right && height[left] <= temp)
                    {
                        left++;
                    }
                }
                else
                {
                    var temp = height[right];
                    right--;
                    while (left < right && height[right] <= temp)
                    {
                        right--;
                    }
                }
            }
            return result;
        }
    }
}
