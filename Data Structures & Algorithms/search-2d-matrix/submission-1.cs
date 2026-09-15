public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int rowCount = matrix.Length;
        int columnCount = matrix[0].Length;
        int l1 = 0;
        int r1 = rowCount - 1;

        while (l1 <= r1)
        {
            int mid1Idx = (l1 + r1) / 2;
            int startingNum = matrix[mid1Idx][0];
            if (startingNum == target) return true;

            if (target < startingNum)
            {
                r1 = mid1Idx - 1;
            }
            // If the target is greater than the last number in the row, then it can't be in the row
            else if (target > matrix[mid1Idx].Last())
            {
                l1 = mid1Idx + 1;
            }
            else
            {
                // Final Binary Search
                int l = 0;
                int r = columnCount - 1;
                while (l <= r)
                {
                    int midIdx = (l + r) / 2;
                    int num = matrix[mid1Idx][midIdx];
                    if (target < num)
                    {
                        r = midIdx - 1;
                    }
                    else if (target > num)
                    {
                        l = midIdx + 1;
                    }
                    else
                    {
                        return true;
                    }
                }

                // Return false if we don't find the target in the row it can only be in
                return false;
            }
        }

        return false;
    }
}