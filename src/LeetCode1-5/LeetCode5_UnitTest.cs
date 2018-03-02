using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode1_5
{
    [TestClass]
    public class LeetCode5_UnitTest
    {
        [TestMethod]
        public void LeetCode5_UnitTest_Method1()
        {
            LeetCode5 leetCode5 = new LeetCode5();
            Console.WriteLine(leetCode5.LongestPalindrome("babad"));
            Console.WriteLine(leetCode5.LongestPalindrome("cbbd"));
        }
    }
}
