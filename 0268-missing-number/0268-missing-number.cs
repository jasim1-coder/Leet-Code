public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length ;
        int sum = 0 ;
        int max = (n * (n+1))/2;
        for(int i = 0 ; i < n ; i++){
            sum += nums[i];
        }
        return max - sum ;
    
    }
}