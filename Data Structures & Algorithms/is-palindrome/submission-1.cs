public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (s.Length <= 1)
        {
            return true;
        }

        var builder = new StringBuilder("");
        for (var index = 0; index < s.Length; index++)
        {
            var c = s[index];
            if (char.IsLetterOrDigit(c))
            {
                builder.Append(char.ToLowerInvariant(c));
            }
        }

        s = builder.ToString();

        // Check for even and odd length palindromes
        int i = s.Length / 2;
        int j = i;
        if (s.Length % 2 == 0)
        {
            j = i - 1;
        }

        while (j >= 0 && i < s.Length)
        {
            if (s[i] != s[j]) return false;
            i += 1;
            j -= 1;
        }

        return true;
    }
}