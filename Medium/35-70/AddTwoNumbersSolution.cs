using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Medium._35_70
{
    /// <summary>
    /// Algorithm results
    //  Runtime  |  Memory   | % best runtime | % best memory
    //  104 ms   |  25.7 MB  | 11             | 99.81
    /// </summary>
    class AddTwoNumbersSolution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }   

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result;
            int num = l1.val + l2.val;
            if (num < 10)
            {
                result = new ListNode(num);
                CreateNew(l1.next, l2.next, result, 0);
            }
            else
            {
                result = new ListNode(num % 10);
                CreateNew(l1.next, l2.next, result, 1);
            }
            return result;
        }
        private static void CreateNew(ListNode l1, ListNode l2, ListNode res, int plus)
        {
            if (l1 != null || l2 != null || plus > 0)
            {
                var sum = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + plus;
                if (sum < 10)
                {
                    res.next = new ListNode(sum);
                    CreateNew(l1?.next, l2?.next, res.next, 0);
                }
                else
                {
                    res.next = new ListNode(sum % 10);
                    CreateNew(l1?.next, l2?.next, res.next, 1);
                }
            }
        }
    }
}
