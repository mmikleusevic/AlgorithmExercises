namespace LeetCodeExcercises
{
    public static class SortList
    {
        public static ListNode SortListMethod(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode slow = head;
            ListNode fast = head;
            ListNode prev = null;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            prev.next = null;

            var left = SortListMethod(head);
            var right = SortListMethod(slow);

            return Merge(left, right);
        }

        public static ListNode Merge(ListNode l1, ListNode l2)
        {
            ListNode root = new ListNode(-1);
            ListNode cur = root;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    cur.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    cur.next = l2;
                    l2 = l2.next;
                }
                cur = cur.next;
            }
            cur.next = l1 == null ? l2 : l1;

            return root.next;
        }
    }
}
