using System.Collections.Generic;
using LeetCode.Additional;
using Xunit;

namespace LeetCode.Tests.Additional
{
    public class BinarySearchSymbolTableTests
    {
        private BinarySearchSymbolTable<string, int> _bst;

        public BinarySearchSymbolTableTests()
        {
            _bst = new BinarySearchSymbolTable<string, int>(16);
        }

        [Fact]
        public void ContainsShouldReturnFalseIfItemWasNotFoundAndTrueIfFound()
        {
            _bst.Add("a", 1);

            Assert.True(_bst.Contains("a"));
            Assert.False(_bst.Contains("b"));

            _bst.Add("b", 1);
            _bst.Add("c", 1);

            Assert.True(_bst.Contains("b"));
            Assert.True(_bst.Contains("c"));
        }

        [Fact]
        public void GetShouldReturnCorrectValue()
        {
            Assert.Equal(default(int), _bst.GetValueOrDefault("a"));

            _bst.Add("a", 1);
            _bst.Add("c", 3);
            _bst.Add("b", 2);

            Assert.Equal(1, _bst.GetValueOrDefault("a"));
            Assert.Equal(2, _bst.GetValueOrDefault("b"));
            Assert.Equal(3, _bst.GetValueOrDefault("c"));

            Assert.Equal(default(int), _bst.GetValueOrDefault("d"));
        }

        [Fact]
        public void PutUpdatingValue_ShouldUpdateCorrectly()
        {
            _bst.Add("a", 1);
            Assert.Equal(1, _bst.GetValueOrDefault("a"));

            _bst.Add("a", 2);
            Assert.Equal(2, _bst.GetValueOrDefault("a"));
        }

        [Fact]
        public void IterateOver_SeveralItems_ReturnsCorrectSortedSequence()
        {
            _bst = new BinarySearchSymbolTable<string, int>(3);
            _bst.Add("a", 1);
            _bst.Add("c", 3);
            _bst.Add("b", 2);

            var expected = new List<string> {"a", "b", "c"};

            Assert.Equal(expected, _bst.Keys());
        }


        [Fact]
        public void MinMax_SeveralItems_ReturnsMinAndMax()
        {
            _bst.Add("a", 1);
            _bst.Add("c", 3);
            _bst.Add("b", 2);

            Assert.Equal("a", _bst.Min());
            Assert.Equal("c", _bst.Max());
        }

        [Fact]
        public void RankReturnsCorrectIndex()
        {
            _bst.Add("a", 1);
            _bst.Add("c", 3);
            _bst.Add("b", 2);
            _bst.Add("d", 4);

            Assert.Equal(0, _bst.Rank("a"));
            Assert.Equal(3, _bst.Rank("d"));
        }

        [Fact]
        public void CeilingAndFloor()
        {
            _bst = new BinarySearchSymbolTable<string, int>(4);

            _bst.Add("b", 1);
            _bst.Add("c", 2);
            _bst.Add("d", 3);
            _bst.Add("e", 4);

            Assert.Equal("b", _bst.Ceiling("b"));
            Assert.Equal("b", _bst.Ceiling("a"));
            Assert.Null(_bst.Ceiling("f"));

            Assert.Equal("e", _bst.Floor("e"));

            Assert.Null(_bst.Floor("a"));

            Assert.Equal("e", _bst.Floor("f"));
        }

        [Fact]
        public void Add_TooManyItems_CapacityGrows()
        {
            _bst = new BinarySearchSymbolTable<string, int>(4);

            _bst.Add("b", 1);
            _bst.Add("c", 2);
            _bst.Add("d", 3);
            _bst.Add("e", 4);
            _bst.Add("f", 5);

            Assert.Equal(8, _bst.Capacity);
        }

        [Fact]
        public void Remove_TooManyItems_CapacityGrows()
        {
            _bst = new BinarySearchSymbolTable<string, int>(4);

            _bst.Add("b", 1);
            _bst.Add("c", 2);
            _bst.Add("d", 3);
            _bst.Add("e", 4);
            _bst.Add("f", 5);

            _bst.Remove("d");
        }

        [Fact]
        public void Range()
        {
            var expected = new List<string>()
            {
                "b", "c", "d", "e", "f"
            };

            _bst.Add("b", 1);
            _bst.Add("c", 2);
            _bst.Add("d", 3);
            _bst.Add("e", 4);
            _bst.Add("f", 5);

            var range = _bst.Range("a", "g");

            Assert.Equal(expected, range);
        }

        [Fact]
        public void RangeWithMax()
        {
            var expected = new List<string>()
            {
                "b", "c", "d", "e", "f"
            };

            _bst.Add("b", 1);
            _bst.Add("c", 2);
            _bst.Add("d", 3);
            _bst.Add("e", 4);
            _bst.Add("f", 5);

            var range = _bst.Range("a", "f");

            Assert.Equal(expected, range);
        }

        [Fact]
        public void RangeWithMin()
        {
            var expected = new List<string>()
            {
                "b", "c", "d", "e", "f"
            };

            _bst.Add("b", 1);
            _bst.Add("c", 2);
            _bst.Add("d", 3);
            _bst.Add("e", 4);
            _bst.Add("f", 5);

            var range = _bst.Range("b", "g");

            Assert.Equal(expected, range);
        }

        [Fact]
        public void RangeWithMinAndMax()
        {
            var expected = new List<string>()
            {
                "b", "c", "d", "e", "f"
            };

            _bst.Add("b", 1);
            _bst.Add("c", 2);
            _bst.Add("d", 3);
            _bst.Add("e", 4);
            _bst.Add("f", 5);

            var range = _bst.Range("b", "f");

            Assert.Equal(expected, range);
        }
    }
}