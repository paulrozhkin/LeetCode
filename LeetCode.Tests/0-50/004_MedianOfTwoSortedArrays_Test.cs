﻿using LeetCode._0_50;
using Xunit;

namespace LeetCode.Tests._0_50
{
    public class _004_MedianOfTwoSortedArrays_Test
    {
        [Fact]
        public void FindMedianSortedArraysTest_General_Odd()
        {
            int[] nums1 = { 1, 2 };
            int[] nums2 = { 3, 4, 5 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(3, result);
        }

        [Fact]
        public void FindMedianSortedArraysTest_General_Even()
        {
            int[] nums1 = { 1, 2, 3, 4 };
            int[] nums2 = { 5, 6, 7, 8 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(4.5, result);
        }

        [Fact]
        public void FindMedianSortedArraysTest_Num1Empty()
        {
            int[] nums1 = { };
            int[] nums2 = { 1, 2, 3 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void FindMedianSortedArraysTest_Num2Empty()
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void FindMedianSortedArraysTest_Num1Empty_Nums2SingleItem()
        {
            int[] nums1 = { };
            int[] nums2 = { 1 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(1, result);
        }

        [Fact]
        public void FindMedianSortedArraysTest_Num2Empty_Nums1SingleItem()
        {
            int[] nums1 = { 1 };
            int[] nums2 = { };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(1, result);
        }

        [Fact]
        public void FindMedianSortedArraysTest_Nums1SingleItem_Odd()
        {
            int[] nums1 = { 1 };
            int[] nums2 = { 2, 3, 4, 5, 6, 7 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(4, result);
        }

        [Fact]
        public void FindMedianSortedArraysTest_Nums1SingleItem_Even()
        {
            int[] nums1 = { 1 };
            int[] nums2 = { 2, 3, 4, 5, 6 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(3.5, result);
        }

        [Fact]
        public void FindMedianSortedArraysTest_Nums2SingleItem_Odd()
        {
            int[] nums1 = { 2, 3, 4, 5, 6, 7 };
            int[] nums2 = { 1 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(4, result);
        }

        [Fact]
        public void FindMedianSortedArraysTest_Nums2SingleItem_Even()
        {
            int[] nums1 = { 2, 3, 4, 5, 6 };
            int[] nums2 = { 1 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(3.5, result);
        }

        [Fact]
        public void FindMedianSortedArraysTest_MixedArray()
        {
            int[] nums1 = { 2 };
            int[] nums2 = { 1, 3, 4 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(2.5, result);
        }

        [Fact]
        public void FindMedianSortedArraysTest_DuplicateItems()
        {
            int[] nums1 = { 1, 1, 3, 3 };
            int[] nums2 = { 1, 1, 3, 3 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(2, result);
        }

        [Fact]
        public void FindMedianSortedArraysTest_DuplicateItems_2()
        {
            int[] nums1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22 };
            int[] nums2 = { 0, 6 };

            var solution = new _004_MedianOfTwoSortedArrays();
            var result = solution.FindMedianSortedArrays(nums1, nums2);

            Assert.Equal(10.5, result);
        }
    }
}