using LeetCode._0_50;
using Xunit;

namespace LeetCode.Tests._0_50
{
    public class _009_PalindromeNumber_Test
    {
        [Fact]
        public void IsPalindromeTest_SingleDigit()
        {
            var solution = new _009_PalindromeNumber();
            var result = solution.IsPalindrome(0);
            Assert.True(result);

            result = solution.IsPalindrome(1);
            Assert.True(result);
        }

        [Fact]
        public void IsPalindromeTest_NegativeNumber()
        {
            var solution = new _009_PalindromeNumber();

            var result = solution.IsPalindrome(-1);
            Assert.False(result);
        }

        [Fact]
        public void IsPalindromeTest_MultipleDigit()
        {
            var solution = new _009_PalindromeNumber();
            var result = solution.IsPalindrome(11);
            Assert.True(result);

            result = solution.IsPalindrome(121);
            Assert.True(result);

            result = solution.IsPalindrome(1231);
            Assert.False(result);

            result = solution.IsPalindrome(1221);
            Assert.True(result);
        }
    }
}