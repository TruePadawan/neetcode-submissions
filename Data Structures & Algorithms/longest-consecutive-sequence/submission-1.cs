public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;
        /***
         * Consider only numbers that start a sequence (K)
         * If the number of Ks == length of num, return early (1)
         * For each k, use a hashset to check if the next number exists
         * If the sequence count >= half the length of nums, return early
         * else, keep track of the longest sequence
         */

        var set = new HashSet<int>(nums);
        var sequenceStarters = new List<int>();

        foreach (var num in set)
        {
            if (set.Contains(num - 1)) continue;
            sequenceStarters.Add(num);
        }

        if (sequenceStarters.Count == nums.Length) return 1;
        var maxCount = -1;
        for (var i = 0; i < sequenceStarters.Count; i++)
        {
            var sequence = sequenceStarters[i];
            var count = 0;
            while (set.Contains(sequence))
            {
                count += 1;
                sequence += 1;
            }

            if (count >= (int)Math.Ceiling(nums.Length / 2d))
            {
                return count;
            }

            maxCount = Math.Max(maxCount, count);
        }

        return maxCount;
    }
}