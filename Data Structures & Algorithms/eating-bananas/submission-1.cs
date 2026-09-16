public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        var maxPileCount = piles.Max();
        var minSpeed = int.MaxValue;
        Array.Sort(piles);
        // piles.Sort();

        var l = 1;
        var r = maxPileCount;
        while (l <= r)
        {
            var mid = (l + r) / 2;
            if (IsValidSpeed(piles, mid, h))
            {
                r = mid - 1;
                minSpeed = Math.Min(minSpeed, mid);
            }
            else
            {
                l = mid + 1;
            }
        }

        return minSpeed;
    }

    private bool IsValidSpeed(int[] piles, int speed, int limit)
    {
        double currentHours = 0;
        foreach (var pile in piles)
        {
            var hoursElapsed = pile / (double)speed;
            currentHours += Math.Ceiling(hoursElapsed);

            if (currentHours > limit) return false;
        }

        return true;
    }
}