namespace LeetCodeExcercises
{
    public static class DetectACycleInALinkedList
    {
        public static bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;

            ListNode slow = head, fast = head.next;
            while (slow != fast)
            {
                if (fast == null || fast.next == null) return false;
                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }
    }
}
