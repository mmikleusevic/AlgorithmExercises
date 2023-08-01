namespace LeetCodeExcercises
{
    public static class BinaryTreeInOrderTraversal
    {
        //Iterative

        public static IList<int> InorderTraversal(TreeNode root)
        {
            List<int> list = new();

            if (root == null) return list;

            Stack<TreeNode> stack = new();

            TreeNode cur = root;

            while (cur != null || stack.Count > 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();
                list.Add(cur.val);
                cur = cur.right;
            }

            return list;

        }

        //Recursion

        //public static IList<int> InorderTraversal(TreeNode root)
        //{
        //    List<int> list = new();

        //    if (root == null) return list;

        //    InOrder(root, list);
        //    return list;
        //}

        //public static void InOrder(TreeNode root, IList<int> list)
        //{
        //    if (root == null) return;

        //    InOrder(root.left, list);
        //    list.Add(root.val);
        //    InOrder(root.right, list);
        //}
    }
}
