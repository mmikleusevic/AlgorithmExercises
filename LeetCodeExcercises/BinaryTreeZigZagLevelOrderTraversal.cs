namespace LeetCodeExcercises
{
    public static class BinaryTreeZigZagLevelOrderTraversal
    {
        public static IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> result = new();

            Queue<TreeNode> q = new();
            q.Enqueue(root);
            bool leftToRight = true;

            while (q.Count > 0)
            {
                int size = q.Count;
                int[] array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = q.Dequeue();
                    array[leftToRight ? i : size - i - 1] = node.val;
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                }
                leftToRight = !leftToRight;
                result.Add(array);
            }
            return result;
        }
    }
}
