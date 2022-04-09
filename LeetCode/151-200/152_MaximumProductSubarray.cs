using System;

namespace LeetCode._151_200
{
    public class _152_MaximumProductSubarray
    {
        /// <summary>
        /// O(N)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MaxProduct(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            // max positive product
            // ending at the current position
            int maxEndingHere = nums[0];

            // min negative product ending
            // at the current position
            int minEndingHere = nums[0];

            // Initialize overall max product
            int maxSoFar = nums[0];

            /* Traverse through the array.
            the maximum product subarray ending at an index
            will be the maximum of the element itself,
            the product of element and max product ending previously
            and the min product ending previously. */
            for (var i = 1; i < nums.Length; i++)
            {
                var temp = Math.Max(Math.Max(nums[i], nums[i] * maxEndingHere), nums[i] * minEndingHere);
                minEndingHere = Math.Min(Math.Min(nums[i], nums[i] * maxEndingHere), nums[i] * minEndingHere);
                maxEndingHere = temp;
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }
    }
}