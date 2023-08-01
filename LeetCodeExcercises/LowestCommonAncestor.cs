namespace LeetCodeExcercises
{
    public static class LowestCommonAncestor
    {
        public static TreeNode LowestCommonAncestorMethod(TreeNode root, TreeNode p, TreeNode q)
        {
            TreeNode cur = root;

            while (cur != null)
            {
                if (p.val > cur.val && q.val > cur.val)
                {
                    cur = cur.right;
                }
                else if (p.val < cur.val && q.val < cur.val)
                {
                    cur = cur.left;
                }
                else
                {
                    return cur;
                }
            }
            return cur;
        }
    }
}
