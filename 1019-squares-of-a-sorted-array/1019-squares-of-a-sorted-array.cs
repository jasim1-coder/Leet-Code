public class Solution {
    public int[] SortedSquares(int[] nums) {
        int l = 0 ; 
        int[] result = new int[nums.Length];
        for(int r = 0 ; r < nums.Length ; r++  ){
            result[r] = nums[r] * nums[r];
        }
         Array.Sort(result);
         return result;
    }
}