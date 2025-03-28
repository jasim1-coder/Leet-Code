public class Solution {
    public int[] RearrangeArray(int[] nums) {
          int[] ans = new int[nums.Length];
        int i = 0;
        int j = 1;
        for(int k = 0; k<nums.Length; k++){
            if(nums[k]>0){
                ans[i] = nums[k];
                i += 2;
            }
            else{
                ans[j] = nums[k];
                j += 2;
            }
        }
        return ans;
    }
}