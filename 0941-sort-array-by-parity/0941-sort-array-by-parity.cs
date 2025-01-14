public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        List<int> result = new List<int>();
        List<int> result1 = new List<int>();
        for(int i = 0 ; i < nums.Length ; i++){
            if(nums[i] % 2 == 0){
                result.Add(nums[i]);
            }else{
                result1.Add(nums[i]);
            }
        }
        int[] resultt = result.Concat(result1).ToArray();
        return resultt;
    }
}