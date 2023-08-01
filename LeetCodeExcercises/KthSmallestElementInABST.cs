namespace LeetCodeExcercises
{
    public static class KthSmallestElementInABST
    {
        public static int KthSmallest(TreeNode root, int k)
        {
            if (root == null) return 0;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode cur = root;

            while (cur != null || stack.Count > 0)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                k--;
                cur = stack.Pop();
                if (k == 0) return cur.val;
                cur = cur.right;
            }
            return 0;
        }

        //Moje ok rješenje

        //public static int KthSmallest(TreeNode root, int k)
        //{
        //    List<int> list = new();

        //    Traverse(root, list, k);

        //    return list[k - 1];
        //}

        //public static void Traverse(TreeNode root, List<int> list, int k)
        //{
        //    if (list.Count >= k) return;
        //    if (root == null) return;

        //    Traverse(root.left, list, k);
        //    list.Add(root.val);
        //    Traverse(root.right, list, k);
        //}
    }
}
