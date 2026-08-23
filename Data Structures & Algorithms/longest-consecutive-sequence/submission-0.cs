public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        var numSet = new HashSet<int>(nums);
        int longest = 0;
        foreach (var num in nums)
        {
            // Ignore numbers that are not the start of a sequence
            if (numSet.Contains(num - 1))
            {
                continue;
            }

            var sequence = num;
            var sequenceLength = 0;
            while (numSet.Contains(sequence))
            {
                sequence += 1;
                sequenceLength += 1;
            }

            longest = Math.Max(longest, sequenceLength);
        }

        return longest;
    }
}