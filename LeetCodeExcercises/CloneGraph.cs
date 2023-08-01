namespace LeetCodeExcercises
{
    public static class CloneGraph
    {
        public static Node CloneGraphMethod(Node node)
        {
            Dictionary<int, Node> mapNode = new();

            return CloneGraphMethod(node, mapNode);
        }

        private static Node CloneGraphMethod(Node node, Dictionary<int, Node> mapNode)
        {
            if (node == null) return null;
            if (mapNode.ContainsKey(node.val))
            {
                return mapNode[node.val];
            }

            Node copy = new Node(node.val);
            mapNode[node.val] = copy;

            foreach (Node old in node.neighbors)
            {
                copy.neighbors.Add(CloneGraphMethod(old, mapNode));
            }

            return copy;
        }
    }

    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, IList<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }
}
