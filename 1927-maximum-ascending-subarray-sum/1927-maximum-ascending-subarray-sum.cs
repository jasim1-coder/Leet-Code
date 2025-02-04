public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int maxSum = 0, currentSum = nums[0];  
        
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > nums[i - 1]) {
                currentSum += nums[i];
            } else {  
                maxSum = Math.Max(maxSum, currentSum); 
                currentSum = nums[i];
            }
        }
        return Math.Max(maxSum, currentSum);  
    }
}
