namespace LeetCodeExcercises
{
    public static class SerializeAndDeserializeBinaryTree
    {

        public static int i = 0;
        public static string serialize(TreeNode root)
        {
            List<string> res = new();
            DFS(root, res);

            string deserializeString = string.Join(",", res);

            //Ovo treba samo ovdje jer na leetcodeu se samo poziva(serialize(deserialize(string...
            deserialize(deserializeString);

            return deserializeString;
        }

        public static void DFS(TreeNode root, List<string> res)
        {
            if (root == null)
            {
                res.Add("N");
                return;
            }
            else
            {
                res.Add(root.val.ToString());
            }
            DFS(root.left, res);
            DFS(root.right, res);
        }

        // Decodes your encoded data to tree.
        public static TreeNode deserialize(string data)
        {
            string[] vals = data.Split(',');
            TreeNode root = DFS(vals);
            return root;
        }

        public static TreeNode DFS(string[] vals)
        {
            if (vals[i] == "N")
            {
                i++;
                return null;
            }

            TreeNode res = new TreeNode(int.Parse(vals[i]));
            i++;
            res.left = DFS(vals);
            res.right = DFS(vals);

            return res;
        }

        //BFS nepotpuno

        //public static string serialize(TreeNode root)
        //{
        //    StringBuilder result = new();

        //    if (root == null) return result.ToString();

        //    Queue<TreeNode> q = new();
        //    q.Enqueue(root);
        //    while (q.Count > 0)
        //    {
        //        int size = q.Count;

        //        for (int i = 0; i < size; i++)
        //        {
        //            TreeNode node = q.Dequeue();
        //            if(node == null) result.Append("null,");
        //            else result.Append(node.val.ToString() + ',');
        //            if(node != null)
        //            {
        //                q.Enqueue(node.left);
        //                q.Enqueue(node.right);
        //            }
        //        }
        //    }
        //    while(result.ToString().LastOrDefault() < '0' || result.ToString().LastOrDefault() > '9')
        //    {
        //        result.Remove(result.ToString().LastIndexOf(result.ToString().LastOrDefault()), 1);
        //    }

        //    deserialize(result.ToString());

        //    return result.ToString();
        //}

        // Decodes your encoded data to tree.
        //public static TreeNode deserialize(string data)
        //{
        //    string[] smth = data.Split(','); 

        //    TreeNode node = new TreeNode();
        //    int.TryParse(smth[0], out node.val);

        //    for(int i = 1; i<smth.Length; i++)
        //    {
        //        Parse(smth[i], smth[i++], node);
        //    }

        //    return node;
        //}
    }
}
