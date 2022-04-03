using LeetCode._201_250;
using Xunit;

namespace LeetCode.Tests._201_250
{
    public class _242_ValidAnagram_Test
    {
        [Fact]
        public void IsAnagram_1()
        {
            var solution = new _242_ValidAnagram();
            var result = solution.IsAnagram("anagram", "nagaram");
            Assert.True(result);
        }

        [Fact]
        public void IsAnagram_2()
        {
            var solution = new _242_ValidAnagram();
            var result = solution.IsAnagram("rat", "car");
            Assert.False(result);
        }

        [Fact]
        public void IsAnagram_Unicode()
        {
            var solution = new _242_ValidAnagram();
            var result = solution.IsAnagramUnicode("Õ␡❤", "❤Õ␡");
            Assert.True(result);
        }
    }
}
