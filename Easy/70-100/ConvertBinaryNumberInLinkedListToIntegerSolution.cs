using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeSolutions.Easy._70_100
{
    /// <summary>
    /// Submission result
    //  ID    | Runtime  |  Memory   | % beats runtime | % beats memory
    //--------|----------|-----------|-----------------|----------------
    //  1290  | 84 ms    |  24.5 MB  | 94.17           | 93.06
    /// </summary>
    class ConvertBinaryNumberInLinkedListToIntegerSolution
    {
        //Definition for singly-linked list.
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public static int GetDecimalValue(ListNode head)
        {
            int count = 1;
            ListNode node = head.next;
            while (node != null)
            {
                count++;
                node = node.next;
            }
            int res = 0;
            node = head;
            for (int i = count - 1; i >= 0; i--)
            {
                res += node.val * (int)Math.Pow(2, i);
                node = node.next;
            }
            return res;
        }

    }
}
