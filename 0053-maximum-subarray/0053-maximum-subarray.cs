public class Solution {
    public int MaxSubArray(int[] nums) {
        int currentsum = 0 , MaxSum = int.MinValue ;
        for(int i = 0 ; i < nums.Length ; i++){
            currentsum += nums[i];
            MaxSum = Math.Max(currentsum , MaxSum);

            if(currentsum < 0){
                currentsum = 0 ;
            }
        }
        return MaxSum ;
    }
}