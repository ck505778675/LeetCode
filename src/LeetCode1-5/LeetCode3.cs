using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode1_5
{
    public class LeetCode3
    {
        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            List<char> list = new List<char>();
            for (var i = 0; i < s.Length; i++)
            {
                if (!list.Contains(s[i]))
                {
                    list.Add(s[i]);
                    if (list.Count > maxLength) maxLength = list.Count;
                }
                else
                {
                    list.RemoveRange(0, list.IndexOf(s[i]) + 1);
                    list.Add(s[i]);
                }
                //int index = list.IndexOf(s[i]);
                //if (list.IndexOf(s[i]) > -1)
                //{
                //    if (list.Count > maxLength) maxLength = list.Count;
                //    list.RemoveRange(0, index + 1);

                //}
                //list.Add(s[i]);
                //if (i == s.Length - 1)
                //{
                //    if (list.Count > maxLength) maxLength = list.Count;
                //}
            }
            return maxLength;

        }

        public int LengthOfLongestSubstring2(string s)
        {
            var data = new HashSet<char>();
            int n = s.Length;
            int res = 0;
            int i = 0, j = 0;
            while (i < n && j < n)
            {
                if (!data.Contains(s[j]))
                {
                    data.Add(s[j++]);
                    if (j - i > res)
                    {
                        res = j - i;
                    }
                }
                else
                {
                    data.Remove(s[i++]);
                }
            }
            return res;
        }
    }
}
