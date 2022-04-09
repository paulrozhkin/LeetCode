using System;
using System.Collections.Generic;

namespace LeetCode._051_100
{
    public class _056_MergeIntervals
    {
        /// <summary>
        /// O(n log n) - Array.Sort
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length < 2)
            {
                return intervals;
            }

            Array.Sort(intervals, Comparison);

            var mergeResult = new List<int[]>
            {
                new[] {intervals[0][0], intervals[0][1]}
            };

            for (var i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] <= mergeResult[^1][1])
                {
                    mergeResult[^1][1] = Math.Max(intervals[i][1], mergeResult[^1][1]);
                }
                else
                {
                    mergeResult.Add(new int[2]);
                    mergeResult[^1][0] = intervals[i][0];
                    mergeResult[^1][1] = intervals[i][1];
                }
            }

            return mergeResult.ToArray();
        }

        private static int Comparison(int[] x, int[] y)
        {
            if (x[0] < y[0])
                return -1;
            if (x[0] > y[0])
                return 1;

            return 0;
        }
    }
}
