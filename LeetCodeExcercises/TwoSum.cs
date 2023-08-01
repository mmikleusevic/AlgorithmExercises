namespace LeetCodeExcercises
{
    public static class TwoSum
    {
        public static int[] TwoSumOptimized(int[] nums, int target)
        {
            int arrayLength = nums.Length;
            Dictionary<int, int> resultDictionary = new();

            int firstNumber;
            int secondNumber;
            for (int i = 0; i < arrayLength; i++)
            {
                firstNumber = nums[i];
                secondNumber = target - firstNumber;

                if (resultDictionary.TryGetValue(secondNumber, out int index))
                {
                    return new[] { index, i };
                }

                resultDictionary.TryAdd(firstNumber, i);
                //resultDictionary[firstNumber] = i;
            }
            return null;
        }
    }
}
