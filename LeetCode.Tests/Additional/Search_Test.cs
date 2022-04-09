using System;
using System.Linq;
using AutoFixture;
using LeetCode.Additional;
using Xunit;

namespace LeetCode.Tests.Additional
{
    public class Search_Test
    {
        [Fact]
        public void BinarySearchTest()
        {
            // arrange
            var sortedPositives = new[] { -15, - 6, 29, 93, 142, 165};
            
            // act & asserts
            Assert.Equal(4, Search.BinarySearch(sortedPositives, 142));
            Assert.Equal(2, Search.BinarySearch(sortedPositives, 29));
            Assert.Equal(3, Search.BinarySearch(sortedPositives, 93));
            Assert.Equal(0, Search.BinarySearch(sortedPositives, -15));
            Assert.Equal(5, Search.BinarySearch(sortedPositives, 165));
            Assert.Equal(-1, Search.BinarySearch(sortedPositives, 300));
            Assert.Equal(-1, Search.BinarySearch(sortedPositives, -300));

           
        }

        [Fact]
        public void BinarySearchRandomArrayTest()
        {
            // arrange
            var randomBigArray = new Fixture().CreateMany<int>(999).ToArray();
            Array.Sort(randomBigArray);
            var randomIndex = new Random().Next(0, randomBigArray.Length);

            // act & asserts
            Assert.Equal(randomIndex, Search.BinarySearch(randomBigArray, randomBigArray[randomIndex]));
        }

        [Fact]
        public void BinarySearchRecursionTest()
        {
            // arrange
            var sortedPositives = new[] { -15, -6, 29, 93, 142, 165 };

            // act & asserts
            Assert.Equal(4, Search.BinarySearchRecursion(sortedPositives, 142));
            Assert.Equal(2, Search.BinarySearchRecursion(sortedPositives, 29));
            Assert.Equal(3, Search.BinarySearchRecursion(sortedPositives, 93));
            Assert.Equal(0, Search.BinarySearchRecursion(sortedPositives, -15));
            Assert.Equal(5, Search.BinarySearchRecursion(sortedPositives, 165));
            Assert.Equal(-1, Search.BinarySearchRecursion(sortedPositives, 300));
            Assert.Equal(-1, Search.BinarySearchRecursion(sortedPositives, -300));


        }

        [Fact]
        public void BinarySearchRecursionRandomArrayTest()
        {
            // arrange
            var randomBigArray = new Fixture().CreateMany<int>(999).ToArray();
            Array.Sort(randomBigArray);
            var randomIndex = new Random().Next(0, randomBigArray.Length);

            // act & asserts
            Assert.Equal(randomIndex, Search.BinarySearchRecursion(randomBigArray, randomBigArray[randomIndex]));
        }
    }
}
