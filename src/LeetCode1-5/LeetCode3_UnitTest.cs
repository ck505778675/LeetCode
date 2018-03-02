using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode1_5
{
    [TestClass]
    public class LeetCode3_UnitTest
    {
        [TestMethod]
        public void LeetCode3_UnitTest_TestMethod1()
        {
            LeetCode3 leetCode3 = new LeetCode3();
            Console.WriteLine(leetCode3.LengthOfLongestSubstring("abcabcbb"));
            Console.WriteLine(leetCode3.LengthOfLongestSubstring("bbbbbb"));
            Console.WriteLine(leetCode3.LengthOfLongestSubstring("pwwkew"));
            Console.WriteLine(leetCode3.LengthOfLongestSubstring("dvdf"));

        }
        [TestMethod]
        public void LeetCode3_UnitTest_TestMethod2()
        {
            LeetCode3 leetCode3 = new LeetCode3();
            Console.WriteLine(leetCode3.LengthOfLongestSubstring2("abcabcbb"));
            Console.WriteLine(leetCode3.LengthOfLongestSubstring2("bbbbbb"));
            Console.WriteLine(leetCode3.LengthOfLongestSubstring2("pwwkew"));
            Console.WriteLine(leetCode3.LengthOfLongestSubstring2("dvdf"));

        }


    }
}
