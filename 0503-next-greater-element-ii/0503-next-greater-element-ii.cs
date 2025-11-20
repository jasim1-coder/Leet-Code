public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        int[] ans = new int[nums.Length];
        Stack<int> store = new Stack<int>();
        for(int i =  2 * nums.Length - 1 ; i >= 0 ; i -- ){
            
                while(store.Count > 0 && store.Peek() <= nums[i % nums.Length]){
                    store.Pop();
                }

                    if(i < nums.Length){
                    ans[i] = store.Count == 0 ? -1 : store.Peek();
                }
                store.Push(nums[i % nums.Length]);


        }
        return ans;
    }
}