using LeetCode._0_50;
using Xunit;

namespace LeetCode.Tests._0_50
{
    public class _003_LongestSubstringWithoutRepeatingCharacters_Test
    {
        [Fact]
        public void LengthOfLongestSubstringTest()
        {
            var input = "abcabcbb";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.Equal(3, result);
        }

        [Fact]
        public void LengthOfLongestSubstringTest_RepeatChars()
        {
            var input = "bbbbb";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.Equal(1, result);
        }

        [Fact]
        public void LengthOfLongestSubstringTest_EmptyInput()
        {
            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring("");

            Assert.Equal(0, result);
        }

        [Fact]
        public void LengthOfLongestSubstringTest_LongString()
        {
            var input = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.Equal(26, result);
        }

        [Fact]
        public void LengthOfLongestSubstringTest_LongString_HaveShortRepeat()
        {
            var input = "abcdefghijklmnopqrstuvwxyzabcdefghijk  lmnopqrstuvwxyz";

            var solution = new _003_LongestSubstringWithoutRepeatingCharacters();
            var result = solution.LengthOfLongestSubstring(input);

            Assert.Equal(27, result);
        }
    }
}
