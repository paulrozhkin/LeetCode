using LeetCode._0_50;
using Xunit;

namespace LeetCode.Tests._000_050
{
    public class _020_ValidParentheses_Test
    {
        [Fact]
        public void IsValidTest()
        {
            var solution = new _020_ValidParentheses();

            Assert.True(solution.IsValid("()"));
            Assert.True(solution.IsValid("[]"));
            Assert.True(solution.IsValid("{}"));
            Assert.True(solution.IsValid("()[]{}"));
        }

        [Fact]
        public void IsValidTest_WithOtherCharacters()
        {
            var solution = new _020_ValidParentheses();

            Assert.True(solution.IsValid("abc(abc)abc"));
            Assert.True(solution.IsValid("abc[abc]abc"));
            Assert.True(solution.IsValid("abc{abc}abc"));
            Assert.True(solution.IsValid("abc(abc)abc[abc]abc{abc}abc"));
        }

        [Fact]
        public void IsValidTest_NotValid()
        {
            var solution = new _020_ValidParentheses();

            Assert.False(solution.IsValid("("));
            Assert.False(solution.IsValid(")"));
            Assert.False(solution.IsValid("["));
            Assert.False(solution.IsValid("]"));
            Assert.False(solution.IsValid("{"));
            Assert.False(solution.IsValid("}"));
            Assert.False(solution.IsValid("(]"));
            Assert.False(solution.IsValid("(}"));
            Assert.False(solution.IsValid("[)"));
            Assert.False(solution.IsValid("[}"));
            Assert.False(solution.IsValid("{)"));
            Assert.False(solution.IsValid("{]"));
        }
    }
}