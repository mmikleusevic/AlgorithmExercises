namespace LeetCodeExcercises
{
    public static class DeleteNodeInALinkedList
    {
        public static void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
