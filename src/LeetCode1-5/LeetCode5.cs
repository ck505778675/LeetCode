using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode1_5
{
    public class LeetCode5
    {
        public string LongestPalindrome(string s)
        {
            var data = new List<char>();
            string tempStr = "";
            int temp = 0;
            if (s.Length == 1)
                return s;
            for (int i = 0; i < s.Length; i++)
            {
                
                int index = data.IndexOf(s[i]);
                data.Add(s[i]);
                if (index > -1 && (i - index + 1) > temp)
                {
                    temp = i - index + 1;
                    tempStr = s.Substring(index, temp);
                }
            }
            return tempStr;
        }
    }
}
