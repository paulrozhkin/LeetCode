using System;

namespace LeetCode._101_150
{
    public class _121_BestTimeToBuyAndSellStock
    {
        // O(N)
        public int MaxProfit(int[] prices)
        {
            var minPrice = prices[0];
            var maxProfit = 0;

            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] > minPrice)
                {
                    maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
                }
                else
                {
                    minPrice = prices[i];
                }
            }

            return maxProfit;
        }

        // O(N^2)
        //public int MaxProfit(int[] prices)
        //{
        //    var maxProfit = 0;
        //    for (var i = 0; i < prices.Length; i++)
        //    {
        //        for (var j = i + 1; j < prices.Length; j++)
        //        {
        //            if (prices[j] - prices[i] > maxProfit)
        //            {
        //                maxProfit = prices[j] - prices[i];
        //            }
        //        }
        //    }

        //    return maxProfit;
        //}
    }
}