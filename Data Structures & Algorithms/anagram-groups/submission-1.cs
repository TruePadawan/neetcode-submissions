public class Solution
{
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, List<string>>();
        foreach (var str in strs)
        {
            var charCount = new int[26];
            foreach (var letter in str)
            {
                var pos = letter - 'a';
                charCount[pos] += 1;
            }

            var key = string.Join(",", charCount);
            if (map.TryGetValue(key, out var list))
            {
                list.Add(str);
            }
            else
            {
                map[key] = [str];
            }
        }

        return map.Values.ToList();
    }
}