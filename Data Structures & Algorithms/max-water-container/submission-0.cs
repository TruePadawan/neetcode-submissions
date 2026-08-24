public class Solution {
    public int MaxArea(int[] heights)
    {
        int l = 0, r = heights.Length - 1;
        int maxArea = 0;
        while (l < r)
        {
            var width = r - l;
            var height = Math.Min(heights[l], heights[r]);
            var area = width * height;
            maxArea = Math.Max(maxArea, area);
            if (heights[l] < heights[r])
            {
                l += 1;
            }
            else
            {
                r -= 1;
            }
        }

        return maxArea;
    }
}