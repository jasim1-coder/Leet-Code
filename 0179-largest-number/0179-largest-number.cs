using System;
using System.Linq;

public class Solution
{
    public string LargestNumber(int[] nums)
    {
        var numsStr = nums.Select(n => n.ToString()).ToArray();

        Array.Sort(numsStr, (a, b) => (b + a).CompareTo(a + b));

        if (numsStr[0] == "0") return "0";

        return string.Concat(numsStr);
    }
}
