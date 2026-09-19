public class Solution
{
    public int Search(int[] nums, int target)
    {
        /**
         * Use binary search to find the min value
         * Split the array into 2 and do a binary search on the relevant half
         */
        if (nums.First() <= nums.Last()) return BinarySearch(nums, target, 0, nums.Length - 1);

        var l = 0;
        var r = nums.Length - 1;
        var pivotIdx = -1;

        // Find pivot index
        while (l < r)
        {
            var midIdx = (l + r) / 2;
            var mid = nums[midIdx];

            if (mid > nums[r])
            {
                l = midIdx + 1;
            }
            else
            {
                r = midIdx;
            }

            if (l == r)
            {
                pivotIdx = l;
                break;
            }
        }

        // Search left
        if (target >= nums[0] && target <= nums[pivotIdx - 1])
        {
            return BinarySearch(nums, target, 0, pivotIdx - 1);
        }

        return BinarySearch(nums, target, pivotIdx, nums.Length - 1);
    }

    private int BinarySearch(int[] nums, int target, int l, int r)
    {
        while (l <= r)
        {
            var midIdx = (l + r) / 2;
            var mid = nums[midIdx];
            if (target < mid)
            {
                r = midIdx - 1;
            }
            else if (target > mid)
            {
                l = midIdx + 1;
            }
            else if (target == mid)
            {
                return midIdx;
            }
        }

        return -1;
    }
}