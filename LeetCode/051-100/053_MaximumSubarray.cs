using System;

namespace LeetCode._051_100
{
    public class _053_MaximumSubarray
    {
        /// <summary>
        /// Divide and Conquer algorithm O(n Log n).
        /// 1. Divide the given array in two halves
        /// 2. Return the maximum of following three:
        ///     - Maximum subarray sum in left half(Make a recursive call)
        ///     - Maximum subarray sum in right half(Make a recursive call)
        ///     - Maximum subarray sum such that the subarray crosses the midpoint
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return int.MinValue;
            }

            return MaxSubArray(0, nums.Length - 1);

            int MaxSubArray(int low, int high)
            {
                if (low == high)
                {
                    return nums[low];
                }

                var midpoint = (low + high) / 2;

                return MaximumOfThree(
                    MaxSubArray(low, midpoint),
                    MaxSubArray(midpoint + 1, high),
                    MaxCrosses(low, high, midpoint)
                );

            }

            int MaxCrosses(int low, int high, int midpoint)
            {
                var leftMaxSum = int.MinValue;
                var currentSum = 0;

                for (var i = midpoint; i >= low; i--)
                {
                    currentSum += nums[i];
                    if (currentSum > leftMaxSum)
                    {
                        leftMaxSum = currentSum;
                    }
                }

                var rightMaxSum = int.MinValue;
                currentSum = 0;
                for (var i = midpoint + 1; i <= high; i++)
                {
                    currentSum += nums[i];
                    if (currentSum > rightMaxSum)
                    {
                        rightMaxSum = currentSum;
                    }
                }

                return MaximumOfThree(leftMaxSum, rightMaxSum, leftMaxSum + rightMaxSum);
            }

            int MaximumOfThree(int leftSum, int rightSum, int crossesSum)
            {
                return Math.Max(Math.Max(leftSum, rightSum), crossesSum);
            }
        }

        /*

        /// <summary>
        /// Kadane's algorithm - O(N)
        /// Best algorithm for solve problem 'Maximum Subarray Sum'
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxSubArray(int[] nums)
        {
            if (nums.Length == 0)
            {
                return int.MinValue;
            }

            var bestSum = int.MinValue;
            var currentSum = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                currentSum = Math.Max(nums[i], currentSum + nums[i]);
                bestSum = Math.Max(bestSum, currentSum);
            }

            return bestSum;
        }

        /// <summary>
        /// O(N ^ 2)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxSubArray(int[] nums)
        {
            var max = int.MinValue;
            for (var i = 0; i < nums.Length; i++)
            {
                var subArraySum = 0;
                for (var j = i; j < nums.Length; j++)
                {
                    subArraySum += nums[j];

                    if (subArraySum > max)
                    {
                        max = subArraySum;
                    }
                }
            }

            return max;
        }
        */
    }
}