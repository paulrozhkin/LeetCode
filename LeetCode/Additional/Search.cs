using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Additional
{
    public class Search
    {
        public static int BinarySearch(int[] array, int value)
        {
            var low = 0;
            var high = array.Length;

            while (low < high)
            {
                var middle = (high + low) / 2;

                if (array[middle] == value)
                    return middle;
                if (array[middle] > value)
                    high = middle;
                else
                    low = middle + 1;
            }

            return -1;
        }

        public static int BinarySearchRecursion(int[] array, int value)
        {
            return BinarySearchRecursionFromTo(0, array.Length);

            int BinarySearchRecursionFromTo(int low, int high)
            {
                if (low >= high)
                {
                    return -1;
                }

                var mid = (low + high) / 2;
                if (array[mid] == value)
                    return mid;
                if (array[mid] > value)
                    return BinarySearchRecursionFromTo(low, mid);
                else
                {
                    return BinarySearchRecursionFromTo(mid + 1, high);
                }
            }
        }
    }
}