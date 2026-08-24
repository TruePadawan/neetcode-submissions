public class Solution
{
    // [-4,-1,-1,0,1,2]
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<List<int>>();
        var ignoredNums = new HashSet<int>();
        var foundTriplets = new HashSet<string>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            var pivot = nums[i];
            if (ignoredNums.Contains(pivot)) continue;
            // Find the 2 numbers that sum up to (0 - pivot)
            int l = i + 1, r = nums.Length - 1;
            var target = 0 - pivot;
            while (l < r)
            {
                var sum = nums[l] + nums[r];
                if (sum == target)
                {
                    List<int> triplet = [pivot, nums[l], nums[r]];
                    triplet.Sort();
                    var tripletStr = string.Join("", triplet);
                    if (!foundTriplets.Contains(tripletStr))
                    {
                        result.Add(triplet);
                        foundTriplets.Add(string.Join("", triplet));
                    }

                    l += 1;
                    r -= 1;
                }
                else if (sum < target)
                {
                    l += 1;
                }
                else
                {
                    r -= 1;
                }
            }

            ignoredNums.Add(pivot);
        }

        return result;
    }
}