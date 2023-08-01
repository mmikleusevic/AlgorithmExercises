namespace LeetCodeExcercises
{
    public static class ValidateBinarySearchTree
    {
        public static bool IsValidBST(TreeNode root)
        {
            return IsValidBST_DFS(root, (long)int.MinValue - 1, (long)int.MaxValue + 1);
        }

        public static bool IsValidBST_DFS(TreeNode current, long low, long high)
        {
            if (current == null) return true;
            if (current.val <= low || current.val >= high) return false;

            return IsValidBST_DFS(current.left, low, current.val) && IsValidBST_DFS(current.right, current.val, high);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
