using LeetCode._0_50;
using Xunit;

namespace LeetCode.Tests._000_050
{
    public class _011_ContainerWithMostWater_Test
    {
        [Fact]
        public void MaxAreaTest_General_1()
        {
            int[] input = {1, 1};

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.Equal(1, result);
        }

        [Fact]
        public void MaxAreaTest_General_2()
        {
            int[] input = {1, 2, 3, 4, 5, 6, 7, 8, 9};

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.Equal(20, result);
        }

        [Fact]
        public void MaxAreaTest_General_3()
        {
            int[] input = {9, 8, 7, 6, 5, 4, 3, 2, 1};

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.Equal(20, result);
        }

        [Fact]
        public void MaxAreaTest_General_4()
        {
            int[] input = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.Equal(49, result);
        }

        [Fact]
        public void MaxAreaTest_General_5()
        {
            int[] input = {1, 2, 1};

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.Equal(2, result);
        }

        [Fact]
        public void MaxAreaTest_General_6()
        {
            int[] input = {1, 8, 6, 2, 5, 4, 8, 25, 7};

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.Equal(49, result);
        }

        [Fact]
        public void MaxAreaTest_General_7()
        {
            int[] input = { 1, 8, 25, 2, 5, 4, 8, 3, 7 };

            var solution = new _011_ContainerWithMostWater();
            var result = solution.MaxArea(input);

            Assert.Equal(49, result);
        }
    }
}