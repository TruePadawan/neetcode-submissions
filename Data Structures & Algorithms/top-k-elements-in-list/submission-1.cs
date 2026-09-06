public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var numCount = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (numCount.TryGetValue(num, out var count))
            {
                numCount[num] += 1;
            }
            else
            {
                numCount[num] = 1;
            }
        }

        // Create buckets from 0 to n
        var buckets = new List<int>[nums.Length + 1];
        for (var i = 0; i <= nums.Length; i++)
        {
            buckets[i] = [];
        }

        foreach (var (num, count) in numCount)
        {
            buckets[count].Add(num);
        }

        var result = new int[k];
        var j = 0;
        for (var i = buckets.Length - 1; i >= 0; i--)
        {
            var bucket = buckets[i];
            if (bucket.Count == 0) continue;

            foreach (var el in bucket)
            {
                result[j] = el;
                j += 1;
                if (j == k)
                {
                    break;
                }
            }

            if (j == k)
            {
                break;
            }
        }

        return result;
    }
}