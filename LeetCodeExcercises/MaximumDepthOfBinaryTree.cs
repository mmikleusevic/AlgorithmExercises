namespace LeetCodeExcercises
{
    public static class MaximumDepthOfBinaryTree
    {
        // Recursion DFS
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;

            return Math.Max(1 + MaxDepth(root.left), 1 + MaxDepth(root.right));
        }

        // BFS
        //public static int MaxDepth(TreeNode root)
        //{
        //    if (root == null) return 0;

        //    int level = 0;

        //    Queue<TreeNode> queue = new();
        //    queue.Enqueue(root);

        //    while (queue.Count != 0)
        //    {
        //        int size = queue.Count;
        //        for (int i = 0; i < size; i++)
        //        {
        //            TreeNode node = queue.Dequeue();
        //            if (node.left != null)
        //            {
        //                queue.Enqueue(node.left);
        //            }
        //            if (node.right != null)
        //            {
        //                queue.Enqueue(node.right);
        //            }
        //        }
        //        level++;
        //    }
        //    return level;
        //}


        // Iterative eh solution
        //public static int MaxDepth(TreeNode root)
        //{
        //    int level = 0;
        //    Dictionary<TreeNode, int> stack = new()
        //    {
        //        {root, 1}
        //    };

        //    while (stack.Count != 0)
        //    {
        //        TreeNode node = stack.FirstOrDefault().Key;
        //        stack.Remove(node, out int depth);

        //        if (node != null)
        //        {
        //            level = Math.Max(level, depth);
        //            if (node.left != null) stack.Add(node.left, depth + 1);
        //            if (node.right != null) stack.Add(node.right, depth + 1);
        //        }
        //    }
        //    return level;
        //}
    }
}
