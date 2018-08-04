using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode11_15
{
    [TestClass]
    public class LeetCode11_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            LeetCode11 leetCode11 = new LeetCode11();
            int[] height = new int[15000];
            int count = 15000;
            for (var i = 0; i < count; i++)
            {
                height[i] = count - i;
            }

            Console.WriteLine(leetCode11.MaxArea(height));
        }

        [TestMethod]
        public void TestMethod2()
        {
            LeetCode11 leetCode11 = new LeetCode11();
            int[] height = new int[15000];
            int count = 15000;
            for (var i = 0; i < count; i++)
            {
                height[i] = count - i;
            }

            Console.WriteLine(leetCode11.MaxArea2(height));
        }
    }
}
