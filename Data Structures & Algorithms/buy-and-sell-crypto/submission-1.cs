public class Solution {
    public int MaxProfit(int[] prices)
    {
        int l = 0, r = 1;
        int maxProfit = 0;
        while (r < prices.Length)
        {
            if (prices[r] >= prices[l])
            {
                var profit = prices[r] - prices[l];
                maxProfit = Math.Max(profit, maxProfit);
                r += 1;
            } else if (prices[r] < prices[l])
            {
                l = r;
                r = l + 1;
            }
        }

        return maxProfit;
    }
}
