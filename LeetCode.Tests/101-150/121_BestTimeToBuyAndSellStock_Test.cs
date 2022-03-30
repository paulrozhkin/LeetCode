using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCode._101_150
{
    public class _121_BestTimeToBuyAndSellStock_Test
    {
        [Fact]
        public void MaxProfitTest_1()
        {
            var solution = new _121_BestTimeToBuyAndSellStock();
            var result = solution.MaxProfit(new[] { 7, 1, 5, 3, 6, 4 });
            Assert.Equal(5, result);
        }

        [Fact]
        public void MaxProfitTest_2()
        {
            var solution = new _121_BestTimeToBuyAndSellStock();
            var result = solution.MaxProfit(new[] { 7, 6, 4, 3, 1 });
            Assert.Equal(0, result);
        }

        [Fact]
        public void MaxProfitTest_3()
        {
            var solution = new _121_BestTimeToBuyAndSellStock();
            var result = solution.MaxProfit(new[] { 1, 2 });
            Assert.Equal(1, result);
        }
    }
}
