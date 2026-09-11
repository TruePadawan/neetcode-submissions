public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        var charCount = new Dictionary<char, int>();
        var l = 0;
        var r = 0;
        var maxSubstringLength = 0;
        while (r < s.Length)
        {
            var currentChar = s[r];
            if (!charCount.TryAdd(currentChar, 1))
            {
                charCount[currentChar] += 1;
            }

            var windowSize = r - l + 1;
            var maxCharCount = GetMaxCharCount(charCount);
            var replacementsNeeded = windowSize - maxCharCount;
            var windowIsValid = replacementsNeeded <= k;
            if (windowIsValid)
            {
                r += 1;
                maxSubstringLength = Math.Max(maxSubstringLength, windowSize);
            }
            else
            {
                charCount[s[l]] -= 1;
                l += 1;
                charCount[currentChar] -= 1;
            }
        }

        return maxSubstringLength;
    }

    public int GetMaxCharCount(Dictionary<char, int> charCount)
    {
        var count = 0;
        foreach (var keyValuePair in charCount)
        {
            if (keyValuePair.Value > count)
            {
                count = keyValuePair.Value;
            }
        }

        return count;
    }
}