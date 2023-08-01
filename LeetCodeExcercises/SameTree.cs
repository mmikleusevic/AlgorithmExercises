namespace LeetCodeExcercises
{
    public static class SameTree
    {
        //BFS

        //public static bool IsSameTree(TreeNode p, TreeNode q)
        //{
        //    if(p == null && q == null) return true;
        //    if (p != null && q == null || p == null && q != null) return false;

        //    Queue<TreeNode> q1 = new();
        //    Queue<TreeNode> q2 = new();

        //    q1.Enqueue(p);
        //    q2.Enqueue(q);
        //    while (q1.Count != 0 && q2.Count != 0)
        //    {
        //        TreeNode left = q1.Dequeue();
        //        TreeNode right = q2.Dequeue();

        //        if (left.left != null && right.left == null
        //            || left.left == null && right.left != null
        //            || right.right != null && left.right == null
        //            || right.right == null && left.right != null
        //            || left.val != right.val) return false;

        //        if(left.left != null) q1.Enqueue(left.left);
        //        if (right.left != null) q2.Enqueue(right.left);
        //        if (left.right != null) q1.Enqueue(left.right);
        //        if (right.right != null) q2.Enqueue(right.right);
        //    }
        //    return true;
        //}

        //Moje DFS rekurzivno rješenje

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null || p.val != q.val) return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
