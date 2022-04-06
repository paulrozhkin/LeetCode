using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._201_250
{
    public class _238_ProductOfArrayExceptSelf
    {
        /// <summary>
        /// Time Complexity: O(n).
        /// Space Complexity: O(1). 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];

            var product = 1;
            result[0] = 1;
            for (var i = 0; i < nums.Length - 1; i++)
            {
                product *= nums[i];
                result[i + 1] = product;
            }

            product = nums[^1];
            result[nums.Length - 2] *= product;
            for (var i = nums.Length - 2; i > 0; i--)
            {
                product *= nums[i];
                result[i - 1] *= product;
            }

            return result;
        }

        /*
        /// <summary>
        /// Time Complexity: O(n).
        /// Space Complexity: O(n). 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] ProductExceptSelf(int[] nums)
        {
            var leftProduct = new int[nums.Length];
            var rightProduct = new int[nums.Length];

            var product = 1;
            leftProduct[0] = 1;
            for (var i = 0; i < nums.Length - 1; i++)
            {
                product *= nums[i];
                leftProduct[i + 1] = product;
            }

            product = 1;
            rightProduct[nums.Length - 1] = 1;
            for (var i = nums.Length - 1; i > 0 ; i--)
            {
                product *= nums[i];
                rightProduct[i - 1] = product;
            }

            var result = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                result[i] = leftProduct[i] * rightProduct[i];
            }

            return result;
        }

        /// <summary>
        /// O(N^2)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] ProductExceptSelf(int[] nums)
        {
            var result = new int[nums.Length];
            for (var i = 0; i < nums.Length; i++)
            {
                result[i] = 1;

                for (var j = 0; j < nums.Length; j++)
                {
                    if (i != j)
                    {
                        result[i] *= nums[j];
                    }
                }
            }

            return result;
        }
        */
    }
}