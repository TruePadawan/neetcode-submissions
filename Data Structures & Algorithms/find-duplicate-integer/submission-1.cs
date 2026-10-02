public class Solution {
    public int FindDuplicate(int[] nums) {
        /**
         * Use tortoise and hare algo to find the cycle
         * Use Floyd's algo to find the start of the cycle
         */

        var tortoise = 0;
        var hare = 0;

        while (hare < nums.Length)
        {
            tortoise = nums[tortoise];
            hare = nums[nums[hare]];

            if (nums[tortoise] == nums[hare]) break;
        }

        var slow = 0;
        while (nums[slow] != nums[tortoise])
        {
            tortoise = nums[tortoise];
            slow = nums[slow];
        }

        return nums[tortoise];
    }
}