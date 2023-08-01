namespace LeetCodeExcercises
{
    public class FlattenNestedListIterator
    {
        private Stack<NestedInteger> stack;

        public FlattenNestedListIterator(IList<NestedInteger> nestedList)
        {
            this.stack = new Stack<NestedInteger>();
            for (int i = nestedList.Count - 1; i >= 0; i--)
                stack.Push(nestedList[i]);
        }

        public bool HasNext()
        {
            while (stack.Count > 0 && !stack.Peek().IsInteger())
            {
                var ni = stack.Pop();
                var list = ni.GetList();
                for (int i = list.Count - 1; i >= 0; i--)
                    stack.Push(list[i]);
            }

            return stack.Count > 0;
        }

        public int Next()
        {
            if (!HasNext()) throw new IndexOutOfRangeException();
            return stack.Pop().GetInteger();
        }


        public class NestedInteger
        {
            private int? number;
            private IList<NestedInteger> list;


            // Constructor initializes an empty nested list.
            public NestedInteger()
            {
                number = null;
                list = new List<NestedInteger>();
            }

            // Constructor initializes a single integer.
            public NestedInteger(int value)
            {
                number = value;
                list = new List<NestedInteger>();
            }


            // @return true if this NestedInteger holds a single integer, rather than a nested list.
            public bool IsInteger()
            {
                return number.HasValue;
            }

            // @return the single integer that this NestedInteger holds, if it holds a single integer
            // Return null if this NestedInteger holds a nested list
            public int GetInteger()
            {
                return number.Value;
            }

            // Set this NestedInteger to hold a single integer.
            public void SetInteger(int value)
            {
                number = value;
                list = null;
            }

            // Set this NestedInteger to hold a nested list and adds a nested integer to it.
            public void Add(NestedInteger ni)
            {
                number = null;
                if (list == null)
                    list = new List<NestedInteger>() { ni };
                else
                    list.Add(ni);
            }

            // @return the nested list that this NestedInteger holds, if it holds a nested list
            // Return null if this NestedInteger holds a single integer
            public IList<NestedInteger> GetList()
            {
                return list;
            }
        }
    }
}
