namespace LeetCodeExcercises
{
    public static class ValidParenthesis
    {
        public static bool IsValid(string s)
        {
            if (s.Length % 2 == 1) return false;
            if (s[0] == ')' || s[0] == '}' || s[0] == ']') return false;

            var stack = new Stack<char>();

            foreach (var ch in s)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                    stack.Push(ch);
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count <= 0) return false;
                    var lastCh = stack.Peek();

                    if ((ch == ')' && lastCh == '(') ||
                        (ch == ']' && lastCh == '[') ||
                        (ch == '}' && lastCh == '{'))
                        stack.Pop();
                    else
                        return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
