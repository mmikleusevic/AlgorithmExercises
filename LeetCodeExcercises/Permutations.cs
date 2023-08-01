namespace LeetCodeExcercises
{
    public static class Permutations
    {
        public static IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>() { nums };

            int length = nums.Length;
            int size;
            int temp;
            IList<int> tempList;
            for (int i = 0; i < length; i++)
            {
                size = result.Count;
                for (int j = 0; j < size; j++)
                {
                    for (int k = i + 1; k < length; k++)
                    {
                        tempList = new List<int>(result[j]);
                        temp = tempList[k];
                        tempList[k] = tempList[i];
                        tempList[i] = temp;
                        result.Add(tempList);
                    }
                }
            }

            return result;

            //Lošije rješenje za c#

            //List<IList<int>> result = new();

            //if(nums.Length == 1)
            //{
            //    result.Add(nums);
            //    return result;
            //}

            //for(int i = 0; i < nums.Length; i++)
            //{
            //    int n = nums[i];
            //    var array = nums.Where(a => a != nums[i]).ToArray();

            //    var perms = Permute(array);

            //    foreach(var p in perms)
            //    {
            //        List<int> list = new List<int>();
            //        list.AddRange(p);
            //        list.Add(n);
            //        result.Add(list);
            //    }
            //    nums = array.Prepend(n).ToArray();
            //}

            //return result;
        }
    }
}
