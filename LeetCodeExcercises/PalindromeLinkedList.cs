namespace LeetCodeExcercises
{
    public static class PalindromeLinkedList
    {
        public static bool IsPalindrome(ListNode head)
        {
            // Array Solution

            //List<int> list = new();
            //while(head != null)
            //{
            //    list.Add(head.val);    
            //    head = head.next;
            //}
            //int left = 0;
            //int right = list.Count-1;

            //while(left < right)
            //{
            //    if (list[left] != list[right]) return false;
            //    left++;
            //    right--;
            //}

            //return true;

            //Fast - Slow

            ListNode fast = head;
            ListNode slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            ListNode prev = null;
            while (slow != null)
            {
                ListNode temp = slow.next;
                slow.next = prev;
                prev = slow;
                slow = temp;
            }

            ListNode left = head;
            ListNode right = prev;

            while (right != null)
            {
                if (left.val != right.val) return false;
                left = left.next;
                right = right.next;
            }

            return true;
        }
    }
}
