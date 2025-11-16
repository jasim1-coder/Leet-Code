public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int result = 0, count = 0 ;
        for(int i = 0 ; i < nums.Length ; i++){
            if(nums[i] == 1){
                count++;
                result = Math.Max(result, count);
            }else{
                count = 0 ;
            }
        }
        return result;
    }
}