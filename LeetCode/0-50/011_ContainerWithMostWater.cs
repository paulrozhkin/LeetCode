using System;

namespace LeetCode._0_50
{
    public class _011_ContainerWithMostWater
    {
        /// <summary>
        /// O(N)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            var leftIndex = 0;
            var rightIndex = height.Length - 1;
            var maximum = 0;
            while (leftIndex < rightIndex)
            {
                var heightArea = Math.Min(height[leftIndex], height[rightIndex]);
                var widthArea = rightIndex - leftIndex;

                var area = heightArea * widthArea;
                maximum = Math.Max(maximum, area);
                if (height[leftIndex] < height[rightIndex])
                    leftIndex++;
                else if (height[leftIndex] > height[rightIndex])
                    rightIndex--;
                else
                {
                    leftIndex++;
                    rightIndex--;
                }
            }

            return maximum;
        }

        /*
        /// <summary>
        /// Invalid solution O(N)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            var currentLeftAmount = 0;
            var maxLeftAmount = currentLeftAmount;
            var maxLeftIndex = 0;
            for (var i = 0; i < height.Length - 1; i++)
            {
                currentLeftAmount = height[i] * (height.Length - i - 1);
                if (currentLeftAmount > maxLeftAmount)
                {
                    maxLeftAmount = currentLeftAmount;
                    maxLeftIndex = i;
                }
            }

            var currentRightAmount = 0;
            var maxRightAmount = currentRightAmount;
            var maxRightIndex = 0;
            for (var i = height.Length - 1; i > 0; i--)
            {
                currentRightAmount = height[i] * (height.Length - (height.Length - 1 - i) - 1);
                if (currentRightAmount > maxRightAmount)
                {
                    maxRightAmount = currentRightAmount;
                    maxRightIndex = i;
                }
            }

            var heightContainer = Math.Min(height[maxLeftIndex], height[maxRightIndex]);
            var amountInContainer = heightContainer * (maxRightIndex - maxLeftIndex);

            return amountInContainer;
        }


        /// <summary>
        /// O(N^2)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int MaxArea(int[] height)
        {
            var maximum = 0;
            for (var i = 0; i < height.Length; i++)
            {
                for (var j = i + 1; j < height.Length; j++)
                {
                    var heightContainer = Math.Min(height[i], height[j]);
                    var amountInContainer = heightContainer * (j - i);
                    maximum = Math.Max(maximum, amountInContainer);
                }
            }

            return maximum;
        }
        */
    }
}