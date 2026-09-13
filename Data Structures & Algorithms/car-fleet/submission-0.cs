public class Solution
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var compositeList = new List<(int, int)>(position.Length);
        compositeList.AddRange(position.Select((t, i) => (t, speed[i])));
        compositeList.Sort((a, b) => a.Item1.CompareTo(b.Item1));
        var highway = new Stack<double>();

        for (var i = compositeList.Count - 1; i >= 0; i--)
        {
            var (pos, mph) = compositeList[i];
            var arrivalTime = (target - pos) / (double)mph;
            highway.Push(arrivalTime);

            if (highway.Count >= 2)
            {
                var back = highway.Pop();
                var front = highway.Pop();
                if (back <= front)
                {
                    highway.Push(front);
                }
                else
                {
                    highway.Push(front);
                    highway.Push(back);
                }
            }
        }

        return highway.Count;
    }
}