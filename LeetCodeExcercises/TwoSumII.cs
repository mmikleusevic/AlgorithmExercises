namespace LeetCodeExcercises
{
    public static class TwoSumII
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            //bolje rješenje
            int l = 0;
            int r = numbers.Length - 1;
            while (r >= 0 && l < numbers.Length)
            {
                if (numbers[l] + numbers[r] > target) r--;
                else if (numbers[l] + numbers[r] < target) l++;
                else return new int[] { l + 1, r + 1 };
            }

            return new int[0];

            // Moje rješenje

            //Dictionary<int, int> map = new();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int firstNumber = numbers[i];
            //    int secondNumber = target - firstNumber;

            //    if (map.TryGetValue(secondNumber, out int index))
            //    {
            //        return new int[] { index + 1, i + 1 };
            //    };

            //    if (!map.ContainsKey(firstNumber))
            //    {
            //        map[firstNumber] = i;
            //    }
            //}
            //return new int[0];
        }
    }
}
