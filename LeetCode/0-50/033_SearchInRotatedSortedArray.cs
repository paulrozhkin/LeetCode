namespace LeetCode._0_50
{
    public class _033_SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            return BinarySearchRotated(nums, target, 0, nums.Length - 1);
        }

        private int BinarySearchRotated(int[] nums, int target, int left, int right)
        {
            if (left <= right)
            {
                var middle = (right + left) / 2;
                var middleNum = nums[middle];

                if (middleNum == target) return middle;

                int leftNum = nums[left];

                if ((leftNum > middleNum && (target < middleNum || target >= leftNum)) ||
                    (leftNum < middleNum && target >= leftNum && target < middleNum))
                {
                    return BinarySearchRotated(nums, target, left, middle - 1);
                }
                else
                {
                    return BinarySearchRotated(nums, target, middle + 1, right);
                }
            }

            return -1;
        }
    }
}