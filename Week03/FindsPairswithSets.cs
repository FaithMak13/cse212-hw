using System;
using System.Collections.Generic;

public static class FindsPairsWithSets
{
    public static List<string> FindPairsWithSets(int[] arr, int target)
    {
        HashSet<int> seen = new HashSet<int>();
        HashSet<int> used = new HashSet<int>();
        List<string> result = new List<string>();

        foreach (int num in arr)
        {
            int complement = target - num;
            if (seen.Contains(complement) && !used.Contains(num) && !used.Contains(complement))
            {
                int first = Math.Min(num, complement);
                int second = Math.Max(num, complement);
                result.Add($"{first}, {second}");
                used.Add(first);
                used.Add(second);
            }
            seen.Add(num);
        }

        return result;
    }
}
