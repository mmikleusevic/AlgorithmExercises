namespace LeetCodeExcercises
{
    public class ThisNode
    {
        public ThisNode left;
        public ThisNode right;
        public ThisNode next;
        public int val;

        public ThisNode(int val = 0, ThisNode left = null, ThisNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public static class PopulatingNextRightPointersInEachNode
    {
        public static ThisNode Connect(ThisNode root)
        {
            if (root == null) return null;

            ThisNode start = root;

            while (start != null)
            {
                ThisNode cur = start;
                while (cur != null)
                {
                    if (cur.left != null) cur.left.next = cur.right;
                    if (cur.right != null && cur.next != null) cur.right.next = cur.next.left;

                    cur = cur.next;
                }
                start = start.left;
            }

            return root;
        }

        //public static ThisNode Connect(ThisNode root)
        //{
        //BFS ok rješenje
        //if (root == null) return null;

        //Queue<ThisNode> q = new();
        //q.Enqueue(root);

        //while (q.Count > 0)
        //{
        //    int size = q.Count;
        //    for (int i = 0; i < size; i++)
        //    {
        //        ThisNode node = q.Dequeue();
        //        if (i == size - 1)
        //        {
        //            node.next = null;
        //        }
        //        else
        //        {
        //            node.next = q.Peek();
        //        }
        //        if (node.left != null) q.Enqueue(node.left);
        //        if (node.right != null) q.Enqueue(node.right);
        //    }
        //}

        //return root;
        //}
    }
}
