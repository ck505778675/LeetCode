using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode1_5
{
    [TestClass]
    public class LeetCode2_UntiTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ListNode l1 = new ListNode(2) { next = new ListNode(4) { next = new ListNode(3) { next = new ListNode(9) } } };
            ListNode l2 = new ListNode(8) { next = new ListNode(5) { next = new ListNode(6) } };
            LeetCode2 leetCode2 = new LeetCode2();
            ListNode resultNode = leetCode2.AddTwoNumbers(l1, l2);
            while (resultNode != null)
            {
                Console.WriteLine(resultNode.val);
                resultNode = resultNode.next;
            }

        }
    }
}
