using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var arrays = new List<int[]> {new[] {6, 4, -3, 5}};

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