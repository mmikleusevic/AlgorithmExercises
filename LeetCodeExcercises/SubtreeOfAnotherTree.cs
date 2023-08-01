namespace LeetCodeExcercises
{
    public static class SubtreeOfAnotherTree
    {
        public static bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (subRoot == null) return true;
            if (root == null) return false;

            return Equal(root, subRoot) || IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }

        public static bool Equal(TreeNode root, TreeNode subRoot)
        {
            if (root == null && subRoot == null) return true;
            if (root == null || subRoot == null) return false;

            return root.val == subRoot.val && Equal(root.left, subRoot.left) && Equal(root.right, subRoot.right);
        }
    }
}
