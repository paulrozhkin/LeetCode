using System;

namespace LeetCode._0_50
{
    public class _004_MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] allItems = new int[nums1.Length + nums2.Length];
            Array.Copy(nums1, allItems, nums1.Length);
            Array.Copy(nums2, 0, allItems, nums1.Length, nums2.Length);
            Array.Sort(allItems);

            var count = allItems.Length;
            if (count % 2 == 0)
            {
                return (allItems[count / 2 - 1] + allItems[count / 2]) / 2.0;
            }
            else
            {
                return allItems[count / 2];
            }
        }
    }
}
