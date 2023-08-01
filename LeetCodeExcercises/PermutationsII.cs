namespace LeetCodeExcercises
{
    public static class PermutationsII
    {
        public static IList<IList<int>> PermuteUnique(int[] nums)
        {
            var result = new List<IList<int>>() { nums };

            int length = nums.Length;
            int size;
            int temp;
            int[] tempArray;
            IList<int> tempList;

            for (int i = 0; i < length; i++)
            {
                size = result.Count;
                for (int j = 0; j < size; j++)
                {
                    tempArray = result[j].ToArray();
                    Array.Sort(tempArray, i, length - i);
                    result[j] = tempArray;
                    for (int k = i + 1; k < length; k++)
                    {
                        if (result[j][k] == result[j][k - 1] ||
                            result[j][k] == result[j][i])
                        { continue; }
                        tempList = new List<int>(result[j]);

                        temp = tempList[k];
                        tempList[k] = tempList[i];
                        tempList[i] = temp;
                        result.Add(tempList);
                    }
                }
            }

            return result;
        }
    }
}
