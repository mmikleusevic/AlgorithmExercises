﻿namespace LeetCodeExcercises
{
    public static class RemoveNthNodeFromEndOfList
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(-1, head);
            ListNode left = dummy;
            ListNode right = head;

            while (n > 0 && right != null)
            {
                right = right.next;
                n -= 1;
            }

            while (right != null)
            {
                left = left.next;
                right = right.next;
            }

            left.next = left.next.next;

            return dummy.next;
        }
    }
}
