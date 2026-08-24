public class Solution
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int l = 0, r = numbers.Length - 1;

        while (l < r)
        {
            var num = numbers[l] + numbers[r];
            if (target == num)
            {
                break;
            }

            if (target < num)
            {
                r -= 1;
            }
            else
            {
                l += 1;
            }
        }

        return [l+1, r+1];
    }
}