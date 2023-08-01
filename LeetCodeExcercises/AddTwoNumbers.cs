namespace LeetCodeExcercises
{
    public static class AddTwoNumbers
    {
        public static ListNode AddTwoNumbersMethod(ListNode l1, ListNode l2)
        {
            ListNode dummy = new();
            ListNode cur = dummy;

            int carry = 0;
            while (l1 != null || l2 != null || carry != 0)
            {
                int v1 = l1 != null ? l1.val : 0;
                int v2 = l2 != null ? l2.val : 0;

                int val = v1 + v2 + carry;
                carry = val / 10;
                val = val % 10;
                cur.next = new ListNode(val);

                cur = cur.next;
                l1 = l1 != null ? l1.next : null;
                l2 = l2 != null ? l2.next : null;
            }
            return dummy.next;
        }
        //Moje lose rješenje zbog edgecaseva
        //public static ListNode AddTwoNumbersMethod(ListNode l1, ListNode l2)
        //{
        //    List<int> list1 = new();
        //    List<int> list2 = new();

        //    while (l1 != null)
        //    {
        //        list1.Add(l1.val);
        //        l1 = l1.next;
        //    }

        //    while (l2 != null)
        //    {
        //        list2.Add(l2.val);
        //        l2 = l2.next;
        //    }

        //    long result = 0;
        //    for (int i = list1.Count - 1; i >= 0; i--)
        //    {
        //        result += list1[i] * (long)Math.Pow(10, i);
        //    }

        //    for (int i = list2.Count - 1; i >= 0; i--)
        //    {
        //        result += list2[i] * (long)Math.Pow(10, i);
        //    }

        //    ListNode newNode = new();
        //    ListNode resultNode = newNode;
        //    double value = 0;
        //    while (result != 0)
        //    {
        //        value = result % 10;
        //        newNode.val = (int)value;
        //        result = result / 10;
        //        if (result != 0)
        //        {
        //            newNode.next = new ListNode();
        //            newNode = newNode.next;
        //        }
        //    }
        //    return resultNode;
        //}
    }
}
