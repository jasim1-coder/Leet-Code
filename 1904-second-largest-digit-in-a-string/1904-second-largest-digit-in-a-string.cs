// public class Solution {
//     public int SecondHighest(string s) {
//         List<int> result = new List<int>();
//         foreach(char num in s){
//             if(char.IsDigit(num)){
//                 result.Add(num - '0');
//             }
//         }
//         result = result.Distinct().OrderByDescending(x => x).ToList();
//         return result[1];
//     }
// }

using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int SecondHighest(string s)
    {
        List<int> result = new List<int>();

        foreach (char num in s)
        {
            if (char.IsDigit(num)) 
            {
                result.Add(num - '0');
            }
        }

        result = result.Distinct().OrderByDescending(x => x).ToList();

        return result.Count > 1 ? result[1] : -1;
    }
}
