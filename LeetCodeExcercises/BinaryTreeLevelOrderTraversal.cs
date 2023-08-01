namespace LeetCodeExcercises
{
    public static class BinaryTreeLevelOrderTraversal
    {

        //BFS
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            Queue<TreeNode> q = new();
            List<IList<int>> list = new();

            q.Enqueue(root);
            while (q.Count > 0)
            {
                List<int> result = new();
                int size = q.Count;

                for (int i = 0; i < size; i++)
                {
                    TreeNode node = q.Dequeue();
                    result.Add(node.val);

                    if (node.left != null) q.Enqueue(node.left);
                    if (node.right != null) q.Enqueue(node.right);
                }
                list.Add(result);
            }
            return list;
        }

        //Rekurzivno DFS moje

        //public static IList<IList<int>> LevelOrder(TreeNode root)
        //{
        //    Dictionary<int, IList<int>> map = new();

        //    Traverse(map, root, 1);
        //    return map.Values.ToList();
        //}

        //public static void Traverse(Dictionary<int, IList<int>> map, TreeNode root, int key)
        //{
        //    if (root == null) return;

        //    if (!map.ContainsKey(key))
        //    {
        //        map.Add(key, new List<int>());
        //    }

        //    map[key].Add(root.val);
        //    key++;

        //    Traverse(map, root.left, key);
        //    Traverse(map, root.right, key);
        //}
    }
}
