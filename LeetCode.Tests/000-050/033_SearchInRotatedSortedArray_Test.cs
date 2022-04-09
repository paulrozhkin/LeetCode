﻿using LeetCode._0_50;
using Xunit;

namespace LeetCode.Tests._000_050
{
    public class _033_SearchInRotatedSortedArray_Test
    {
        [Fact]
        public void SearchTest_TargetLessThanMid_Rotated()
        {
            var input = new int[] {4, 5, 6, 7, 0, 1, 2};

            var solution = new _033_SearchInRotatedSortedArray();
            var result = solution.Search(input, 1);

            Assert.Equal(5, result);
        }

        [Fact]
        public void SearchTest_TargetLessThanMid_Rotated_2()
        {
            var input = new int[] {7, 8, 0, 1, 2, 4, 5, 6};

            var solution = new _033_SearchInRotatedSortedArray();
            var result = solution.Search(input, 0);

            Assert.Equal(2, result);
        }

        [Fact]
        public void SearchTest_TargetLessThanMid_NoRotated()
        {
            var input = new int[] {4, 5, 6, 7, 0, 1, 2};

            var solution = new _033_SearchInRotatedSortedArray();
            var result = solution.Search(input, 5);

            Assert.Equal(1, result);
        }

        [Fact]
        public void SearchTest_TargetLargeThanMid_Rotated()
        {
            var input = new int[] {6, 7, 0, 1, 2, 4, 5};

            var solution = new _033_SearchInRotatedSortedArray();
            var result = solution.Search(input, 7);

            Assert.Equal(1, result);
        }

        [Fact]
        public void SearchTest_TargetLargeThanMid_Rotated_2()
        {
            var input = new int[] {4, 5, 6, 7, 8, 0, 1, 2};

            var solution = new _033_SearchInRotatedSortedArray();
            var result = solution.Search(input, 8);

            Assert.Equal(4, result);
        }

        [Fact]
        public void SearchTest_TargetLargeThanMid_NoRotated()
        {
            var input = new int[] {6, 7, 0, 1, 2, 4, 5};

            var solution = new _033_SearchInRotatedSortedArray();
            var result = solution.Search(input, 4);

            Assert.Equal(5, result);
        }

        [Fact]
        public void SearchTest_NotFound()
        {
            var input = new int[] {6, 7, 0, 1, 2, 4, 5};

            var solution = new _033_SearchInRotatedSortedArray();
            var result = solution.Search(input, 8);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void SearchTest_SmallArray()
        {
            var input = new int[] {3, 1};

            var solution = new _033_SearchInRotatedSortedArray();
            var result = solution.Search(input, 1);

            Assert.Equal(1, result);
        }

        [Fact]
        public void SearchTest_SmallArray_2()
        {
            var input = new int[] {1, 3};

            var solution = new _033_SearchInRotatedSortedArray();
            var result = solution.Search(input, 3);

            Assert.Equal(1, result);
        }
    }
}