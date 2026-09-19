public class Solution
{
    public int FindMin(int[] nums)
    {
        if (nums.First() <= nums.Last()) return nums.First();
        var min = int.MaxValue;
        var l = 0;
        var r = nums.Length - 1;

        while (l < r)
        {
            var midIdx = (l + r) / 2;
            var midVal = nums[midIdx];

            // The pivot is somewhere to the right, so we ignore the left
            if (midVal > nums[r])
            {
                l = midIdx + 1;
            }
            else
            {
                r = midIdx;
            }

            if (l == r)
            {
                min = nums[l];
                break;
            }
        }

        return min;
    }
}