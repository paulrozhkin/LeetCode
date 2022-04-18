using System.Linq;
using LeetCode.Additional;
using Xunit;

namespace LeetCode.Tests.Additional
{
    public class ChainHashSetTests
    {
        [Fact]
        public void AddWithDefaultCapacityTest()
        {
            // arrange
            var chainHashSet = new ChainHashSet<int, int>();

            // act
            chainHashSet.Add(0, 0);
            chainHashSet.Add(1, 1);
            chainHashSet.Add(2, 2);
            chainHashSet.Add(3, 3);

            // assert
            Assert.Equal(4, chainHashSet.Count);
            Assert.True(chainHashSet.Contains(2));
        }

        [Fact]
        public void AddWithResizeCapacityTest()
        {
            // arrange
            var chainHashSet = new ChainHashSet<int, int>();

            // act
            const int count = 100;
            for (var i = 0; i < count; i++)
            {
                chainHashSet.Add(i, i);
            }

            // assert
            Assert.Equal(count, chainHashSet.Count);
            Assert.True(chainHashSet.Contains(25));
        }

        [Fact]
        public void ContainsTest()
        {
            // arrange
            var chainHashSet = new ChainHashSet<int, int>();

            // act
            chainHashSet.Add(0, 0);
            chainHashSet.Add(1, 1);

            // assert
            Assert.True(chainHashSet.Contains(1));
        }

        [Fact]
        public void NotContainsTest()
        {
            // arrange
            var chainHashSet = new ChainHashSet<int, int>();

            // act
            chainHashSet.Add(0, 0);
            chainHashSet.Add(1, 1);

            // assert
            Assert.False(chainHashSet.Contains(2));
        }

        [Fact]
        public void GetTest()
        {
            // arrange
            var chainHashSet = new ChainHashSet<int, int>();

            // act
            chainHashSet.Add(0, 0);
            chainHashSet.Add(1, 1);
            chainHashSet.Add(2, 2);
            chainHashSet.Add(3, 3);
            chainHashSet.Add(4, 8);
            chainHashSet.Add(5, 5);
            chainHashSet.Add(6, 6);

            // assert
            Assert.Equal(8, chainHashSet.Get(4));
        }

        [Fact]
        public void KeysTest()
        {
            // arrange
            var chainHashSet = new ChainHashSet<int, int>();

            // act
            chainHashSet.Add(0, 0);
            chainHashSet.Add(1, 1);
            chainHashSet.Add(2, 2);
            chainHashSet.Add(3, 3);
            chainHashSet.Add(4, 8);
            chainHashSet.Add(5, 5);
            chainHashSet.Add(6, 6);

            // assert
            var sortedKeys = chainHashSet.Keys().ToList();
            sortedKeys.Sort();
            Assert.Equal(new[] {0, 1, 2, 3, 4, 5, 6}, sortedKeys);
        }

        [Fact]
        public void RemoveTest()
        {
            // arrange
            var chainHashSet = new ChainHashSet<int, int>();

            // act
            chainHashSet.Add(0, 0);
            chainHashSet.Add(1, 1);
            chainHashSet.Add(2, 2);
            chainHashSet.Add(3, 3);
            chainHashSet.Add(4, 4);
            chainHashSet.Add(5, 5);
            chainHashSet.Add(6, 6);

            chainHashSet.Remove(1);
            chainHashSet.Remove(3);
            chainHashSet.Remove(5);

            // assert
            Assert.Equal(4, chainHashSet.Count);
            var sortedKeys = chainHashSet.Keys().ToList();
            sortedKeys.Sort();
            Assert.Equal(new[] {0, 2, 4, 6}, sortedKeys);
        }
    }
}