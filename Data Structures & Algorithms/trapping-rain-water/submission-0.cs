public class Solution {
    public int Trap(int[] height)
    {
        var forward = new int[height.Length];
        var backward = new int[height.Length];
        var highestElevation = 0;
        var waterCount = 0;

        // Do a forward pass to find out the possible amount of rain that can be trapped at each index
        for (int i = 0; i < forward.Length; i++)
        {
            var trap = highestElevation - height[i];
            forward[i] = trap;
            if (trap < 0)
            {
                highestElevation = height[i];
            }
        }
        highestElevation = 0;
        // Do a backward pass to find out the possible amount of rain that can be trapped at each index
        for (int i = height.Length - 1; i >= 0; i--)
        {
            var trap = highestElevation - height[i];
            backward[i] = trap;
            if (trap < 0)
            {
                highestElevation = height[i];
            }
            
            var minTrap = Math.Min(forward[i], backward[i]);
            if (minTrap > 0)
            {
                waterCount += minTrap;
            }
        }

        return waterCount;
    }
}