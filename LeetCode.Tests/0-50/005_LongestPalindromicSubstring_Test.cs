using LeetCode._0_50;
using Xunit;

namespace LeetCode.Tests._0_50
{
    public class _005_LongestPalindromicSubstring_Test
    {
        [Fact]
        public void LongestPalindromeTest_Odd()
        {
            var input = "abcdefgfedcba";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.Equal("abcdefgfedcba", result);
        }

        [Fact]
        public void LongestPalindromeTest_Even()
        {
            var input = "abcdefggfedcba";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.Equal("abcdefggfedcba", result);
        }

        [Fact]
        public void LongestPalindromeTest_AllTheSame_Odd()
        {
            var input = "ccc";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.Equal("ccc", result);
        }

        [Fact]
        public void LongestPalindromeTest_AllTheSame_Even()
        {
            var input = "aaaaaaaaaa";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.Equal("aaaaaaaaaa", result);
        }

        [Fact]
        public void LongestPalindromeTest_EmptyString()
        {
            var input = "";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.Equal("", result);
        }

        [Fact]
        public void LongestPalindromeTest_OneCharacterString()
        {
            var input = "a";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.Equal("a", result);
        }

        [Fact]
        public void LongestPalindromeTest_MultiplePalindrome_LongestAtStart()
        {
            var input = "aabccdccbaaeeggee";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.Equal("aabccdccbaa", result);
        }

        [Fact]
        public void LongestPalindromeTest_MultiplePalindrome_LongestAtEnd()
        {
            var input = "eegffgeeaabcdcbaa";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.Equal("aabcdcbaa", result);
        }

        [Fact]
        public void LongestPalindromeTest_MultipleMixPalindrome()
        {
            var input = "abcdcbbcd";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.Equal("dcbbcd", result);
        }

        [Fact]
        public void LongestPalindromeTest_MultipleMixPalindrome_2()
        {
            var input = "abcddcbebcd";

            var solution = new _005_LongestPalindromicSubstring();
            var result = solution.LongestPalindrome(input);

            Assert.Equal("dcbebcd", result);
        }
    }
}
