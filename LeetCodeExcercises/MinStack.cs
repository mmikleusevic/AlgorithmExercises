namespace LeetCodeExcercises
{
    public class MinStack
    {
        private MinNode head;

        public MinStack()
        {
            head = null;
        }

        public void Push(int x)
        {
            if (head == null)
                head = new MinNode(x, x);
            else
                head = new MinNode(x, Math.Min(x, head.MinValue), head);
        }

        public void Pop()
        {
            head = head.Next;
        }

        public int Top()
        {
            return head.Value;
        }

        public int GetMin()
        {
            return head.MinValue;
        }

        private class MinNode
        {
            public MinNode(int value, int minValue, MinNode next = null)
            {
                Value = value;
                MinValue = minValue;
                Next = next;
            }


            public int Value { get; set; }
            public int MinValue { get; set; }
            public MinNode Next { get; set; }
        }
    }
}
