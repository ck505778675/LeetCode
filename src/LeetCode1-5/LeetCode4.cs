using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode1_5
{
    public class LeetCode4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            int[] temp = new int[nums1.Length + nums2.Length];
            int i = 0, j = 0, k = 0;
            while (i < nums1.Length || j < nums2.Length)
            {
                if (j >= nums2.Length || i < nums1.Length && nums1[i] <= nums2[j])
                {
                    temp[k] = nums1[i];
                    i++;
                }
                else
                {
                    temp[k] = nums2[j];
                    j++;
                }
                k++;

            }
            var mid = (int)Math.Floor(temp.Length / 2.0);
            return temp.Length % 2 == 0 ? (temp[mid] + temp[mid - 1]) / (double)2 : temp[mid];


        }

        public double FindMedianSortedArrays2(int[] nums1, int[] nums2)
        {
            var list = nums1.Concat(nums2).OrderBy(i => i).ToList();
            var mid = (int)Math.Floor(list.Count() / 2.0);
            return list.Count() % 2 == 0 ? (list[mid] + list[mid - 1]) / (double)2 : list[mid];
        }

        public double FindMedianSortedArrays3(int[] nums1, int[] nums2)
        {

            int m = nums1.Length;
            int n = nums2.Length;
            if (m > n)
            { // to ensure m<=n
                return FindMedianSortedArrays3(nums2, nums1);
            }
            int iMin = 0, iMax = m, halfLen = (m + n + 1) / 2;
            while (iMin <= iMax)
            {
                int i = (iMin + iMax) / 2;
                int j = halfLen - i;
                if (i < iMax && nums2[j - 1] > nums1[i])
                {
                    iMin = iMin + 1; // i is too small
                }
                else if (i > iMin && nums1[i - 1] > nums2[j])
                {
                    iMax = iMax - 1; // i is too big
                }
                else
                { // i is perfect
                    int maxLeft = 0;
                    if (i == 0) { maxLeft = nums2[j - 1]; }
                    else if (j == 0) { maxLeft = nums1[i - 1]; }
                    else { maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]); }
                    if ((m + n) % 2 == 1) { return maxLeft; }

                    int minRight = 0;
                    if (i == m) { minRight = nums2[j]; }
                    else if (j == n) { minRight = nums1[i]; }
                    else { minRight = Math.Min(nums2[j], nums1[i]); }

                    return (maxLeft + minRight) / 2.0;
                }
            }
            return 0.0;
        }
    }
}
