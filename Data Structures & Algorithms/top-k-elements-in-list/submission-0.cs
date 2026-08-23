public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var freq = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!freq.TryAdd(num, 1))
            {
                freq[num] += 1;
            }
        }

        var orderedFreq = freq.ToList().OrderByDescending(pair => pair.Value).Take(k).Select(p => p.Key).ToArray();
        return orderedFreq;
    }
}