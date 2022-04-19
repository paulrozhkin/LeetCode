using System;
using System.Collections.Generic;

namespace LeetCode.Additional
{
    public class SieveOfEratosthenes
    {
        public IEnumerable<int> PrimeNumbers(int n)
        {
            var mask = new bool[n];

            for (var p = 2; p < n; p++)
            {
                if (mask[p])
                    continue;

                yield return p;

                for (var i = p * p; i < n; i += p)
                    mask[i] = true;
            }
        }
    }
}