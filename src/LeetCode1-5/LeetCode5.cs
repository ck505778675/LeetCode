using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode1_5
{
    public class LeetCode5
    {
        public string LongestPalindrome(string s)
        {
            if (s.Length == 1)
                return s;
            int maxLength = 0;
            string str = s.Substring(0, 1);
            for (int index = 1; index < s.Length; index++)
            {

                if (s[index - 1] == s[index])
                {
                    int i = index;
                    int j = index - 1;
                    while (i >= 1 && j <= s.Length - 2 && s[i - 1] == s[j + 1])
                    {
                        i--;
                        j++;
                    }
                    if (j - i + 1 > maxLength)
                    {
                        maxLength = j - i + 1;
                        str = s.Substring(i, maxLength);
                    }

                }
                if (index < s.Length - 1 && s[index - 1] == s[index + 1])
                {
                    int i = index;
                    int j = index;
                    while (i >= 1 && j <= s.Length - 2 && s[i - 1] == s[j + 1])
                    {
                        i--;
                        j++;
                    }
                    if (j - i + 1 > maxLength)
                    {
                        maxLength = j - i + 1;
                        str = s.Substring(i, maxLength);
                    }

                }

            }
            return str;
        }

        private int lo, maxLen;

        public string LongestPalindrome1(string s)
        {

            if (s.Length < 2)
                return s;
            lo = 0;
            maxLen = 0;
            for (int i = 1; i < s.Length; i++)
            {
                ExtendPalindrome(s, i, i - 1);
                ExtendPalindrome(s, i, i);
            }
            return s.Substring(lo, maxLen);

        }
        public void ExtendPalindrome(string s, int j, int k)
        {
            while (j >= 1 && k <= s.Length - 2 && s[j - 1] == s[k + 1])
            {
                j--;
                k++;
            }
            if (k - j + 1 > maxLen)
            {
                lo = j;
                maxLen = k - j + 1;

            }
        }
    }
}
