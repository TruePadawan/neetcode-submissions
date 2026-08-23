public class Solution {
    public int[] TwoSum(int[] nums, int target)
{
    var map = new Dictionary<int, int>();
    int i = 0, j = 0;
    for (var index = 0; index < nums.Length; index++)
    {
        var num = nums[index];
        var diff = target - num;
        if (map.TryGetValue(diff, out var complementIndex))
        {
            i = index;
            j = complementIndex;
        }
        else
        {
            map.Add(num, index);
        }
    }

    return [j, i];
}
}
