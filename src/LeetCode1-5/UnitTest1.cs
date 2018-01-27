using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace LeetCode1_5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod0()
        {
            int[] nums = new int[10000000];
            Random rd = new Random();
            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = rd.Next(1, 31);
            }
            Stopwatch sw = new Stopwatch();
            LeetCode1 leetCode1 = new LeetCode1();

            sw.Start();
            foreach (var num in leetCode1.TwoSum(nums, 59))
            {
                Console.WriteLine($"{num}:{nums[num]}");
            }
            sw.Stop();
            Console.WriteLine($"方法一使用时间(ms)为:{sw.ElapsedMilliseconds}");

            sw.Restart();
            foreach (var num in leetCode1.TwoSum2(nums, 59))
            {
                Console.WriteLine($"{num}:{nums[num]}");
            }
            sw.Stop();
            Console.WriteLine($"方法二使用时间(ms)为:{sw.ElapsedMilliseconds}");
        }


        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = new int[100000];
            Random rd = new Random();
            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = rd.Next(1, 31);
            }
            
            LeetCode1 leetCode1 = new LeetCode1();
            

            foreach (var num in leetCode1.TwoSum(nums, 59))
            {
                Console.WriteLine($"{num}:{nums[num]}");
            }


        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] nums = new int[100000];
            Random rd = new Random();
            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = rd.Next(1, 31);
            }

            LeetCode1 leetCode1 = new LeetCode1();
            foreach (var num in leetCode1.TwoSum2(nums, 59))
            {
                Console.WriteLine($"{num}:{nums[num]}");
            }
        }
    }
}
