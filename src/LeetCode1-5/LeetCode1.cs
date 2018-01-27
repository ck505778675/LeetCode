using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode1_5
{
    public class LeetCode1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[2] { i, j };
                    }
                }
            }

            throw new ArgumentException("No two sum solution");
        }

        public int[] TwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                dic[nums[i]] = i; //不能使用add来添加，避免key重复报错
            }

            for (var i = 0; i < nums.Length - 1; i++)
            {
                int temp = target - nums[i];
                if (dic.ContainsKey(temp) && dic[temp] != i)
                    return new int[] { i, dic[temp] };
            }

            throw new ArgumentException("No two sum solution");


        }
    }
}
