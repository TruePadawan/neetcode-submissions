public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var prefixProduct = new int[nums.Length];
        var suffixProduct = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                prefixProduct[i] = 1;
                continue;
            }

            prefixProduct[i] = prefixProduct[i - 1] * nums[i - 1];
        }

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (i == nums.Length - 1)
            {
                suffixProduct[i] = 1;
                continue;
            }

            suffixProduct[i] = suffixProduct[i + 1] * nums[i + 1];
        }

        var res = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            res[i] = prefixProduct[i] * suffixProduct[i];
        }

        return res;
    }
}