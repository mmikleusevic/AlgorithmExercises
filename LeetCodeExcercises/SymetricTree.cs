namespace LeetCodeExcercises
{
    public static class SymetricTree
    {
        public static bool IsSymmetric(TreeNode root)
        {
            // Recursive

            return IsSymetrical(root.left, root.right);

            // Iterative

            //if (root == null) return true;

            //TreeNode left = root.left;
            //TreeNode right = root.right;
            //Stack<TreeNode> stackLeft = new();
            //Stack<TreeNode> stackRight = new();

            //while (left != null || right != null || stackLeft.Count > 0 || stackRight.Count > 0)
            //{
            //    while (left != null || right != null)
            //    {
            //        if (left == null && right != null || right == null && left != null || left.val != right.val)
            //        {
            //            return false;
            //        }
            //        stackLeft.Push(left);
            //        stackRight.Push(right);
            //        left = left.left;
            //        right = right.right;
            //    }
            //    left = stackLeft.Pop();
            //    right = stackRight.Pop();
            //    left = left.right;
            //    right = right.left;
            //}

            //return true;
        }

        //RecursivePart
        public static bool IsSymetrical(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (right == null || left == null || left.val != right.val) return false;

            return IsSymetrical(left.left, right.right) &&
                   IsSymetrical(left.right, right.left);
        }
    }
}
