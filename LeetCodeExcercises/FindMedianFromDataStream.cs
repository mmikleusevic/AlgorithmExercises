namespace LeetCodeExcercises
{
    public class FindMedianFromDataStream
    {
        private PriorityQueue<int, int> small;
        private PriorityQueue<int, int> large;
        public FindMedianFromDataStream()
        {
            small = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            large = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => x - y));
        }

        public void AddNum(int num)
        {
            small.Enqueue(num, num);

            if (small.Count > 0 && large.Count > 0 && small.Peek() > large.Peek())
            {
                int val = small.Dequeue();
                large.Enqueue(val, val);
            }

            if (small.Count > large.Count + 1)
            {
                int val = small.Dequeue();
                large.Enqueue(val, val);
            }

            if (large.Count > small.Count + 1)
            {
                int val = large.Dequeue();
                small.Enqueue(val, val);
            }
        }

        public double FindMedian()
        {
            if (small.Count > large.Count)
            {
                return small.Peek();
            }
            if (large.Count > small.Count)
            {
                return large.Peek();
            }

            int val1 = small.Peek();
            int val2 = large.Peek();
            double res = (double)(val1 + val2) / 2;

            return res;
        }
    }
}
