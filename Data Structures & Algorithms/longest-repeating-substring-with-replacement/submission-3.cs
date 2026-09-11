public class Solution
{
    public int CharacterReplacement(string s, int k)
    {
        var charCount = new Dictionary<char, int>();
        var l = 0;
        var r = 0;
        var maxCharCount = 1;
        var maxSubstringLength = 0;
        while (r < s.Length)
        {
            var currentChar = s[r];
            if (!charCount.TryAdd(currentChar, 1))
            {
                charCount[currentChar] += 1;
                maxCharCount = Math.Max(charCount[currentChar], maxCharCount);
            }

            var windowSize = r - l + 1;
            // var maxCharCount = GetMaxCharCount(ref charCount);
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

    // private static int GetMaxCharCount(ref Dictionary<char, int> charCount)
    // {
    //     var count = 0;
    //     foreach (var keyValuePair in charCount)
    //     {
    //         if (keyValuePair.Value > count)
    //         {
    //             count = keyValuePair.Value;
    //         }
    //     }
    //
    //     return count;
    // }
}