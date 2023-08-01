namespace LeetCodeExcercises
{
    public static class PascalsTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            int[][] arrayList = new int[numRows][];
            if (numRows == 0) return arrayList;
            arrayList[0] = new int[] { 1 };
            if (numRows == 1) return arrayList;
            arrayList[1] = new int[] { 1, 1 };
            if (numRows == 2) return arrayList;

            for (int i = 2; i < numRows; i++)
            {
                int[] array = new int[i + 1];
                array[0] = 1;

                for (int j = 1; j < i; j++)
                {
                    array[j] = arrayList[i - 1][j - 1] + arrayList[i - 1][j];
                }

                array[i - 1] = 1;
                arrayList[i] = array;
            }

            return arrayList;
        }
    }
}
