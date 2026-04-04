public class Solution {
    public bool ContainsDuplicate(int[] nums) {
    Dictionary<int, int> store = new Dictionary<int, int>();
            for(int i = 0 ; i < nums.Length ; i++){
            if(store.ContainsKey(nums[i])){
                return true;
            }else{
            store[nums[i]] = 1;
            }
        }
        return false;
    }
}