public class Solution {
    public bool IsValid(string s)
{
    var stack = new Stack<char>();
    var braces = new Dictionary<char, char>
    {
        ['{'] = '}',
        ['('] = ')',
        ['['] = ']',
    };
    foreach (var c in s)
    {
        if (braces.ContainsKey(c))
        {
            stack.Push(c);
        }
        else
        {
            if (stack.TryPop(out var brace))
            {
                if (braces[brace] != c) return false;
            }
            else return false;
        }
    }

    return stack.Count == 0;
}
}
