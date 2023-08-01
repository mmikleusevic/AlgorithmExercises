namespace LeetCodeExcercises
{
    public static class EvaluateReversePolishNotation
    {
        public static int EvalRPN(string[] tokens)
        {
            Stack<int> numbers = new();
            int result = 0;
            for (int i = 0; i < tokens.Length; i++)
            {
                bool parsedNum = int.TryParse(tokens[i], out int res);
                if (parsedNum)
                {
                    numbers.Push(res);
                }
                if (numbers.Count >= 2 && !parsedNum)
                {
                    int num1 = numbers.Pop();
                    int num2 = numbers.Pop();
                    if (tokens[i] == "+")
                    {
                        result = num2 + num1;
                    }
                    else if (tokens[i] == "-")
                    {
                        result = num2 - num1;
                    }
                    else if (tokens[i] == "*")
                    {
                        result = num2 * num1;
                    }
                    else
                    {
                        result = num2 / num1;
                    }
                    numbers.Push(result);
                    result = 0;
                }
            }
            return numbers.Pop();
        }
    }
}
