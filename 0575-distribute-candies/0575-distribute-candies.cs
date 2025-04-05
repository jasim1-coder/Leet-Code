using System;
using System.Linq;

public class Solution {
    public int DistributeCandies(int[] candyType) {
        int result = candyType.Count() / 2 ;
        bool same = candyType.All(n => n == candyType[0]);
        int[] dis = candyType.Distinct().ToArray();
        if(result == 1) return 1;
        if(same) return 1;
         if(result > dis.Count()){return dis.Count();}
         else {
            return result;
         }
    }
}