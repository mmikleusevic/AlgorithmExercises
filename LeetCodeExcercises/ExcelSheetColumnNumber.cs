namespace LeetCodeExcercises
{
    public static class ExcelSheetColumnNumber
    {
        public static int TitleToNumber(string columnTitle)
        {
            int result = 0;
            foreach (char c in columnTitle)
            {
                int d = c - 'A' + 1;
                result = result * 26 + d;
            }
            return result;
        }
    }
}
