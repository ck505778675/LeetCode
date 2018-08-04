using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode11_15
{

    public class LeetCode11
    {
        /// <summary>
        /// 暴力法
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            var maxArea = 0;
            for (var i = 0; i < height.Length - 1; i++)
            {
                for (var j = i + 1; j < height.Length; j++)
                {
                    maxArea = Math.Max(maxArea, (j - i) * Math.Min(height[i], height[j]));
                }
            }
            return maxArea;
        }

        /// <summary>
        /// 双指针法
        /// 最初我们考虑由最外围两条线段构成的区域。
        /// 现在，为了使面积最大化，我们需要考虑更长的两条线段之间的区域。
        /// 如果我们试图将指向较长线段的指针向内侧移动，矩形区域的面积将受限于较短的线段而不会获得任何增加。
        /// 但是，在同样的条件下，移动指向较短线段的指针尽管造成了矩形宽度的减小，但却可能会有助于面积的增大。
        /// 因为移动较短线段的指针会得到一条相对较长的线段，这可以克服由宽度减小而引起的面积减小。
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea2(int[] height)
        {
            int i = 0;
            int j = height.Length - 1;
            int w = j;
            int maxArea = 0;
            while (i < j)
            {
                maxArea = Math.Max(maxArea, w-- * (height[i] >= height[j] ? height[j--] : height[i++]));
            }

            return maxArea;
        }
    }
}
