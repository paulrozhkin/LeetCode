using System;

namespace LeetCode._151_200
{
    public class _153_FindMinimumInRotatedSortedArray
    {
        public int FindMin(int[] nums)
        {
            var minimum = int.MaxValue;
            return BinarySearchMinimumRotated(nums, minimum, 0, nums.Length - 1);
        }

        private int BinarySearchMinimumRotated(int[] nums, int minimum, int left, int right)
        {
            if (left <= right)
            {
                var middle = (right + left) / 2;
                var middleNum = nums[middle];

                minimum = Math.Min(middleNum, minimum);

                int rightNum = nums[right];

                if (rightNum > middleNum)
                {
                    return BinarySearchMinimumRotated(nums, minimum, left, middle - 1);
                }
                else
                {
                    return BinarySearchMinimumRotated(nums, minimum, middle + 1, right);
                }
            }

            return minimum;
        }
    }
}