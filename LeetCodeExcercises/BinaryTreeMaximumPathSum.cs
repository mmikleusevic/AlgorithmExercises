namespace LeetCodeExcercises
{
    public static class BinaryTreeMaximumPathSum
    {
        private static int res;
        public static int MaxPathSum(TreeNode root)
        {
            res = root.val;

            DFS(root);

            return res;
        }

        private static int DFS(TreeNode root)
        {
            if (root == null) return 0;

            int leftMax = DFS(root.left);
            int rightMax = DFS(root.right);
            leftMax = Math.Max(leftMax, 0);
            rightMax = Math.Max(rightMax, 0);

            res = Math.Max(res, root.val + leftMax + rightMax);

            return root.val + Math.Max(leftMax, rightMax);
        }
    }
}
