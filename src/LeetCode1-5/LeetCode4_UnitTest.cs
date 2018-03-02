using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode1_5
{
    [TestClass]
    public class LeetCode4_UnitTest
    {
        [TestMethod]
        public void LeetCode4_UnitTest_Method1()
        {
            int[] num1 = new int[] { 1, 2, 3, 3, 4, 5 };
            int[] num2 = new int[] { 2, 2, 2, 3, 4, 5, 5 };
            LeetCode4 leetCode4 = new LeetCode4();
            Console.WriteLine(leetCode4.FindMedianSortedArrays(num1, num2));
        }

        [TestMethod]
        public void LeetCode4_UnitTest_Method2()
        {
            int[] num1 = new int[] { 1, 2, 3, 3, 4, 5 };
            int[] num2 = new int[] { 2, 2, 2, 3, 4, 5, 5 };
            LeetCode4 leetCode4 = new LeetCode4();
            Console.WriteLine(leetCode4.FindMedianSortedArrays2(num1, num2));
        }

        [TestMethod]
        public void LeetCode4_UnitTest_Method3()
        {
            int[] num1 = new int[] { 1, 2, 3, 3, 4, 5 };
            int[] num2 = new int[] { 2, 2, 2, 3, 4, 5, 5 };
            LeetCode4 leetCode4 = new LeetCode4();
            Console.WriteLine(leetCode4.FindMedianSortedArrays3(num1, num2));
        }
    }
}
