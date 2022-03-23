using LeetCode._0_50;
using Xunit;

namespace LeetCode.Tests._0_50
{
    public class _001_TwoSum_Test
    {
        private readonly int[] _largeArray;

        public _001_TwoSum_Test()
        {
            _largeArray = new int[20000];
            for (int i = 0; i < 20000; i++)
            {
                _largeArray[i] = i * 2;
            }
        }

        [Fact]
        public void TwoSumTest_Ordered()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.Equal(2, result.Length);
            Assert.Equal(0, result[0]);
            Assert.Equal(1, result[1]);
        }

        [Fact]
        public void TwoSumTest_Unordered()
        {
            var nums = new int[] { 5, 75, 25 };
            var target = 100;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.Equal(2, result.Length);
            Assert.Equal(1, result[0]);
            Assert.Equal(2, result[1]);
        }

        [Fact]
        public void TwoSumTest_Duplicate()
        {
            var nums = new[] { 5, 5, 15, 30 };
            var target = 20;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.Equal(2, result.Length);
            Assert.Equal(target, nums[result[0]] + nums[result[1]]);
        }

        [Fact]
        public void TwoSumTest_AllSame()
        {
            var nums = new[] { 5, 5, 5, 5, 5 };
            var target = 10;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.Equal(2, result.Length);
            Assert.Equal(0, result[0]);
            Assert.Equal(1, result[1]);
        }

        [Fact]
        public void TwoSumTest_NoTarget()
        {
            var nums = new[] { 2, 7, 11, 15 };
            var target = 5;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(nums, target);

            Assert.Empty(result);
        }

        [Fact(Timeout = 50)]
        public void TwoSumTest_LargeArray()
        {
            var target = 19082;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(_largeArray, target);

            Assert.Equal(2, result.Length);
            Assert.Equal(target, _largeArray[result[0]] + _largeArray[result[1]]);
        }

        [Fact(Timeout = 50)]
        public void TwoSumTest_LargeArray_NoTarget()
        {
            var target = 19081;

            var solution = new _001_TwoSum();
            var result = solution.TwoSum(_largeArray, target);

            Assert.Empty(result);
        }
    }
}