public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        while (l <= r) {
            int midIdx = (l + r) / 2;
            if (nums[midIdx] < target) {
                l = midIdx + 1;
            } else if (nums[midIdx] > target) {
                r = midIdx - 1;
            } else {
                return midIdx;
            }
        }
        return -1;
    }
}
