public class Solution
{
    public int LengthOfLongestSubstring(string s)
{
    if (s.Length <= 1) return s.Length;
    var table = new Dictionary<char, int>();
    int l = 0, r = 0;
    int length = 0;
    while (r < s.Length)
    {
        if (!table.ContainsKey(s[r]))
        {
            table[s[r]] = r;
            r += 1;
        }
        else
        {
            length = Math.Max(length, r - l);
            // Remove all key-value pair outside our window
            while (table.ContainsKey(s[r])) {
                table.Remove(s[l]);
                l += 1;
            }
            table[s[r]] = r;
            r += 1;
        }
    }

    length = Math.Max(length, r - l);


    return length;
}
}