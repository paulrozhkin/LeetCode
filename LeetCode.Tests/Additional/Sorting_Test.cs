using System;
using System.Collections.Generic;
using System.Linq;
using AutoFixture;
using FluentAssertions;
using LeetCode.Additional;
using Xunit;

namespace LeetCode.Tests.Additional
{
    public class Sorting_Test
    {
        private readonly Fixture _fixture = new();

        private readonly IEnumerable<int[]> _arrays;

        public Sorting_Test()
        {
            var random = new Random();

            var arrays = new List<int[]>
            {
                new[] {6, -3, -2},
                new[] {6, 4, -3, 5},
                new[] {6, 4, -3, 1, 2, 1, 7, 10}
            };

            for (var i = 0; i < 5; i++)
            {
                var countOfItems = random.Next(1, 100);
                arrays.Add(_fixture.CreateMany<int>(countOfItems).ToArray());
            }

            _arrays = arrays;
        }

        [Fact]
        public void BubbleSortTest()
        {
            SortTest(Sorting.BubbleSorting);
        }

        [Fact]
        public void SelectionSortTest()
        {
            SortTest(Sorting.SelectionSort);
        }

        [Fact]
        public void InsertionSortTest()
        {
            SortTest(Sorting.InsertionSort);
        }

        [Fact]
        public void ShellSortTest()
        {
            SortTest(Sorting.ShellSort);
        }

        [Fact]
        public void MergeSortHighLevelTest()
        {
            SortTest(Sorting.MergeSortHighLevel);
        }

        [Fact]
        public void MergeSortTest()
        {
            SortTest(Sorting.MergeSort);
        }

        [Fact]
        public void QuickSortTest()
        {
            SortTest(Sorting.QuickSort);
        }

        private void SortTest(Func<int[], int[]> sortingAction)
        {
            foreach (var array in _arrays)
            {
                var resultedArray = sortingAction(array);
                resultedArray.Should().BeInAscendingOrder();
            }
        }

        private void SortTest(Action<int[]> sortingAction)
        {
            foreach (var array in _arrays)
            {
                sortingAction(array);
                array.Should().BeInAscendingOrder();
            }
        }
    }
}