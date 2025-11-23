public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int , int> store = new Dictionary<int , int >();
        for(int i = 0 ; i < nums.Length ; i++){
            int need = target - nums[i];
            if(store.ContainsKey(need)){
                return new int[] { store[need], i};
            }
            store[nums[i]] = i ;
        }
        return new int[2];
    }
}