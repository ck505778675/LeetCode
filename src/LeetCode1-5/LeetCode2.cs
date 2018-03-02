using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode1_5
{
    public class LeetCode2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var newNode = new ListNode((l1.val + l2.val) % 10);
            var node = newNode;
            var temp = (l1.val + l2.val) / 10 > 0 ? 1 : 0;
            while (l1.next != null || l2.next != null || temp>0)
            {
                l1 = l1.next ?? new ListNode(0);
                l2 = l2.next ?? new ListNode(0);
                node.next = new ListNode((l1.val + l2.val + temp) % 10);
                node = node.next;
                temp = (l1.val + l2.val + temp) / 10 > 0 ? 1 : 0;

            }
           
            return newNode;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
